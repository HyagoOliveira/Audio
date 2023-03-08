using UnityEngine;

namespace ActionCode.Audio
{
    /// <summary>
    /// Scriptable Settings for Audio.
    /// </summary>
    [CreateAssetMenu(fileName = "AudioSettings", menuName = "ActionCode/Audio/Settings", order = 110)]
    public sealed class AudioSettings : ScriptableObject
    {
        [Header("Groups")]
        [SerializeField, Tooltip("The Background Audio Group.")]
        private AudioGroupSettings backgroundGroup;
        [SerializeField, Tooltip("The Sound Effects Audio Group.")]
        private AudioGroupSettings soundEffectsGroup;
        [SerializeField, Tooltip("The Voice Effects Audio Group.")]
        private AudioGroupSettings voiceEffectsGroup;
        [SerializeField, Tooltip("The Ambient Effects Audio Group.")]
        private AudioGroupSettings ambientEffectsGroup;

        /// <summary>
        /// Loads all groups using the given data.
        /// </summary>
        /// <param name="data">The audio data to load.</param>
        public void Load(AudioData data)
        {
            if (backgroundGroup) backgroundGroup.Volume = data.BackgroundVolume;
            if (soundEffectsGroup) soundEffectsGroup.Volume = data.SoundEffectsVolume;
            if (voiceEffectsGroup) voiceEffectsGroup.Volume = data.AmbientEffectsVolume;
            if (ambientEffectsGroup) ambientEffectsGroup.Volume = data.AmbientEffectsVolume;
        }

        /// <summary>
        /// Saves all groups into the given data.
        /// </summary>
        /// <param name="data">The audio data to save.</param>
        public void Save(ref AudioData data)
        {
            if (backgroundGroup) data.BackgroundVolume = backgroundGroup.Volume;
            if (soundEffectsGroup) data.SoundEffectsVolume = soundEffectsGroup.Volume;
            if (voiceEffectsGroup) data.VoiceEffectsVolume = voiceEffectsGroup.Volume;
            if (ambientEffectsGroup) data.AmbientEffectsVolume = ambientEffectsGroup.Volume;
        }

        /// <summary>
        /// Resets all volumes.
        /// </summary>
        public void ResetVolumes()
        {
            backgroundGroup?.ResetVolume();
            soundEffectsGroup?.ResetVolume();
            voiceEffectsGroup?.ResetVolume();
            ambientEffectsGroup?.ResetVolume();
        }
    }
}