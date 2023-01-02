using System;

namespace ActionCode.Audio
{
    /// <summary>
    /// Data class for <see cref="AudioManager"/>.
    /// </summary>
    [Serializable]
    public sealed class AudioManagerData
    {
        public float backgroundValume = 1F;
        public float soundEffectsValume = 1F;
        public float ambientEffectsValume = 1F;
    }
}