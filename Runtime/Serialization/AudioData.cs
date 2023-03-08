using System;

namespace ActionCode.Audio
{
    /// <summary>
    /// Data class for <see cref="AudioManager"/>.
    /// </summary>
    [Serializable]
    public sealed class AudioData
    {
        public float BackgroundVolume { get; set; }
        public float SoundEffectsVolume { get; set; }
        public float AmbientEffectsVolume { get; set; }
        public float VoiceEffectsVolume { get; set; }

        /// <summary>
        /// Creates an Audio Data with all volumes set to 1F.
        /// </summary>
        public AudioData() : this(1F) { }

        /// <summary>
        /// Creates an Audio Data using the given volume for all.
        /// </summary>
        /// <param name="volume">The volume amount.</param>
        public AudioData(float volume) :
            this(volume, volume, volume, volume)
        { }

        /// <summary>
        /// Creates an Audio Data using the given volumes.
        /// </summary>
        /// <param name="backgroundVolume">The background volume amount.</param>
        /// <param name="soundEffectsVolume">The sound effects volume amount.</param>
        /// <param name="ambientEffectsVolume">The ambient effects volume amount.</param>
        /// <param name="voiceEffectsVolume">The voice effects volume amount.</param>
        public AudioData(
            float backgroundVolume,
            float soundEffectsVolume,
            float ambientEffectsVolume,
            float voiceEffectsVolume
        )
        {
            BackgroundVolume = backgroundVolume;
            SoundEffectsVolume = soundEffectsVolume;
            AmbientEffectsVolume = ambientEffectsVolume;
            VoiceEffectsVolume = voiceEffectsVolume;
        }
    }
}