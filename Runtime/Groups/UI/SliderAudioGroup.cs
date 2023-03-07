#if UNITY_UI
using UnityEngine;
using UnityEngine.UI;

namespace ActionCode.Audio
{
    /// <summary>
    /// UI Slider component controlling the <see cref="AudioGroup.Volume"/>.
    /// </summary>
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Slider))]
    public sealed class SliderAudioGroup : AbstractUIAudioGroup
    {
        [SerializeField, Tooltip("The local Slider controlling the Volume.")]
        private Slider slider;

        protected override void Reset()
        {
            base.Reset();
            slider = GetComponent<Slider>();
        }

        private void OnEnable()
        {
            slider.onValueChanged.AddListener(HandleValueChanged);
            audioGroup.OnInteractableChanged += HandleInteractableChanged;
        }

        private void OnDisable()
        {
            slider.onValueChanged.RemoveListener(HandleValueChanged);
            audioGroup.OnInteractableChanged -= HandleInteractableChanged;
        }

        protected override void SetInitialValue() =>
            slider.SetValueWithoutNotify(audioGroup.Volume);

        private void HandleValueChanged(float volume) => audioGroup.Volume = volume;

        private void HandleInteractableChanged(bool interactable)
        {
            slider.interactable = interactable;
            slider.SetValueWithoutNotify(audioGroup.Volume);
        }
    }
}
#endif