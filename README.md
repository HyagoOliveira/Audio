# Audio

### What is this package for? ###

* This package contains scripts for Audio components and presets for Unity projects
* Current Version: 1.0.0
* Unity version: 2017.1

### What can I do with it? ###
* **AudibleParticleSystem**: component used to play, stop, pause and resume both **AudioSource** and **ParticleSystem** components attached to the **GameObject**.
* **AudioSourceDictionary**: plays audio clips shots using an **AudioSource** component and an **AudioClip** array.
* **Presets**: presets assets for **background** music, **frequently** and **rarely** played audio clips.

### How do I get set up? ###
* You can download this repo and place it inside your Unity project (the simplest way).
* Using **Unity Package Manager**:
	* Open the **manifest.json** file inside your Unity project's **Packages** folder;
	* For *versions 2018.3* or above, there are two options:
		* Using the **Package Registry Server**:
			* Add this line before *"dependencies"* node:
				* ```"scopedRegistries": [ { "name": "Action Code", "url": "http://34.83.179.179:4873/", "scopes": [ "com.actioncode" ] } ],```
			* The package **ActionCode-Audio** will be avaliable for you to intall using the **Package Manager** windows.
		* By **Git URL** (you'll need a **Git client** installed on your machine):
			* Add this line inside *"dependencies"* node: 
				* ```"com.actioncode.audio":"https://bitbucket.org/nostgameteam/audio.git"```

	* For *versions 2017.2* or below: 
		* Clone/download this repo in any folder on your machine;
		* Add this line inside *"dependencies"* node: 
			* ```"com.actioncode.audio": "[the-folder-path-you-download-it]"```

### Who do I talk to? ###

* Repo owner and admin: **Hyago Oliveira** (hyagogow@gmail.com)