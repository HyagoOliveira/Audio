#if TEXT_MESH_PRO
using TMPro;
using UnityEngine;

namespace ActionCode.Audio
{
    /// <summary>
    /// UI Text Mesh Pro component showing the <see cref="AudioGroup.Volume"/>.
    /// </summary>
    [DisallowMultipleComponent]
    [RequireComponent(typeof(TMP_Text))]
    public sealed class TextMeshProAudioGroup : AbstractUIAudioGroup
    {
        [SerializeField, Tooltip("The local Text Mesh Pro showing the Volume.")]
        private TMP_Text text;
        [SerializeField, Min(0), Tooltip("The multiplier used on the volume before showing it.")]
        private int multiplier = 100;
        [SerializeField, Tooltip("The format used on the volume before showing it. Volume is an Interger value.")]
        private string format = "D2";

        protected override void Reset()
        {
            base.Reset();
            text = GetComponent<TMP_Text>();
        }

        private void OnEnable() => audioGroup.OnVolumeChanged += HandleVolumeChanged;
        private void OnDisable() => audioGroup.OnVolumeChanged -= HandleVolumeChanged;

        protected override void SetInitialValue() => SetText(audioGroup.Volume);

        private void HandleVolumeChanged(float volume) => SetText(volume);

        private void SetText(float volume)
        {
            var integerVolume = (int)(volume * multiplier);
            text.text = integerVolume.ToString(format);
        }
    }
}
#endif