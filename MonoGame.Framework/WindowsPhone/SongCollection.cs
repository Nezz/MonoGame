#if WINDOWS_PHONE
extern alias MicrosoftXnaFramework;
using MsSongCollection = MicrosoftXnaFramework::Microsoft.Xna.Framework.Media.SongCollection;
#endif
using System;
using System.Collections;

namespace Microsoft.Xna.Framework.Media
{
    public class SongCollection : IDisposable, IEnumerable
    {
        private MsSongCollection songCollection;

        /// <summary>
        /// Gets the number of Song objects in the SongCollection.
        /// </summary>
        public int Count
        {
            get
            {
                return this.songCollection.Count;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the object is disposed.
        /// </summary>
        public bool IsDisposed
        {
            get
            {
                return this.songCollection.IsDisposed;
            }
        }

        public static implicit operator SongCollection(MsSongCollection songCollection)
        {
            return new SongCollection(songCollection);
        }

        private SongCollection(MsSongCollection songCollection)
        {
            this.songCollection = songCollection;
        }

        /// <summary>
        /// Gets the Song at the specified index in the SongCollection.
        /// </summary>
        /// <param name="index"/>
        public Song this[int index]
        {
            get
            {
                return this.songCollection[index];
            }
        }

        /// <summary>
        /// Immediately releases the unmanaged resources used by this object.
        /// </summary>
        public void Dispose()
        {
            this.songCollection.Dispose();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.songCollection.GetEnumerator();
        }
    }
}
