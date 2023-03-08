using UnityEngine;

namespace ActionCode.Audio
{
    /// <summary>
    /// Plays an <see cref="AudioSource"/> when the <see cref="AudioGroup.Volume"/> changes.
    /// </summary>
    [DisallowMultipleComponent]
    [RequireComponent(typeof(AudioSource))]
    public sealed class AudioSourceAudioGroup : AbstractUIAudioGroup
    {
        [SerializeField] private AudioSource audioSource;

        protected override void Reset()
        {
            base.Reset();
            audioSource = GetComponent<AudioSource>();
            audioSource.SetSpatialBlendTo2D();
        }

        private void OnEnable() => audioGroup.OnVolumeChanged += HandleVolumeChanged;
        private void OnDisable() => audioGroup.OnVolumeChanged -= HandleVolumeChanged;

        protected override void SetInitialValue() { }

        private void HandleVolumeChanged(float volume)
        {
            var hasVolume = !Mathf.Approximately(volume, 0f);
            var canPlay = hasVolume && !audioSource.isPlaying;
            if (canPlay) audioSource.Play();
        }
    }
}