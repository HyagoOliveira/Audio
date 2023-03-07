#if UNITY_UI
using UnityEngine;
using UnityEngine.UI;

namespace ActionCode.Audio
{
    /// <summary>
    /// UI Toggle component controlling the <see cref="AudioGroup.Interactable"/>.
    /// </summary>
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Toggle))]
    public sealed class ToggleAudioGroup : AbstractUIAudioGroup
    {
        [SerializeField, Tooltip("The local Toggle controlling the Volume.")]
        private Toggle toggle;

        protected override void Reset()
        {
            base.Reset();
            toggle = GetComponent<Toggle>();
        }

        private void OnEnable() => toggle.onValueChanged.AddListener(HandleValueChanged);
        private void OnDisable() => toggle.onValueChanged.RemoveListener(HandleValueChanged);

        private void HandleValueChanged(bool enabled) => audioGroup.Interactable = enabled;
    }
}
#endif