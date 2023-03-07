using System;

namespace ActionCode.Audio
{
    /// <summary>
    /// Data class for <see cref="AudioManager"/>.
    /// </summary>
    [Serializable]
    public sealed class AudioData
    {
        public float BackgroundVolume { get; set; } = 1F;
        public float SoundEffectsVolume { get; set; } = 1F;
        public float AmbientEffectsVolume { get; set; } = 1F;
        public float VoiceEffectsVolume { get; set; } = 1F;
    }
}