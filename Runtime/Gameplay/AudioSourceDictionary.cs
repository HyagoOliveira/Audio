using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Plays audio clips shots using an Audio Source component and an AudioClip array.
/// </summary>
namespace ActionCode.Audio
{
	[DisallowMultipleComponent]
    [RequireComponent(typeof(AudioSource))]
    public class AudioSourceDictionary : MonoBehaviour 
	{
        [SerializeField, Tooltip("The AudioSource component used to play audio shots.")]
        protected AudioSource audioSource;
        [SerializeField, Tooltip("The AudioClips. You can play them using theirs names.")]
        protected AudioClip[] clips;

        private Dictionary<string, AudioClip> audioDictionary;

        private void Reset()
        {
            audioSource = GetComponent<AudioSource>();
        }

        private void Awake () 
		{
            InitializeDictionary();
		}

        /// <summary>
        /// Plays an audio clip selected by the given index.
        /// </summary>
        /// <param name="index">The index of audio clip. No checking is done on this index.</param>
        public void Play(int index)
        {
            audioSource.PlayOneShot(clips[index]);
        }

        /// <summary>
        /// Plays an audio clip selected by the given name.
        /// </summary>
        /// <param name="name">The name of audio clip. No checking is done on this name.</param>
        public void Play(string name)
        {
            audioSource.PlayOneShot(GetClip(name));
        }

        /// <summary>
        /// Plays a random audio clip.
        /// </summary>
        public void PlayRandom()
        {
            audioSource.PlayOneShot(GetRandomClip());
        }
        
        /// <summary>
        /// Stops the Audio Source.
        /// </summary>
        public void Stop()
        {
            audioSource.Stop();
        }

        /// <summary>
        /// Pauses the Audio Source.
        /// </summary>
        public void Pause()
        {
            audioSource.Pause();
        }

        /// <summary>
        /// Plays the audio source if it is not.
        /// </summary>
        public void Resume()
        {
            if (!audioSource.isPlaying) audioSource.Play();
        }

        /// <summary>
        /// Gets a random clip from <see cref="clips"/>.
        /// </summary>
        /// <returns>A random Audio Clip.</returns>
        public AudioClip GetRandomClip()
        {
            int randomIndex = Random.Range(0, clips.Length);
            return clips[randomIndex];
        }

        /// <summary>
        /// Gets a audio clip by the given name.
        /// </summary>
        /// <param name="name">The name of audio clip. No checking is done on this name.</param>
        /// <returns>An AudioClip instance.</returns>
        public AudioClip GetClip(string name)
        {
            return audioDictionary[name];
        }

        private void InitializeDictionary()
        {
            audioDictionary = new Dictionary<string, AudioClip>();
            foreach (AudioClip clip in clips)
            {
                audioDictionary.Add(clip.name, clip);
            }
        }
    }
}