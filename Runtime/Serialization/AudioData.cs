using System;
using UnityEngine;

namespace ActionCode.Audio
{
    /// <summary>
    /// Data class for Audio.
    /// </summary>
    [Serializable]
    public sealed class AudioData
    {
        [Range(0f, 1f)] public float backgroundVolume;
        [Range(0f, 1f)] public float soundEffectsVolume;
        [Range(0f, 1f)] public float ambientEffectsVolume;
        [Range(0f, 1f)] public float voiceEffectsVolume;
        [Range(0f, 1f)] public float gamepadVolume;

        /// <summary>
        /// Creates an Audio Data with all volumes set to 1F.
        /// </summary>
        public AudioData() : this(1F) { }

        /// <summary>
        /// Creates an Audio Data using the given volume for all.
        /// </summary>
        /// <param name="volume">The volume amount.</param>
        public AudioData(float volume) :
            this(volume, volume, volume, volume, volume)
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
            float voiceEffectsVolume,
            float gamepadVolume
        )
        {
            this.backgroundVolume = backgroundVolume;
            this.soundEffectsVolume = soundEffectsVolume;
            this.ambientEffectsVolume = ambientEffectsVolume;
            this.voiceEffectsVolume = voiceEffectsVolume;
            this.gamepadVolume = gamepadVolume;
        }
    }
}