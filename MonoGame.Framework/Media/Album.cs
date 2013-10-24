#if WINDOWS_PHONE
extern alias MicrosoftXnaFramework;
using MsAlbum = MicrosoftXnaFramework::Microsoft.Xna.Framework.Media.Album;
#endif
using System;
using System.IO;

namespace Microsoft.Xna.Framework.Media
{
    public sealed class Album : IDisposable
    {
#if WINDOWS_PHONE
        private MsAlbum album;

        public Artist Artist
        {
            get
            {
                return album.Artist;
            }
        }

        /// <summary>
        /// Gets the duration of the Album.
        /// </summary>
        public TimeSpan Duration
        {
            get
            {
                return album.Duration;
            }
        }

        /// <summary>
        /// Gets the Genre of the Album.
        /// </summary>
        public Genre Genre
        {
            get
            {
                return album.Genre;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the Album has associated album art.
        /// </summary>
        public bool HasArt
        {
            get
            {
                return this.album.HasArt;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the object is disposed.
        /// </summary>
        public bool IsDisposed
        {
            get
            {
                return album.IsDisposed;
            }
        }

        /// <summary>
        /// Gets the name of the Album.
        /// </summary>
        public string Name
        {
            get
            {
                return album.Name;
            }
        }

        /// <summary>
        /// Gets a SongCollection that contains the songs on the album.
        /// </summary>
        public SongCollection Songs
        {
            get
            {
                return album.Songs;
            }
        }

        public static implicit operator Album(MsAlbum album)
        {
            return new Album(album);
        }

        private Album(MsAlbum album)
        {
            this.album = album;
        }
#endif

        /// <summary>
        /// Immediately releases the unmanaged resources used by this object.
        /// </summary>
        public void Dispose()
        {
            this.album.Dispose();
        }

        /// <summary>
        /// Returns the stream that contains the album art image data.
        /// </summary>
        public Stream GetAlbumArt()
        {
            return this.album.GetAlbumArt();
        }

        /// <summary>
        /// Returns the stream that contains the album thumbnail image data.
        /// </summary>
        public Stream GetThumbnail()
        {
            return this.album.GetThumbnail();
        }

        /// <summary>
        /// Returns a String representation of this Album.
        /// </summary>
        public override string ToString()
        {
            return this.album.ToString();
        }

        /// <summary>
        /// Gets the hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            return this.album.GetHashCode();
        }
    }
}
