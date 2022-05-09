# Message From Space

**Name:** Daniel Di Nardi

**Student Number:** C18487682

**Class:** TU858-4 / DT282-4

## Description
An adaptation of the 1978 movie directed by Kinji Fukasaku (who previously directed the movie "Battle Royal").

In this scene, Earths' residents are sending fighters and bombers to an approaching asteroid that hosts a hostile enemy base.

The mission is to destory the enemy before it's too late!

The spaceships will demonstrate steering behaviours covered in the lectures such as wander, offset pursuit, wall avoidance, flocking, and seek.


## Video

Demo Video:

[![youtube](https://img.youtube.com/vi/f28N8w4U7oM/0.jpg)](https://www.youtube.com/embed/f28N8w4U7oM)

Source videos:

[![youtube](https://img.youtube.com/vi/GEmGbpgRzNE/0.jpg)](https://www.youtube.com/embed/GEmGbpgRzNE)
[![youtube](https://img.youtube.com/vi/vC4v979_fQk/0.jpg)](https://www.youtube.com/embed/vC4v979_fQk)

## Storyboard

![image](./Images/StoryBoard-1.png)

### Event Summary

1. Front shot of fighters travelling through a rocky canyon.
2. Switch to rear shot of fighters sneaking up to enemy platform.
3. Pan shot of turrets waiting.
4. Distant shot of fighters circling enemy and shooting turrets.
5. Shot of alarm ringing.
6. Switch to tower point of view.
7. Switch to turret point of view.
8. Switch to fighter point of view.
9. Front shot of bombers with Earth behind them.
10. Rear shot of bombers approaching canyon.
11. Angled shot of bomber overlooking fight.
12. Bomb detached.
13. Bombs' rockets fire.
14. Bomb and ship move away from one another.
15. Rear view of bomb approaching enemy towers.
16. Angled view of bomb pre-impact.
17. Distant shot of explosion.
18. Cut to bombers and fighters flying back to earth.

## Models

All the models in this project have been made using Blender, the terrain was modelled using Unity, and sound effects are made using SFXR.

![image](./Images/Turret.png)
![image](./Images/AngledShip.png)
![image](./Images/BomberMissile.png)
![image](./Images/BomberShip.png)
![image](./Images/Tower.png)
![image](./Images/TerrainBomberView.png)
![image](./Images/TerrainFighterView.png)
![image](./Images/TerrainEnemyView.png)

# Project Report

## Most proud of
I am most proud of the battle scene where the angled ships seek and flee from the turrets as they exchange bullets. I am also proud of what I've learned in modelling the ships in Blender and making sound effects using SFXR.

## How it works

### AI

* The obstacle avoidance and seek steering behaviour were applied to the leading angled ship to navigate its way through the valley before seeing the enemy base.
* Offset pursue was added to the following angled ships alongisde obstacle avoidance which caused cool flipping of the angled ships.
* During the main battle, states were used to toggle on the seek and flee behaviour on the angled ships.

### Behaviours

* Seek: Adds force to the object to move it towards the target.
* Flee: Adds force to the object to move it away from the target.
* Obstacle Avoidance: Uses feelers to detect and avoid specific layers in the scene.
* Offset Pursue: Follows a pre-determined point relative to the leader.

### Weapons

* The angled ships and turrets choose a random turret and angled ship respectively. Each time the angled ships switches between the seek and flee state, a new turret is chosen but turrets keep their original angled ship target.
* For the bombers, they have a set tower to attack.
* Both the angled ships and turrets instantiate bullets in front of them that travel straight from the point of instantiation and get destroyed after 5 seconds.
* When a bomber flies into the tower, it is destroyed and instantiates an explosion particle system that turns on an audio source with the explosion sound.
* The turrets rotate on every axis to look directly at the angled ships.
* The angled ships initially seek a turret, diving towards them shooting, and when they get to close they turn and fly away to then dive on the turret again.

### Design

* There are two particle systems used in this project; the first is the propulsion effect on the bomber and the second effect is the explosion that is instantiated when the bomber crashes into the tower.
* A new skybox is added with a picture of starts and a high resolution image of the Earth.
* There are two types of bullets in the project; the first is a glowing neon red bullet with a neon red trail and the second is a glowing green bullet with a neon green trail.
* A terrain was designed using the terrain modelling software available in Unity.

### Audio

* The music and narration was taken directly from the Message From Space trailer.
* Shooting sound effects, rocket booster sounds and explosion sounds were all created using the SFXR software that allows you to customize sounds in video games.
* The bullet sounds are played once every time a bullet is instantiated. The angled ship bullets and turret bullets have differing sounds.
* The rocket booster sound starts once the scene starts and is played on loop until the next scene.
* Finally, the explosion sound is played once when the explosion particle effect is instantiated.

### Camera

The camera can be found in a number of positions. The first position being attached to the leading angled ship. Next are steady shots of ships flying over them, ships detaching from the bomber body, or of the turrets rotating. Finally, a panning shot of one shot of the battle field to another while the camera is locked to a target in the middle of a fight scene.

## How to Use

* The project can be loaded into Unity or run on the executable file in the build.
* The final scene will only close the software when it is run via the executable.
* If you are running it in Unity, please stop it once the narrator stops talking in the final scene.

## Classes
| Class / Assets  | Source  |
|---|---|
| AngledShip.cs  | Self written  |
| Arrive.cs  | Modified from college course  |
| Boid.cs  | Modified from college course  |
| Constrain.cs  | Modified from college course  |
| FindAngledShip.cs  | Self written  |
| Flee.cs  | Modified from college course  |
| LookAtTarget.cs  | Self written  |
| MoveBackwards.cs  | Self written  |
| MoveForwards.cs  | Self written  |
| MoveShipBackwards.cs  | Self written  |
| MoveShipForwards.cs  | Self written  |
| MoveTarget.cs  | Self written  |
| NoiseWander.cs  | Modified from college course  |
| ObstacleAvoidance.cs  | Modified from college course  |
| OffsetPursue.cs  | Modified from college course  |
| Seek.cs  | Modified from college course  |
| Shoot.cs  | Self written  |
| StateMachine.cs  | Modified from college course  |
| SteeringBehaviour.cs  | Modified from college course  |
| TriggerEnd.cs  | Self written  |
| TriggerEnd2.cs  | Self written  |
| TriggerEnd3.cs  | Self written  |
| TriggerEnd4.cs  | Self written  |
| TriggerEnd5.cs  | Self written  |
| TriggerEnd6.cs  | Self written  |
| TriggerEnd7.cs  | Self written  |
| TriggerEnd8.cs  | Self written  |
| TurretShooting.cs  | Self written  |
| Boom.cs  | Self written  |

## Resources

- Clips and videos: https://www.rollingstone.com/movies/movie-lists/50-best-sci-fi-movies-1970s-163518/message-from-space-1978-174323/
- Assets:
  - Skybox: https://assetstore.unity.com/packages/2d/textures-materials/sky/earth-planets-skyboxes-53752
