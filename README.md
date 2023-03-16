# Audio

* Audio scripts and presets.
* Unity minimum version: **2018.3**
* Current version: **2.0.0**
* License: **MIT**

## How To Use

### Default Audio Mixer

You may use the [Audio Mixer](/Mixers/DefaultAudioMixer.mixer) provided by this package.

![Default Audio Mixer](/Docs~/DefaultAudioMixer.png "The Default Audio Mixer")

This Mixer contains a Main, Background, Sound Effects, Ambient Effects and Voice Effects groups; each one with its *Volume* property exposed.

### Presets

There are common Audio Clip presets presents on the [Presets](/Presets) folder. Use them on Audio Clips depending on how frequently they should play. 

### Other Components

* **AudibleParticleSystem**: component used to play, stop, pause and resume both **AudioSource** and **ParticleSystem** components attached to the **GameObject**.
* **AudioSourceDictionary**: plays audio clips shots using an **AudioSource** component and an **AudioClip** array.
* **Presets**: presets assets for **background** music, **frequently** and **rarely** played audio clips.

## Installation

### Using the Package Registry Server

Follow the instructions inside [here](https://cutt.ly/ukvj1c8) and the package **ActionCode-Audio** 
will be available for you to install using the **Package Manager** windows.

### Using the Git URL

You will need a **Git client** installed on your computer with the Path variable already set. 

- Use the **Package Manager** "Add package from git URL..." feature and paste this URL: `https://github.com/HyagoOliveira/Audio.git`

- You can also manually modify you `Packages/manifest.json` file and add this line inside `dependencies` attribute: 

```json
"com.actioncode.energy-system":"https://github.com/HyagoOliveira/Audio.git"
```

---

**Hyago Oliveira**

[GitHub](https://github.com/HyagoOliveira) -
[BitBucket](https://bitbucket.org/HyagoGow/) -
[LinkedIn](https://www.linkedin.com/in/hyago-oliveira/) -
<hyagogow@gmail.com>