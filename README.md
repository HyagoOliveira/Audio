# Audio

### What is this package for? ###

* This package contains scripts for Audio components and presets for Unity projects
* Minimal Unity version: 2018.3

### What can I do with it? ###
* **AudibleParticleSystem**: component used to play, stop, pause and resume both **AudioSource** and **ParticleSystem** components attached to the **GameObject**.
* **AudioSourceDictionary**: plays audio clips shots using an **AudioSource** component and an **AudioClip** array.
* **Presets**: presets assets for **background** music, **frequently** and **rarely** played audio clips.

### How do I get set up? ###
* Using the **Package Registry Server**:
	* Add this line before ```dependencies``` node:
		* ```"scopedRegistries": [ { "name": "Action Code", "url": "http://34.83.179.179:4873/", "scopes": [ "com.actioncode" ] } ],```
	* The package **ActionCode-Audio** will be avaliable for you to intall using the **Package Manager** windows.
* By **Git URL** (you'll need a **Git client** installed on your machine):
	* Add this line inside ```dependencies``` node: 
		* ```"com.actioncode.audio":"https://bitbucket.org/nostgameteam/audio.git"```

### Who do I talk to? ###

* Repo owner and admin: **Hyago Oliveira** (hyagogow@gmail.com)