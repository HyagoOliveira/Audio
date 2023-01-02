using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

namespace ActionCode.Audio
{
    /// <summary>
    /// Component for Audio Groups.
    /// </summary>
    public sealed class AudioGroup : MonoBehaviour
    {
        [SerializeField, Tooltip("Your game AudioMixer asset.")]
        private AudioMixer mixer;
        [SerializeField, Tooltip("The Volume Exposed Parameter name inside the AudioMixer asset.")]
        private string volumeParamName;

        [Header("UI Components")]
        [SerializeField, Tooltip("The local Toggle component.")]
        private Toggle toggle;
        [SerializeField, Tooltip("The local Slider controlling the Volume.")]
        private Slider slider;
        [SerializeField, Tooltip("The local Text component updated with Slider.")]
        private TMP_Text sliderValue;

        /// <summary>
        /// The Volume in linear range (0F -> 1F).
        /// </summary>
        public float Volume
        {
            get
            {
                var hasVolume = mixer.GetFloat(volumeParamName, out float volume);
                return hasVolume ? DecibelToLinear(volume) : 0F;
            }
            set
            {
                mixer.SetFloat(volumeParamName, LinearToDecibel(value));
                slider.SetValueWithoutNotify(value);

                var displayedText = (int)(value * 10);
                sliderValue.text = displayedText.ToString("D2");
            }
        }

        private const float maxValumeDB = 20F;
        private const float minValumeDB = -80F;

        private void Reset()
        {
            toggle = GetComponentInChildren<Toggle>();
            slider = GetComponentInChildren<Slider>();
            sliderValue = slider.transform.parent.GetComponentInChildren<TMP_Text>();
        }

        private void OnEnable()
        {
            toggle.onValueChanged.AddListener(HandleToggleValueChanged);
            slider.onValueChanged.AddListener(HandleSliderValueChanged);
        }

        private void OnDisable()
        {
            toggle.onValueChanged.RemoveListener(HandleToggleValueChanged);
            slider.onValueChanged.RemoveListener(HandleSliderValueChanged);
        }

        private void EnableVolume()
        {
            Volume = 1F;
            slider.interactable = true;
        }

        public void DisableVolume()
        {
            Volume = 0F;
            slider.interactable = false;
        }

        private void HandleToggleValueChanged(bool enabled)
        {
            if (enabled) EnableVolume();
            else DisableVolume();
        }

        private void HandleSliderValueChanged(float value) => Volume = value;

        private static float DecibelToLinear(float value) => Mathf.Pow(10F, value / maxValumeDB);

        private static float LinearToDecibel(float value) => value > 0F ?
            Mathf.Log10(value) * maxValumeDB :
            minValumeDB;
    }
}