using UnityEngine;

namespace ActionCode.Audio
{
    /// <summary>
    /// Manager for <see cref="AudioGroup"/> components.
    /// </summary>
    [DisallowMultipleComponent]
    public sealed class AudioGroupManager : MonoBehaviour
    {
        [Header("Groups")]
        [SerializeField, Tooltip("The Background Group inside the AudioMixer asset.")]
        private AudioGroup backgroundGroup;
        [SerializeField, Tooltip("The Sound Effects Group inside the AudioMixer asset.")]
        private AudioGroup soundEffectsGroup;
        [SerializeField, Tooltip("The Ambient Effects Group inside the AudioMixer asset.")]
        private AudioGroup ambiemtEffectsGroup;
        [SerializeField, Tooltip("The Voice Effects Group inside the AudioMixer asset.")]
        private AudioGroup voiceEffectsGroup;

        private void Awake() => Load(new AudioData());

        /// <summary>
        /// Loads all groups using the given data.
        /// </summary>
        /// <param name="data">The audio data to load.</param>
        public void Load(AudioData data)
        {
            if (backgroundGroup) backgroundGroup.Volume = data.BackgroundVolume;
            if (soundEffectsGroup) soundEffectsGroup.Volume = data.SoundEffectsVolume;
            if (ambiemtEffectsGroup) ambiemtEffectsGroup.Volume = data.AmbientEffectsVolume;
            if (voiceEffectsGroup) voiceEffectsGroup.Volume = data.AmbientEffectsVolume;
        }

        /// <summary>
        /// Saves all groups into the given data.
        /// </summary>
        /// <param name="data">The audio data to save.</param>
        public void Save(ref AudioData data)
        {
            if (backgroundGroup) data.BackgroundVolume = backgroundGroup.Volume;
            if (soundEffectsGroup) data.SoundEffectsVolume = soundEffectsGroup.Volume;
            if (ambiemtEffectsGroup) data.AmbientEffectsVolume = ambiemtEffectsGroup.Volume;
            if (voiceEffectsGroup) data.VoiceEffectsVolume = voiceEffectsGroup.Volume;
        }
    }
}