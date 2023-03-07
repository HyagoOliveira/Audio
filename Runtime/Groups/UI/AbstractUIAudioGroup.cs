using UnityEngine;

namespace ActionCode.Audio
{
    /// <summary>
    /// Abstract UI component for <see cref="AudioGroup"/>.
    /// </summary>
    public abstract class AbstractUIAudioGroup : MonoBehaviour
    {
        [SerializeField, Tooltip("The parent AudioGroup component.")]
        protected AudioGroup audioGroup;

        protected virtual void Reset() => audioGroup = GetComponentInParent<AudioGroup>();
        protected virtual void Start() => SetInitialValue();

        protected abstract void SetInitialValue();
    }
}