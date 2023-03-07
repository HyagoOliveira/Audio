using System;
using UnityEditor;
using UnityEngine.Audio;

namespace ActionCode.Audio.Editor
{
    /// <summary>
    /// Editor for <see cref="AudioGroup"/>.
    /// <para>
    /// If possible, draws <see cref="AudioGroup.volumeParamName"/> as a Popup field.
    /// </para>
    /// </summary>
    [CustomEditor(typeof(AudioGroup))]
    public sealed class AudioGroupEditor : UnityEditor.Editor
    {
        private AudioGroup audioGroup;

        private string volumeParamName;
        private string[] mixerExposedParamNames;
        private SerializedProperty volumeParamProperty;

        private void OnEnable()
        {
            audioGroup = target as AudioGroup;

            LoadExposedParamNamesFromMixer();

            volumeParamName = nameof(audioGroup.volumeParamName);
            volumeParamProperty = serializedObject.FindProperty(volumeParamName);
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            EditorGUI.BeginChangeCheck();
            DrawPropertiesExcluding(serializedObject, volumeParamName);
            var hasAnyChanges = EditorGUI.EndChangeCheck();

            if (hasAnyChanges)
            {
                serializedObject.ApplyModifiedProperties();
                LoadExposedParamNamesFromMixer();
            }

            TryDrawVolumeParamPropertyAsPopup();

            serializedObject.ApplyModifiedProperties();
        }

        private void TryDrawVolumeParamPropertyAsPopup()
        {
            var hasInvalidMixer = audioGroup.Mixer == null;
            if (hasInvalidMixer)
            {
                DrawVolumeParamPropertyAsString();
                return;
            }
            else if (mixerExposedParamNames == null)
                LoadExposedParamNamesFromMixer();

            if (mixerExposedParamNames.Length > 0)
                DrawVolumeParamPropertyAsPopup();
            else DrawVolumeParamPropertyAsString();
        }

        private void DrawVolumeParamPropertyAsPopup()
        {
            var selectedIndex = 0;
            var value = volumeParamProperty.stringValue;

            for (int i = 0; i < mixerExposedParamNames.Length; i++)
            {
                if (mixerExposedParamNames[i].Equals(value))
                {
                    selectedIndex = i;
                    break;
                }
            }

            selectedIndex = EditorGUILayout.Popup(
                volumeParamProperty.displayName,
                selectedIndex,
                mixerExposedParamNames
            );

            volumeParamProperty.stringValue = mixerExposedParamNames[selectedIndex];
        }

        private void DrawVolumeParamPropertyAsString() =>
            EditorGUILayout.PropertyField(volumeParamProperty);

        private void LoadExposedParamNamesFromMixer() =>
            mixerExposedParamNames = GetExposedParametersNames(audioGroup.Mixer);

        private static string[] GetExposedParametersNames(AudioMixer mixer)
        {
            const string propertyName = "exposedParameters";
            const string nameFieldPropertyName = "name";

            if (mixer == null) return Array.Empty<string>();

            var mixerExposedParameters = mixer.GetType().GetProperty(propertyName).GetValue(mixer) as Array;
            string[] parameters = new string[mixerExposedParameters.Length];

            for (int i = 0; i < mixerExposedParameters.Length; i++)
            {
                var parameter = mixerExposedParameters.GetValue(i);
                var name = parameter.GetType().GetField(nameFieldPropertyName).GetValue(parameter) as string;

                parameters[i] = name;
            }

            return parameters;
        }
    }
}