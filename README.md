# Roceter

## Game Title: 
Rocter Dungeon   

## Assets:
Undead Survivor Assets Pack: https://assetstore.unity.com/packages/2d/undead-survivor-assets-pack-238068

## Play FlowChart:


## Bugs:

![playerBug](https://github.com/luthentic/Unity2DRoguelikeGame/assets/33567830/c0943d29-a297-4259-89ef-40569b58f7e2)

Player display is on and off by itself

![anierror](https://github.com/luthentic/Unity2DRoguelikeGame/assets/33567830/c1459a31-6435-4185-a723-061d6947bf59)

check the Animator -> Animator display Error

![fixed](https://github.com/luthentic/Unity2DRoguelikeGame/assets/33567830/e4dd64d9-1a5f-4a01-88e2-f42a5c85e7fa)

## Learned:

### Pixel Art Sprite Setting: 

![image](https://github.com/luthentic/Unity2DRoguelikeGame/assets/33567830/1d1e56ff-0867-4f11-b2fb-52c94c8c3b3a)

Textures are image or movie files that lay over or wrap around your GameObjects to give them a visual effect. This page details the properties you need to manage for your Textures.

https://docs.unity3d.com/2018.4/Documentation/Manual/class-TextureImporter.html

![pixel slice](https://github.com/luthentic/Unity2DRoguelikeGame/assets/33567830/88f97445-d07f-4fae-9214-3541e8374522)

![image](https://github.com/luthentic/Unity2DRoguelikeGame/assets/33567830/24d4a857-982f-43e4-9142-3c009328bf23)

<br/>

#### Order In Layer:

![image](https://github.com/luthentic/Unity2DRoguelikeGame/assets/33567830/4303be95-5d3e-4475-add5-a8081242bdb7)

Set the Renderer to an existing Sorting Layer or create a new one to determine its **priority** in the rendering queue. Change the value of the Order in Layer to set the Renderer’s priority among other Renderers within the same Sorting Layer.

https://docs.unity3d.com/Manual/2DSorting.html

<br/>

### Input Manager

![image](https://github.com/luthentic/Unity2DRoguelikeGame/assets/33567830/27398190-6ee4-4093-8ee9-c9ed7752f8c2)

The Input Manager window allows you to define input axes and their associated actions for your Project. To access it, from Unity’s main menu, go to Edit > Project Settings, then select Input Manager from the navigation on the right.

https://docs.unity3d.com/Manual/class-InputManager.html

Window -> Package Manager

![image](https://github.com/luthentic/Unity2DRoguelikeGame/assets/33567830/d2da66bf-a218-4f24-b6ec-fc5f90feeee4)

![adsf](https://github.com/luthentic/Unity2DRoguelikeGame/assets/33567830/0afd25e6-f6f2-4a5e-893d-e064c00b990e)

![image](https://github.com/luthentic/Unity2DRoguelikeGame/assets/33567830/71fa8c5a-db82-4338-a10c-980eec9624b4)

![onmove](https://github.com/luthentic/Unity2DRoguelikeGame/assets/33567830/28bec302-5afa-4a1a-826c-56a38d6982b5)

Add using UnityEngine.InputSystem;

![image](https://github.com/luthentic/Unity2DRoguelikeGame/assets/33567830/fd3df339-5f82-4141-93bd-cf290b6d6b7b)

Why should we use new input system:

https://medium.com/codex/why-you-should-use-unitys-new-input-system-268773863c4

<br/>

### FixedUpdated

![image](https://github.com/luthentic/Unity2DRoguelikeGame/assets/33567830/59b92e05-1a28-429c-9e14-eb20eb4a8a2c)

Frame-rate independent MonoBehaviour.FixedUpdate message for physics calculations.

MonoBehaviour.FixedUpdate has the frequency of the physics system; it is called every fixed frame-rate frame. Compute Physics system calculations after FixedUpdate. 0.02 seconds (50 calls per second) is the default time between calls. Use Time.fixedDeltaTime to access this value. Alter it by setting it to your preferred value within a script, or, navigate to Edit > Settings > Time > Fixed Timestep and set it there.

https://docs.unity3d.com/ScriptReference/MonoBehaviour.FixedUpdate.html

<br/>



  
