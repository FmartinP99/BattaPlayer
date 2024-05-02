using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2(List<string> existingPlaylistNames)
        {
            InitializeComponent();
            this.existingPlaylistNames = existingPlaylistNames;
        }

        private List<string> existingPlaylistNames;
        private readonly List<string> forbiddenPlaylistNames = new List<string> { "", "temp", "New Playlist" };

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (forbiddenPlaylistNames.Contains(textBoxPlaylistName.Text))
            {
               MessageBox.Show($"This playlist name is forbidden!\nPlease use something else!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (existingPlaylistNames.Contains(textBoxPlaylistName.Text))
            {
                MessageBox.Show($"This playlist name is already exists!\nPlease use something else!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public String getPlaylistName()
        {
            return this.textBoxPlaylistName.Text;
        }

        private void textBoxPlaylistName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
