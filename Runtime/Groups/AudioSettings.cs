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
            backgroundGroup.Volume = data.BackgroundVolume;
            soundEffectsGroup.Volume = data.SoundEffectsVolume;
            voiceEffectsGroup.Volume = data.AmbientEffectsVolume;
            ambientEffectsGroup.Volume = data.AmbientEffectsVolume;
        }

        /// <summary>
        /// Writes all groups into the given data.
        /// </summary>
        /// <param name="data">The audio data to write in.</param>
        public void Write(ref AudioData data)
        {
            data.BackgroundVolume = backgroundGroup.Volume;
            data.SoundEffectsVolume = soundEffectsGroup.Volume;
            data.VoiceEffectsVolume = voiceEffectsGroup.Volume;
            data.AmbientEffectsVolume = ambientEffectsGroup.Volume;
        }

        /// <summary>
        /// Resets all volumes.
        /// </summary>
        public void ResetVolumes()
        {
            backgroundGroup.ResetVolume();
            soundEffectsGroup.ResetVolume();
            voiceEffectsGroup.ResetVolume();
            ambientEffectsGroup.ResetVolume();
        }
    }
}