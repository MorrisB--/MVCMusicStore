using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCMusicStore_Team8.Models {
    public class MusicStoreEntities : DbContext {
        public MusicStoreEntities() : base("name=MusicStoreEntities") { }
        public DbSet<MVCMusicStore_Team8.Models.Album> Albums { get; set; }
        public DbSet<MVCMusicStore_Team8.Models.Genre> Genres { get; set; }
        public DbSet<MVCMusicStore_Team8.Models.Artist> Artists { get; set; }
    }
}