using UnityEngine;

namespace ActionCode.Audio
{
    /// <summary>
    /// Manager for Audio.
    /// </summary>
    [DisallowMultipleComponent]
    public sealed class AudioManager : MonoBehaviour
    {
        [Header("Groups")]
        [SerializeField, Tooltip("The Background Group inside the AudioMixer asset.")]
        private AudioGroup backgroundGroup;
        [SerializeField, Tooltip("The Sound Effects Group inside the AudioMixer asset.")]
        private AudioGroup soundEffectsGroup;
        [SerializeField, Tooltip("The Ambient Effects Group inside the AudioMixer asset.")]
        private AudioGroup ambiemtEffectsGroup;

        private void Awake() => Load(new AudioManagerData());

        /// <summary>
        /// Loads all groups using the given data.
        /// </summary>
        /// <param name="data">The audio data to load.</param>
        public void Load(AudioManagerData data)
        {
            if (backgroundGroup) backgroundGroup.Volume = data.backgroundValume;
            if (soundEffectsGroup) soundEffectsGroup.Volume = data.soundEffectsValume;
            if (ambiemtEffectsGroup) ambiemtEffectsGroup.Volume = data.ambientEffectsValume;
        }

        /// <summary>
        /// Saves all groups into the given data.
        /// </summary>
        /// <param name="data">The audio data to save.</param>
        public void Save(ref AudioManagerData data)
        {
            if (backgroundGroup) data.backgroundValume = backgroundGroup.Volume;
            if (soundEffectsGroup) data.soundEffectsValume = soundEffectsGroup.Volume;
            if (ambiemtEffectsGroup) data.ambientEffectsValume = ambiemtEffectsGroup.Volume;
        }
    }
}