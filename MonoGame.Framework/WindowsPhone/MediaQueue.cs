#if WINDOWS_PHONE
extern alias MicrosoftXnaFramework;
using MsMediaQueue = MicrosoftXnaFramework::Microsoft.Xna.Framework.Media.MediaQueue;
#endif

namespace Microsoft.Xna.Framework.Media
{
    /// <summary>
    /// Provides methods and properties to access and control the queue of playing songs.
    /// </summary>
    public sealed class MediaQueue
    {
        private MsMediaQueue mediaQueue;

        /// <summary>
        /// Gets the current Song in the queue of playing songs.
        /// </summary>
        public Song ActiveSong
        {
            get
            {
                return mediaQueue.ActiveSong;
            }
        }

        /// <summary>
        /// Gets or sets the index of the current (active) song in the queue of playing songs.
        /// </summary>
        public int ActiveSongIndex
        {
            get
            {
                return mediaQueue.ActiveSongIndex;
            }
            set
            {
                mediaQueue.ActiveSongIndex = value;
            }
        }

        /// <summary>
        /// Gets the count of songs in the MediaQueue.
        /// </summary>
        public int Count
        {
            get
            {
                return mediaQueue.Count;
            }
        }

        /// <summary>
        /// Gets the Song at the specified index in the MediaQueue.
        /// </summary>
        /// <param name="index"/>
        public Song this[int index]
        {
            get
            {
                return mediaQueue[index];
            }
        }

        public static implicit operator MediaQueue(MsMediaQueue mediaQueue)
        {
            return new MediaQueue(mediaQueue);
        }

        private MediaQueue(MsMediaQueue mediaQueue)
        {
            this.mediaQueue = mediaQueue;
        }
    }
}

