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
        [Range(0, maxVolume)] public uint backgroundVolume;
        [Range(0, maxVolume)] public uint soundEffectsVolume;
        [Range(0, maxVolume)] public uint ambientEffectsVolume;
        [Range(0, maxVolume)] public uint voiceEffectsVolume;
        [Range(0, maxVolume)] public uint gamepadVolume;

        private const uint maxVolume = 100;

        /// <summary>
        /// Creates an Audio Data using the given volume for all.
        /// </summary>
        /// <param name="volume">The volume amount.</param>
        public AudioData(uint volume = maxVolume) :
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
            uint backgroundVolume,
            uint soundEffectsVolume,
            uint ambientEffectsVolume,
            uint voiceEffectsVolume,
            uint gamepadVolume
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