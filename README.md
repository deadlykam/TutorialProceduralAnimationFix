# TutorialProceduralAnimationFix

<p align="center"><img src="https://imgur.com/SdRIJck.png"></p>

<p align="center"><a href="https://youtu.be/hsoJLJ22GVA" target="_blank"><img src="https://imgur.com/ygHMd3L.png"></a></p>

### Introduction:
A tutorial on how to fix the procedural animation with baked animation in Unity3D. Also showing all the steps to setup procedural animation. While trying to make procedural animation to work with baked animation you will notice that the model and the origin point becomes separate or procedural animation is working only. In this tutorial I am showing how to setup the procedural animation and one of the way to fix the procedural and baked animation issue. Watch my [Video]() to get a detailed understanding of the issue, the cause of the issue and the solution to the issue. If my solution doesn't work then I have linked to other sources in [Research Links](#research-links) that fixes this issue using other means.

## Table of Contents:
- [Prerequisites](#prerequisites)
- [Stable Build](#stable-build)
- [HandMove Script](#handmove-script)
- [Research Links](#research-links)
- [Authors](#authors)
- [License](#license)
***
## Prerequisites
#### Unity Game Engine
Unity Version used for this tutorial is **2020.3.3f1**.
***
## Stable Build
[Stable Build - main](https://github.com/deadlykam/TutorialProceduralAnimationFix) is the stable version of the tutorial and is similar to the one shown in the [Video]()
***
## [HandMove Script](https://github.com/deadlykam/TutorialProceduralAnimationFix/blob/8c491343cc49b9bb1fc8dc9b8d103913c7f3f671/TutorialProceduralAnimationFix/Assets/TutorialProceduralAnimationFix/Scripts/MoveHand.cs)
A very simple script for moving the hand of the model procedurally. Basically it keeps moving the hand between two points with a given speed.
- _Transform \_hand:_ The procedural target transform that will be moved.
- _Vector3 \_target1:_ The first point to move towards.
- _Vector3 \_target2:_ The second point to move towards.
- _float \_speed:_ The movement speed of the hand.
***
## Research Links
[(Unity3D Forum) Animation Rigging Package and Humanoid avatars problems](https://forum.unity.com/threads/animation-rigging-package-and-humanoid-avatars-problems.854785/)
***
## Authors
- Syed Shaiyan Kamran Waliullah 
  - [Kamran Wali Github](https://github.com/deadlykam)
  - [Kamran Wali Twitter](https://twitter.com/KamranWaliDev)
  - [Kamran Wali Youtube](https://www.youtube.com/channel/UCkm-BgvswLViigPWrMo8pjg)
  - [Kamran Wali Website](https://deadlykam.github.io/)
***
## License
This project is licensed under the MIT License - see the [LICENSE.md](LICENSE) file for details.
***
