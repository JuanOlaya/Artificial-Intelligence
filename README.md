# ARTIFICIAL INTELLIGENCE FOR VIDEO GAMES (Unity)

This repository is associated with the subject Artificial Intelligence for Video Games taught in the university [School of Arts and Letters](https://artesyletras.com.co/ingenieria-de-las-artes-digitales/) (Bogotá) by Juan Olaya in the semester 2017.1.

For this course we use [Unity 3D](https://unity3d.com/) as game engine and [Mixamo](https://www.mixamo.com/) as 3D animated characters repository

RPG (Third Person) 

# 1. AI Behaviours for Video games

For this course we developed a third person video with Non-Player Character (NPC) as enemies with following AI Behaviours:

- Patrolling Behaviour
- Attacking Behaviour (Kicking or Punching)
- Pursuing Behaviour (Pathfinding)
- Return to patrolling when the chase is canceled (Pathfinding)

For main character and non-player character we implement:
- Dying Behaviour
- Shove Reaction 
 
Pathfinding (Ruta más corta)
Retorno a Patrolling cuando el enemigo no esté en estado de persecusión. Visto en clase
 (Comportamiento Moribundo): Para personaje principal y enemigo
Jumping (Saltar) : De acuerdo a la información que envié al correo
Utilizando Any State: En el personaje principal implementar comportamientos de Ataque. En mi caso utilicé Kicking (Patada) y Punching (Puñetazo).
https://drive.google.com/drive/folders/0B03A1dZhlfGFeTBPdkF1S09tSDg?usp=sharing
Reacción de puño o patada: Para personaje principal y los enemigos. Yo utilicé la animación Shove Reaction de Mixamo
Adicionalmente, incluir en el videojuego:

Personajes diferentes (1 player, enemigos, transeuntes, animales) asociadas a su narrativa interactiva.

Animaciones Mixamo asociadas a su narrativa interactiva.

Grupos de enemigos autónomos (Non-Player Character)

Gestión de salud de los enemigos autónomos. Y gestionar la salud del personaje principal (player) Tip: Utilizar Colliders de Unity 5 para gestionar la salud.
Utilizar Assets de modelos 3D y texturas de cualquier proveedor asociadas a su narrativa interactiva.

NO es permitido utilizar Assets de proveedores externos, aunque estén en la Asset Store, para modificar la lógica del videojuego (AI, Cámaras...). Si se propone un Asset consultar con el profesor antes de la utilización en el proyecto. 

# 2. Management AI Behaviours
MANAGEMENT AI BEHAVIOURS 
Gestión de comportamientos por medio de Finite State Machine (Máquina de Estados Finitos)
https://docs.unity3d.com/es/current/Manual/StateMachineBasics.html

Mezcla de comportamientos por medio de Blend Trees (Árboles de Mezcla)
https://docs.unity3d.com/es/current/Manual/class-BlendTree.html

# 3. Software Patterns for Health Player Management 

OSVR, as VR framework, allows use concepts such Interactive Item and Eye Raycaster. In order, to use these concepts properly is crucial to add the VR Eye Raycaster script to only one GameObject. For instance, add it to the camera GameObject. Also, add VR Interactive Item script to each GameObject.

Assignment: Manage the health for the main character and the enemies. For this assignment, you must to detect the colisions between NPC and the main properly using scritping and colliders in Unity. Then, create a health bar (HUD) that shows the amount of health for the main character.

Identify the software patterns that have been used by these scripts. Recommended Book: [Game Programming Patterns, Nystrom (2014) - Online version](http://gameprogrammingpatterns.com/contents.html)

# 6. Interactive Experience
For the video game is relevant includ the concepts of Game Design, such as: goals, score, rules, awards, convincing mechanics and vivid interactive storytelling. In addition, it is important to enrich the video game experience with:

Non-Player Characters (NPC) from Mixamo
Waypoints (to move characters, animals or vehicles around)
Textures
Physics Simulation
Explosion Simulation
Sound Effects

# AI BIBLIOGRAPHY
- [Game Programming Patterns, Nystrom (2014) - Online version](http://gameprogrammingpatterns.com/contents.html)
- [The Ghost in the Machine (1982)](https://www.amazon.com/Ghost-Machine-Arthur-Koestler/dp/1939438349/ref=sr_1_1?s=books&ie=UTF8&qid=1489518939&sr=1-1&keywords=ghost+in+the+machine)

# STUDENT PROJECTS
The students designed and developed (###) Entertainment Games using Unity in the course Artificial Intelligence for Video Games. This course was taught in the second semester of the year 2017. The video below shows these projects:
<p align="center">
  <a href="https://www.youtube.com/watch?v=dm2Lv3_lKhE&t=1s" target="_blank">
    <img src="Images/YoutubeVideo.png" width=600 height=340>
  </a>
</p>

## AI Links

## Video Game Resources
- [Google Poly](https://poly.google.com/)
- [A Study Path For Game Programmer](https://github.com/miloyip/game-programmer)
