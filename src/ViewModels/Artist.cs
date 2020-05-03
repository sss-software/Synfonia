﻿using LiteDB;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Symphony.ViewModels
{
    public class Artist
    {
        public const string CollectionName = "artists";
        private string _name;

        public int ArtistId { get; set; }

        public string Name
        {
            get { return Regex.Unescape(_name); }
            set { _name = value; }
        }


        [BsonRef(Album.CollectionName)]
        public List<Album> Albums { get; set; } = new List<Album>();
    }
}