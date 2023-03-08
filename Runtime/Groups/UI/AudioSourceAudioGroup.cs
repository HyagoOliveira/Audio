using UnityEngine;

namespace ActionCode.Audio
{
    /// <summary>
    /// Plays an <see cref="AudioSource"/> when the <see cref="AudioGroupSettings.Volume"/> changes.
    /// </summary>
    [DisallowMultipleComponent]
    [RequireComponent(typeof(AudioSource))]
    public sealed class AudioSourceAudioGroup : AbstractUIAudioGroup
    {
        [SerializeField] private AudioSource audioSource;

        private void Reset()
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.SetSpatialBlendTo2D();
        }

        private void OnEnable() => settings.OnVolumeChanged += HandleVolumeChanged;
        private void OnDisable() => settings.OnVolumeChanged -= HandleVolumeChanged;

        protected override void SetInitialValue() { }

        private void HandleVolumeChanged()
        {
            var canPlay = settings.HasVolume() && !audioSource.isPlaying;
            if (canPlay) audioSource.Play();
        }
    }
}