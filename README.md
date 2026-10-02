# Scene management utilities
Unity package for scene management utilities which consists of a scene serialization tool.

### Content
- [Installation](#installation)
- [Example Usage](#example-usage)

## Installation
Install the repository using Git URL in the Unity Package Manager. Make sure to use the following url: `https://github.com/CVG42/Unity-Scene-Management.git`

<img width="336" height="183" alt="Package Manager" src="https://github.com/user-attachments/assets/59024504-23ae-4997-9e7b-eb17437af8df" />

### Demo 
If you want to try the demo, which includes a Load Scene Manager that handles both regular and async scenes, make sure to import the `Demo` from the `Samples` tab in the package setup in the Package Manager.

<img width="451" height="236" alt="Screenshot 2026-10-01 212827" src="https://github.com/user-attachments/assets/4ae40e93-0a33-4e47-85f4-98e492237b79" />

### Dependencies
In order to try the *Demo* make sure to install the following dependencies:
- [UniTask by Cysharp](https://github.com/Cysharp/UniTask)
- [DOTween by Demigiant](https://assetstore.unity.com/packages/tools/animation/dotween-hotween-v2-27676)

## Example Usage
- **Direct reference**
```csharp
[SerializeField] private SceneReference _levelScene;
```
- **Lists**
```csharp
[SerializeField] private List<SceneReference> _asyncScenes = new();
```
