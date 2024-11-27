#if UNITY_UI
using UnityEngine;
using UnityEngine.UI;

namespace ActionCode.Audio
{
    /// <summary>
    /// UI Slider component controlling the <see cref="AudioGroupSettings.Volume"/>.
    /// </summary>
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Slider))]
    public sealed class SliderAudioGroup : AbstractUIAudioGroup
    {
        [SerializeField, Tooltip("The local Slider controlling the Volume.")]
        private Slider slider;

        private void Reset() => slider = GetComponent<Slider>();

        private void OnEnable()
        {
            settings.OnVolumeChanged += HandleVolumeChanged;
            slider.onValueChanged.AddListener(HandleValueChanged);
        }

        private void OnDisable()
        {
            settings.OnVolumeChanged -= HandleVolumeChanged;
            slider.onValueChanged.RemoveListener(HandleValueChanged);
        }

        protected override void SetInitialValue() => SetSliderToVolume();

        private void HandleVolumeChanged() => SetSliderToVolume();
        private void HandleValueChanged(float volume) => settings.Volume = (uint)volume;

        private void SetSliderToVolume() => slider.SetValueWithoutNotify(settings.Volume);
    }
}
#endif