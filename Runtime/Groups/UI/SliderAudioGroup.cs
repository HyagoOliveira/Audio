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
        private void OnEnable() => slider.onValueChanged.AddListener(HandleValueChanged);
        private void OnDisable() => slider.onValueChanged.RemoveListener(HandleValueChanged);

        protected override void SetInitialValue() => slider.SetValueWithoutNotify(settings.Volume);

        private void HandleValueChanged(float volume) => settings.Volume = volume;
    }
}
#endif