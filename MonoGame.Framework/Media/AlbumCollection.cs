#if WINDOWS_PHONE
extern alias MicrosoftXnaFramework;
using MsAlbumCollection = MicrosoftXnaFramework::Microsoft.Xna.Framework.Media.AlbumCollection;
#endif
using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Xna.Framework.Media
{
    public sealed class AlbumCollection : IDisposable
    {
#if WINDOWS_PHONE
        private MsAlbumCollection albumCollection;

        /// <summary>
        /// Gets the number of Album objects in the AlbumCollection.
        /// </summary>
        public int Count
        {
            get
            {
                return this.albumCollection.Count;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the object is disposed.
        /// </summary>
        public bool IsDisposed
        {
            get
            {
                return this.albumCollection.IsDisposed;
            }
        }

        public static implicit operator AlbumCollection(MsAlbumCollection albumCollection)
        {
            return new AlbumCollection(albumCollection);
        }

        private AlbumCollection(MsAlbumCollection albumCollection)
        {
            this.albumCollection = albumCollection;
        }

        /// <summary>
        /// Gets the Album at the specified index in the AlbumCollection.
        /// </summary>
        /// <param name="index">Index of the Album to get.</param>
        public Album this[int index]
        {
            get
            {
                return (Album)this.albumCollection[index];
            }
        }

        /// <summary>
        /// Immediately releases the unmanaged resources used by this object.
        /// </summary>
        public void Dispose()
        {
            this.albumCollection.Dispose();
        }
#endif
    }
}
