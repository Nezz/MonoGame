#if WINDOWS_PHONE
extern alias MicrosoftXnaFramework;
using MsArtist = MicrosoftXnaFramework::Microsoft.Xna.Framework.Media.Artist;
#endif
using System;

namespace Microsoft.Xna.Framework.Media
{
    public sealed class Artist : IDisposable
    {
#if WINDOWS_PHONE
        private MsArtist artist;

        /// <summary>
        /// Gets the AlbumCollection for the Artist.
        /// </summary>
        public AlbumCollection Albums
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets a value indicating whether the object is disposed.
        /// </summary>
        public bool IsDisposed
        {
            get
            {
                return this.IsDisposed;
            }
        }

        /// <summary>
        /// Gets the name of the Artist.
        /// </summary>
        public string Name
        {
            get
            {
                return this.artist.Name;
            }
        }

        /// <summary>
        /// Gets the SongCollection for the Artist.
        /// </summary>
        public SongCollection Songs
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public static implicit operator Artist(MsArtist artist)
        {
            return new Artist(artist);
        }

        private Artist(MsArtist artist)
        {
            this.artist = artist;
        }

        /// <summary>
        /// Immediately releases the unmanaged resources used by this object.
        /// </summary>
        public void Dispose()
        {
            this.artist.Dispose();
        }

        /// <summary>
        /// Returns a String representation of the Artist.
        /// </summary>
        public override string ToString()
        {
            return this.artist.ToString();
        }

        /// <summary>
        /// Gets the hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            return this.artist.GetHashCode();
        }
#endif
    }
}
