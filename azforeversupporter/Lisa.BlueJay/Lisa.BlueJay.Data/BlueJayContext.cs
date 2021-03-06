﻿using Lisa.BlueJay.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Lisa.BlueJay.Data
{
    public class BlueJayContext : DbContext
    {
        public BlueJayContext()
            : this("name=BlueJayContext")
        {
        }

        public BlueJayContext(string connectionString)
            : base(connectionString)
        {
        }

        public DbSet<Note> Notes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<NoteMedia> NoteMedia { get; set; }
        public DbSet<Dossier> Dossiers { get; set; }
        public DbSet<Profile> Profiles { get; set; }
    }
}
