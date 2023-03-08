using System;
using UnityEngine;
using UnityEngine.Audio;

namespace ActionCode.Audio
{
    /// <summary>
    /// Scriptable Settings for an Audio Group.
    /// </summary>
    [CreateAssetMenu(fileName = "AudioGroupSettings", menuName = "ActionCode/Audio/Group Settings", order = 110)]
    public sealed class AudioGroupSettings : ScriptableObject
    {
        [SerializeField, Tooltip("The AudioMixer asset used on your game.")]
        private AudioMixer mixer;
        [Tooltip("The Volume Exposed Parameter name inside the above AudioMixer.")]
        public string volumeParamName;

        /// <summary>
        /// Event fired every time the volume changes. 
        /// <para>Use <see cref="Volume"/> to check the current volume.</para>
        /// </summary>
        public event Action OnVolumeChanged;

        /// <summary>
        /// Your game AudioMixer asset.
        /// </summary>
        public AudioMixer Mixer => mixer;

        /// <summary>
        /// The Volume in linear range (0F -> 1F).
        /// </summary>
        public float Volume
        {
            get
            {
                var hasVolumeParam = mixer.GetFloat(volumeParamName, out float volume);
                return hasVolumeParam ? DecibelToLinear(volume) : 0F;
            }
            set
            {
                mixer.SetFloat(volumeParamName, LinearToDecibel(value));
                OnVolumeChanged?.Invoke();
            }
        }

        private const float maxVolumeDB = 20F;
        private const float minVolumeDB = -80F;

        /// <summary>
        /// Checks if the Audio Group has Volume.
        /// </summary>
        /// <returns>Whether the Audio Group has Volume.</returns>
        public bool HasVolume() => !Mathf.Approximately(Volume, 0f);

        private static float DecibelToLinear(float value) => Mathf.Pow(10F, value / maxVolumeDB);

        private static float LinearToDecibel(float value)
        {
            var hasValue = value > 0F;
            return hasValue ?
                Mathf.Log10(value) * maxVolumeDB :
                minVolumeDB;
        }
    }
}