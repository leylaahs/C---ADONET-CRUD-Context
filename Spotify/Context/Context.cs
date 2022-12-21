﻿using ADONET.Abstractions;
using ADONET.Models;
using ADONET.Services;

namespace ADONET.context
{
    internal class Context
    {
        IService<Artist> _artists;
        IService<Music> _musics;

        public IService<Artist> Artists
        {
            get
            {
                if (_artists == null)
                {
                    _artists = new ArtistService();
                }
                return _artists;
            }
        }
        public IService<Music> Musics { get => _musics ?? new MusicService(); }

    }
}