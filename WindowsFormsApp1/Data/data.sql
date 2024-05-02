CREATE TABLE Media (
  media_id integer NOT NULL PRIMARY KEY AUTOINCREMENT,
  Mediapath text NOT NULL,
  UNIQUE(Mediapath)
);

CREATE TABLE Playlist (
 playlist_id integer NOT NULL PRIMARY KEY AUTOINCREMENT,
 Playlist text NOT NULL,
 UNIQUE(Playlist)
);

CREATE TABLE MediaPlaylist (
   mediaplaylist_id integer NOT NULL PRIMARY KEY AUTOINCREMENT,
   media_id integer NOT NULL,
   playlist_id integer NOT NULL,
   FOREIGN KEY(media_id) REFERENCES Media(media_id),
   FOREIGN KEY(playlist_id) REFERENCES Playlist(playlist_id),
   UNIQUE(media_id, playlist_id)
);