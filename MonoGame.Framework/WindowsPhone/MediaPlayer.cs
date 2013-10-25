#if WINDOWS_PHONE
extern alias MicrosoftXnaFramework;
using MsMediaPlayer = MicrosoftXnaFramework::Microsoft.Xna.Framework.Media.MediaPlayer;
#endif

using System;

namespace Microsoft.Xna.Framework.Media
{
    /// <summary>
    /// Provides methods and properties to play, pause, resume, and stop songs. MediaPlayer also exposes shuffle, repeat, volume, play position, and visualization capabilities. Reference page contains links to related code samples.
    /// </summary>
    public static class MediaPlayer
    {
        /// <summary>
        /// Determines whether the game has control of the background music.
        /// </summary>
        public static bool GameHasControl
        {
            get
            {
                return MsMediaPlayer.GameHasControl;
            }
        }

        /// <summary>
        /// Gets or set the muted setting for the media player.
        /// </summary>
        public static bool IsMuted
        {
            get
            {
                return MsMediaPlayer.IsMuted;
            }
            set
            {
                MsMediaPlayer.IsMuted = value;
            }
        }

        /// <summary>
        /// Gets or sets the repeat setting for the media player.
        /// </summary>
        public static bool IsRepeating
        {
            get
            {
                return MsMediaPlayer.IsRepeating;
            }
            set
            {
                MsMediaPlayer.IsRepeating = value;
            }
        }

        /// <summary>
        /// Gets or sets the shuffle setting for the media player.
        /// </summary>
        public static bool IsShuffled
        {
            get
            {
                return MsMediaPlayer.IsShuffled;
            }
            set
            {
                MsMediaPlayer.IsShuffled = value;
            }
        }

        /// <summary>
        /// Gets or sets the visualization enabled setting for the media player.
        /// </summary>
        public static bool IsVisualizationEnabled
        {
            get
            {
                return MsMediaPlayer.IsVisualizationEnabled;
            }
            set
            {
                MsMediaPlayer.IsVisualizationEnabled = value;
            }
        }

        /// <summary>
        /// Gets the play position within the currently playing song.
        /// </summary>
        public static TimeSpan PlayPosition
        {
            get
            {
                return MsMediaPlayer.PlayPosition;
            }
        }

        /// <summary>
        /// Gets the media playback queue, MediaQueue.
        /// </summary>
        public static MediaQueue Queue
        {
            get
            {
                return MsMediaPlayer.Queue;
            }
        }

        /// <summary>
        /// Gets the media playback state, MediaState.
        /// </summary>
        public static MediaState State
        {
            get
            {
                switch (MsMediaPlayer.State)
                {
                    case MicrosoftXnaFramework::Microsoft.Xna.Framework.Media.MediaState.Paused:
                        return MediaState.Paused;
                    case MicrosoftXnaFramework::Microsoft.Xna.Framework.Media.MediaState.Playing:
                        return MediaState.Playing;
                    default:
                        return MediaState.Stopped;
                }
            }
        }

        /// <summary>
        /// Gets or sets the media player volume.
        /// </summary>
        public static float Volume
        {
            get
            {
                return MsMediaPlayer.Volume;
            }
            set
            {
                MsMediaPlayer.Volume = value;
            }
        }

        /// <summary>
        /// Raised when the active song changes due to active playback or due to explicit calls to the MoveNext or MovePrevious methods.
        /// </summary>
        /// <param name=""/>
        public static event EventHandler<EventArgs> ActiveSongChanged
        {
            add
            {
                MsMediaPlayer.ActiveSongChanged += value;
            }
            remove
            {
                MsMediaPlayer.ActiveSongChanged -= value;
            }
        }

        /// <summary>
        /// Raised when the media player play state changes.
        /// </summary>
        /// <param name=""/>
        public static event EventHandler<EventArgs> MediaStateChanged
        {
            add
            {
                MsMediaPlayer.MediaStateChanged += value;
            }
            remove
            {
                MsMediaPlayer.MediaStateChanged -= value;
            }
        }

        /// <summary>
        /// Plays a Song. Reference page contains links to related code samples.
        /// </summary>
        /// <param name="song">Song to play.</param>
        public static void Play(Song song)
        {
            MsMediaPlayer.Play(song.InternalSong);
        }

        /*
        /// <summary>
        /// Plays a SongCollection. Reference page contains links to related code samples.
        /// </summary>
        /// <param name="songs">SongCollection to play.</param>
        public static void Play(SongCollection songs)
        {
        }

        /// <summary>
        /// Plays a SongCollection, starting with the Song at the specified index. Reference page contains links to related code samples.
        /// </summary>
        /// <param name="songs">SongCollection to play.</param><param name="index">Index of the song in the collection at which playback should begin.</param>
        public static void Play(SongCollection songs, int index)
        {
        }
        */

        /// <summary>
        /// Pauses the currently playing song.
        /// </summary>
        public static void Pause()
        {
            MsMediaPlayer.Pause();
        }

        /// <summary>
        /// Resumes a paused song.
        /// </summary>
        public static void Resume()
        {
            MsMediaPlayer.Resume();
        }

        /// <summary>
        /// Stops playing a song.
        /// </summary>
        public static void Stop()
        {
            MsMediaPlayer.Stop();
        }

        /// <summary>
        /// Moves to the next song in the queue of playing songs.
        /// </summary>
        public static void MoveNext()
        {
            MsMediaPlayer.MoveNext();
        }

        /// <summary>
        /// Moves to the previous song in the queue of playing songs.
        /// </summary>
        public static void MovePrevious()
        {
            MsMediaPlayer.MovePrevious();
        }
    }
}

