# Changelog
All notable changes to this package will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Added
- VoiceEffects into DefaultAudioMixer
- OnVolumeChanged and OnInteractableChanged into AudioGroup
- SliderAudioGroup component
- TextMeshProAudioGroup component
- ToggleAudioGroup component

### Changed
- Remove DisallowMultipleComponent attribute from AudioSourceDictionary
- Remove UI Components from AudioGroup
- If possible, draws AudioGroup.volumeParamName as a Popup field

### Removed
- Text Mesh Pro package dependency

## [2.0.0] - 2023-01-24

### Changed
- AudioSourceDictionary uses AudioDictionary class.

### Added
- DefaultAudioMixer
- Dependency to TextMeshPro package
- AudioManagerData
- AudioManager
- AudioDictionary class

## [1.1.0] - 2020-02-16
### Added
- Add option to enable other behaviours on AudiableParticleSystem
- Add CHANGELOG
- Add LICENSE

## [1.0.0] - 2020-01-19
### Added
- Release initial version
- Add README
- Add initial files
- Initial commit

[Unreleased]: https://github.com/HyagoOliveira/Audio/compare/2.0.0...main
[2.0.0]: https://github.com/HyagoOliveira/Audio/tree/2.0.0/
[1.1.0]: https://github.com/HyagoOliveira/Audio/tree/1.1.0/
[1.0.0]: https://github.com/HyagoOliveira/Audio/tree/1.0.0/