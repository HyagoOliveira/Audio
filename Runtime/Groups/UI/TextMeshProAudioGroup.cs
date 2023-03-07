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

        protected override void Reset()
        {
            base.Reset();
            text = GetComponent<TMP_Text>();
        }

        private void OnEnable() => audioGroup.OnVolumeChanged += HandleVolumeChanged;
        private void OnDisable() => audioGroup.OnVolumeChanged -= HandleVolumeChanged;

        private void HandleVolumeChanged(float volume)
        {
            var integerVolume = (int)(volume * 10);
            text.text = integerVolume.ToString("D2");
        }
    }
}
#endif