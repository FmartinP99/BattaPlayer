using AxWMPLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.Resources;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WindowsFormsApp1
{
    public partial class BattaPlayerApp : Form
    {
        public BattaPlayerApp()
        {
            InitializeComponent();
            dataController = new DataController();
            addTodataGridViewSongs(null, true);
            populateMenuDropDownPlaylists();

            LastVolume = trackBarVolume.Value = WindowsMediaPlayer1.settings.volume = 5;
            pictureBoxPlayPause.Image = playButtonImage;
            WindowsMediaPlayer1.uiMode = "none";
          
        }

        DataController dataController;
        Bitmap playButtonImage = ImgResources.icons8_play_100;
        Bitmap pauseButtonImage = ImgResources.icons8_pause_100;
        Bitmap stopButtonImage = ImgResources.icons8_stop_100;
        Bitmap soundButtonImage = ImgResources.icons8_sound_100;
        Bitmap muteButtonImage = ImgResources.icons8_mute_100;
        private bool isDragging = false;
        private Point dragStartPosition;

        private int _lastVolume;
        private int indexPlaying = -1;

        private bool contextMenuPlaylistClosing = true;
        private string _currentPlaylist = "temp";
        string[] enabled_media_extensions = { ".mp3", ".wav", ".flac", ".aac", ".avi" };


        private int LastVolume
        {
            get { return _lastVolume; }
            set
            {
                if (value == 0) pictureBoxVolumeMute.Image = muteButtonImage;
                else if (pictureBoxVolumeMute.Image != soundButtonImage) pictureBoxVolumeMute.Image = soundButtonImage;
                _lastVolume = value;
            }
        }

        public string CurrentPlaylist { get => _currentPlaylist; 
            set
            {
                _currentPlaylist = value;
                if (_currentPlaylist == "temp")
                {
                    buttonClearSongs.Enabled = false;
                    buttonImport.Enabled = false;
                    dataGridViewSongs.AllowDrop = false;

                }
                else
                {
                    buttonClearSongs.Enabled = true;
                    buttonImport.Enabled = true;
                    dataGridViewSongs.AllowDrop = true;
                }
            }}

        private void addTodataGridViewSongs(string[] mPaths, bool startup=false, string playlist="temp")
        {

            dataGridViewSongs.Rows.Clear();
            if (!startup) dataController.addBulk(mPaths.Select(m => m).ToList(), playlist);
            List<string[]> medias = dataController.getMedias(playlist);
            int counter = 0;
            foreach (string[] media in medias)
            {
                string filename = Path.GetFileName(media[0]);
                dataGridViewSongs.Rows.Add(new object[] { media[0], counter + 1, filename });
                counter += 1;
            }

            string newTitle = CurrentPlaylist == "temp" ? "All Songs" : CurrentPlaylist;
            dataGridViewSongs.Columns[2].HeaderText = $"Title - {newTitle}";



            populateMenuDropDownPlaylists();



        }

        private void dataGridViewSongs_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void dataGridViewSongs_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            files = FilterAudioFiles(files);
            string[] newPaths = { };
            foreach (string file in files)
            {
                bool isFolder = Directory.Exists(Path.GetFullPath(file));

                if (!isFolder)
                {
                    string newPath = Path.GetFullPath(file);
                    newPaths = newPaths.Concat(new[] { file }).ToArray();
                }
          
                else
                {
                    string[] filesFromFolder = Directory.GetFiles(file);
                    filesFromFolder = FilterAudioFiles(filesFromFolder);
                    foreach (string file2 in filesFromFolder)
                    {
                         string newPath = Path.GetFullPath(file2);
                         newPaths = newPaths.Concat(new[] { file2 }).ToArray();
                    }
                }
            }

            //adding the new drag&dropped files to the playlist but only those that wasn't in the playlist before.
            if (newPaths.Length > 0)
            {
                addTodataGridViewSongs(newPaths, false, CurrentPlaylist);
                MessageBox.Show($"{newPaths.Length} new file(s) has been added to the playlist!");
            }
        }


        private void dataGridViewSongs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewSongs.Rows.Count)
            {
                if (dataGridViewSongs.Rows[e.RowIndex].Cells["FilePath"].Value == null) return;
                string selected_media = dataGridViewSongs.Rows[e.RowIndex].Cells["FilePath"].Value.ToString();

                if (File.Exists(selected_media))
                {
                    WindowsMediaPlayer1.URL = selected_media;
                    indexPlaying = e.RowIndex;
                        }
                else MessageBox.Show($"An error occurred: The file doesn't exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String[] mediaPaths = ofd.FileNames;
                mediaPaths = FilterAudioFiles(mediaPaths);
                addTodataGridViewSongs(mediaPaths, false, CurrentPlaylist);
                MessageBox.Show($"{mediaPaths.Length} new file(s) has been added to the playlist!");
            }

        }


        private void pboxCloseIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private String[] FilterAudioFiles(String[] input)
        {
            
            return input.Where(c =>
            {
                //if the item is a folder
                if (Directory.Exists(c)) return true;
                //if the extension is matching
                return this.enabled_media_extensions.Any(x => c.EndsWith(x));
            }).ToArray();
        }

        private void BattaPlayerApp_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            menuDropDownPlaylists.IsMainMenu = true;
        }

        private void pictureBoxFullScreen_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;

        }

        private void pictureBoxMinimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void tableLayoutRight_SizeChanged(object sender, EventArgs e)
        {
            //  int firstRowHeight = this.Height - tableLayoutRight.GetRowHeights()[1] - tableLayoutRight.Margin.Vertical;
            // tableLayoutRight.RowStyles[0].Height = firstRowHeight;
            tableLayoutButtons.Dock = DockStyle.Fill;
            int newpadsize = buttonImport.Height / 20;
            tableLayoutButtons.Padding = new Padding(newpadsize, newpadsize, newpadsize, newpadsize);
        }

        private void tableLayoutButtons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragStartPosition = e.Location;
            }
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;

            }
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Calculate new position for the form
                int newX = this.Left + e.X - dragStartPosition.X;
                int newY = this.Top + e.Y - dragStartPosition.Y;

                // Update form's location
                this.Location = new Point(newX, newY);
            }
        }

        private void WindowsMediaPlayer1_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (WindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {

                timerMedia.Start();
                pictureBoxPlayPause.Image = pauseButtonImage;

                labelMediaName.Text = dataGridViewSongs.Rows[indexPlaying].Cells["Title"].Value.ToString();
            }
            else if (WindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timerMedia.Stop();
                pictureBoxPlayPause.Image = playButtonImage;
            }
            else if (WindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timerMedia.Stop();
                progressBarMedia.Value = 0;
            }
            else if (WindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                play_next_media();
               
            }else if (WindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsReady)
            {
                WindowsMediaPlayer1.Ctlcontrols.play();
            }
         
        }

        private void timerMedia_Tick(object sender, EventArgs e)
        {
            labelProgress.Text = WindowsMediaPlayer1.Ctlcontrols.currentPositionString + " / " + WindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
            if (WindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBarMedia.Value = (int)WindowsMediaPlayer1.Ctlcontrols.currentPosition;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBarMedia_Click(object sender, EventArgs e)
        {
            float absoluteMouse = (PointToClient(MousePosition).X - progressBarMedia.Bounds.X);
            float calcFactor = progressBarMedia.Width / (float)progressBarMedia.Maximum;
            float relativeMouse = absoluteMouse / calcFactor;
            int relativeMouseInt = Convert.ToInt32(relativeMouse);
            if (relativeMouse > progressBarMedia.Minimum + 1 && relativeMouse < progressBarMedia.Maximum)
            {
                progressBarMedia.Value = relativeMouseInt;
                progressBarMedia.Value = relativeMouseInt - 1;
                progressBarMedia.Value = relativeMouseInt;
            }
            WindowsMediaPlayer1.Ctlcontrols.currentPosition = Convert.ToInt32(relativeMouse);

        }




        private void progressBarMedia_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WindowsMediaPlayer1.Ctlcontrols.pause();
                float absoluteMouse = e.X - progressBarMedia.Bounds.X;
                float calcFactor = progressBarMedia.Width / (float)progressBarMedia.Maximum;
                float relativeMouse = absoluteMouse / calcFactor;
                if (relativeMouse > progressBarMedia.Minimum + 1 && relativeMouse < progressBarMedia.Maximum)
                {
                    progressBarMedia.Value = Convert.ToInt32(relativeMouse);
                    progressBarMedia.Value = Convert.ToInt32(relativeMouse) - 1;
                    progressBarMedia.Value = Convert.ToInt32(relativeMouse);
                }
                WindowsMediaPlayer1.Ctlcontrols.currentPosition = Convert.ToInt32(relativeMouse);
            }
        }

        private void progressBarMedia_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) WindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void pictureBoxPlayPause_Click(object sender, EventArgs e)
        {
            if (pictureBoxPlayPause.Image == pauseButtonImage)
            {
                WindowsMediaPlayer1.Ctlcontrols.pause();
            }
            else
            {
                WindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void pictureBoxPlayPause_SizeChanged(object sender, EventArgs e)
        {
            pictureBoxPlayPause.Width = pictureBoxPlayPause.Height;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxStopButton_SizeChanged(object sender, EventArgs e)
        {
            pictureBoxStopButton.Width = pictureBoxStopButton.Height;
        }

        private void pictureBoxStopButton_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void pictureBoxPreviousButton_SizeChanged(object sender, EventArgs e)
        {
            pictureBoxPreviousButton.Width = pictureBoxPreviousButton.Height;
        }

        private void pictureBoxNextButton_SizeChanged(object sender, EventArgs e)
        {
            pictureBoxNextButton.Width = pictureBoxNextButton.Height;
        }

        private void pictureBoxVolumeMute_SizeChanged(object sender, EventArgs e)
        {
            pictureBoxVolumeMute.Width = pictureBoxVolumeMute.Height;
        }



        private void pictureBoxVolumeMute_Click(object sender, EventArgs e)
        {
            if (WindowsMediaPlayer1.settings.volume != 0)
            {
                WindowsMediaPlayer1.settings.volume = 0;
                pictureBoxVolumeMute.Image = muteButtonImage;
                trackBarVolume.Value = 0;

            }
            else
            {
                WindowsMediaPlayer1.settings.volume = LastVolume;
                pictureBoxVolumeMute.Image = soundButtonImage;
                trackBarVolume.Value = LastVolume;
            }
        }

        private void WindowsMediaPlayer1_MediaChange(object sender, _WMPOCXEvents_MediaChangeEvent e)
        {
            progressBarMedia.Maximum = (int)WindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            LastVolume = WindowsMediaPlayer1.settings.volume = trackBarVolume.Value;
        }

        private void dataGridViewSongs_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            
            Color customColorLight = Color.FromArgb(100, 100, 100);
            Color customColorDark = Color.FromArgb(60, 60, 60);

            if (e.RowIndex % 2 == 0)
            {
                dataGridViewSongs.Rows[e.RowIndex].DefaultCellStyle.BackColor = customColorLight;
            }
            else
            {
                dataGridViewSongs.Rows[e.RowIndex].DefaultCellStyle.BackColor = customColorDark;
            }
        }

        private void buttonImport_SizeChanged(object sender, EventArgs e)
        {
            int fontsize = buttonImport.Height / 4;
            buttonImport.Font = new Font(buttonImport.Font.FontFamily, fontsize, buttonImport.Font.Style);
        }

        private void buttonClearSongs_SizeChanged(object sender, EventArgs e)
        {
            int fontsize = buttonClearSongs.Height / 4;
            buttonClearSongs.Font = new Font(buttonImport.Font.FontFamily, fontsize, buttonImport.Font.Style);
        }

        private void pictureBoxPreviousButton_Click(object sender, EventArgs e)
        {
            int selected_index = -1;
            if (indexPlaying > 0) selected_index = indexPlaying - 1;
            else if (indexPlaying == 0) selected_index = dataGridViewSongs.RowCount - 1;



            string selected_media = dataGridViewSongs.Rows[selected_index].Cells["FilePath"].Value.ToString();
            WindowsMediaPlayer1.URL = selected_media;
            if (File.Exists(selected_media))
            {
                WindowsMediaPlayer1.URL = selected_media;
                indexPlaying = selected_index;
            }
        }


        private void play_next_media()
        {
            int selected_index = -1;
            if (indexPlaying < dataGridViewSongs.RowCount - 1) selected_index = indexPlaying + 1;
            else if (indexPlaying == dataGridViewSongs.RowCount - 1) selected_index = 0;



            string selected_media = dataGridViewSongs.Rows[selected_index].Cells["FilePath"].Value.ToString();
            WindowsMediaPlayer1.URL = selected_media;
            if (File.Exists(selected_media))
            {
                WindowsMediaPlayer1.URL = selected_media;
                indexPlaying = selected_index;
            }
        }


        private void pictureBoxNextButton_Click(object sender, EventArgs e)
        {
            play_next_media();
        }

        private void buttonDBTeszt_Click(object sender, EventArgs e)
        {
            //MediaModel mm = new MediaModel("f:/teszt/teszt.mp3", "");
            //bool response_Add = mediaController.AddMedia(mm);
            //MessageBox.Show($"{response_Add}");

            var mms = dataController.getMediaModells();
            var pms = dataController.getPlaylistModells();
            var mps =  dataController.getMedias();
            var full = mms.Concat(pms).ToList();
            MessageBox.Show($"{string.Join(Environment.NewLine, mms.Select(m => m))}\n");
            MessageBox.Show($"{string.Join(Environment.NewLine, pms.Select(m => m))}\n");
            MessageBox.Show($"{string.Join(Environment.NewLine, mps.Select(m => $"MediaPath: {m[0]}, Playlist: {m[1]}\n"))}");

            var mpstemp = dataController.getMedias();
            MessageBox.Show($"{string.Join(Environment.NewLine, mpstemp.Select(m => $"MediaPath: {m[0]}, Playlist: {m[1]}\n"))}");
        }

        private void buttonClearSongs_Click(object sender, EventArgs e)
        {
            //dataController.deleteEntireData();
            
            dataController.clearPlaylist(CurrentPlaylist);
            dataGridViewSongs.Rows.Clear();
            populateMenuDropDownPlaylists();
        }

        private void dataGridViewSongs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuDropDownPlaylists.Show(button1, button1.Width, 0);
        }

        private void tableLayoutLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuDropDown1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
     

            if (e.ClickedItem.ToString() == "Add Playlist (+)")
            {
               
                ToolStripItem item1 = e.ClickedItem;
                ToolStripItem item2 = new ToolStripMenuItem("New Playlist");
                menuDropDownPlaylists.Items.Remove(item1);

                menuDropDownPlaylists.Items.Add(item2);
                menuDropDownPlaylists.Items.Add(item1);

                this.contextMenuPlaylistClosing = true;
            }
            else if (e.ClickedItem.ToString() == "Show All")
            {
                CurrentPlaylist = "temp";
                addTodataGridViewSongs(null, true, CurrentPlaylist);
            }
            else if (e.ClickedItem.ToString() == "New Playlist")
            {

                List<string> existingPlaylistNames = dataController.GetPlaylists();

                Form2 form2= new Form2(existingPlaylistNames);
               
                DialogResult result = form2.ShowDialog();
                if (result == DialogResult.OK)
                {
                    String playlistname = form2.getPlaylistName();
                    e.ClickedItem.Text = playlistname;
                    dataController.AddPlaylistModel(playlistname);
                    populateMenuDropDownPlaylists();

                }
            }else if(e.ClickedItem.ToString() == "Delete")
            {
                var parent = e.ClickedItem.OwnerItem;
                string parentText = parent.Text;
                dataController.deletePlaylist(parentText);
                addTodataGridViewSongs(null, true);

            }else if (e.ClickedItem.ToString() == "Rename")
            {
                List<string> existingPlaylistNames = dataController.GetPlaylists();

                Form2 form2 = new Form2(existingPlaylistNames);

                DialogResult result = form2.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string old_name = e.ClickedItem.OwnerItem.Text;
                    string new_name = form2.getPlaylistName();
                    e.ClickedItem.OwnerItem.Text = new_name;
                    dataController.modifyPlaylistName(old_name, new_name);
                    
                    populateMenuDropDownPlaylists();
                    if(CurrentPlaylist == old_name) {
                        CurrentPlaylist = new_name;
                        dataGridViewSongs.Columns[2].HeaderText = $"Title - {new_name}";
                    }
                }
            }
            else
            {
                CurrentPlaylist = e.ClickedItem.ToString();
                addTodataGridViewSongs(null, true, CurrentPlaylist);
            }
        }

        private void menuDropDownPlaylists_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            if (contextMenuPlaylistClosing)
            {
                e.Cancel = true;
                contextMenuPlaylistClosing = false;
            }
        }



        private void populateMenuDropDownPlaylists()
        {
            List<Object> itemsToRemove = new List<Object>();

            foreach (var elem in menuDropDownPlaylists.Items)
            {
                if (elem.ToString() != "Show All")
                {
                    itemsToRemove.Add(elem);
                }
            }

            foreach (ToolStripItem item in itemsToRemove)
            {
                menuDropDownPlaylists.Items.Remove(item);
            }


            List<string> playlists = dataController.GetPlaylists();

            foreach(string playlist in playlists)
            {
                if (playlist != "temp")
                {
                    ToolStripMenuItem newItem = new ToolStripMenuItem(playlist);
                    ToolStripMenuItem renameItem = new ToolStripMenuItem("Rename");
                    ToolStripMenuItem deleteItem = new ToolStripMenuItem("Delete");
          
                    newItem.DropDownItems.Add(renameItem);
                    newItem.DropDownItems.Add(deleteItem);
                    newItem.DropDownItemClicked += menuDropDown1_ItemClicked;
                    menuDropDownPlaylists.Items.Add(newItem);


                }
            }
            menuDropDownPlaylists.Items.Add("Add Playlist (+)");

        }

        private void labelMediaName_Click(object sender, EventArgs e)
        {
            
        }

        private void labelMediaName_SizeChanged(object sender, EventArgs e)
        {   
            int new_height = labelMediaName.Height;
            Font labelFont = new Font(labelMediaName.Font.FontFamily, (int)(new_height/3), labelMediaName.Font.Style);
            labelMediaName.Font = labelFont;

        }

        private void labelProgress_SizeChanged(object sender, EventArgs e)
        {
            int new_height = labelProgress.Height;
            Font labelFont = new Font(labelProgress.Font.FontFamily, (int)(new_height / 3), labelProgress.Font.Style);
            labelProgress.Font = labelFont;
        }
    }
}