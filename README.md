# AdventuraCircuit
Description :- A casual 3D game consisting on moving a ball towards the finish line while trying to avoid the obstacles on the way.

Gameplay preview

![Obstacle Course](https://user-images.githubusercontent.com/71871620/129717002-7eeec341-e533-41a7-841f-feac27671987.gif)

Some design diagrams

![Beginning 2](https://user-images.githubusercontent.com/71871620/129935032-5712bc4a-a7d2-42dd-a9bc-4d21c3f4705a.png)

![First Cube 3](https://user-images.githubusercontent.com/71871620/129935253-de410ce6-ac4f-4943-9364-cc0bb6f4008c.png)


This game is based on the first section of the GameDev.tv Unity 3D course.

My original implementations are:
- Player moves a ball instead of a cube.
- Instead of direct control through arrow keys, players control the ground's inclination angle with the mouse movement. The ball moves appropriately in response.
- Original obstacles like slopes, horizontal windmills and pendulum cubes.
- A basic UI for gameplay and control explanations.
- A timer to keep track of how long does it take for the player to control the level.
- Expanded the controls to include pressing R for restarting the level, P to pause/unpause and Esc to quit.

Distinctiveness and Complexity of the Project:
  - Complex Physics Interactions: The ball behavior in the game involves intricate physics interactions, such as handling forces, gravity, and collisions. Implemented and fine-tuned these physics mechanics to ensure realistic and responsive ball movement which required a deep understanding of physics simulation and complex scripting.

  - Dynamic Obstacle Course: The obstacle course in the game presents a complex challenge for players to navigate through. Designing and scripting the obstacles, their movement patterns, and interactions with the ball demanded careful planning and coordination to create a challenging yet fair gameplay experience.

  - Adaptive Difficulty: The game may incorporate an adaptive difficulty system that dynamically adjusts the obstacles and their behavior based on the player's skill level. Implementation of such a system requireed sophisticated algorithms and logic to provide an optimal level of challenge while maintaining player engagement.

  - Precise Timing and Coordination: Successfully maneuvering the ball through the obstacle course requires precise timing and coordination. Implementing systems that account for player input and synchronize it with the physics simulations, obstacle movements, and level design possessed a complex technical challenge.

  - Real-time Decision-making: As players navigate the obstacle course, they may encounter dynamic situations that require quick decision-making. Designing and scripting AI or logic to handle real-time decision-making, such as obstacle avoidance or adaptive obstacle behaviors, adds complexity to the project.

  - Collision Detection and Response: Ensuring accurate collision detection and responsive collision response between the ball and obstacles involves complex algorithms and efficient scripting. Implementing collision detection that considers various object shapes, sizes, and positions was demanding.

  - Scoring and Progression System: Implementing a scoring system that accurately tracks the player's performance, such as time taken or number of collisions, and a progression system that unlocks new levels or features based on player achievements adds complexity to the project. Designing and scripting these systems to provide a satisfying and balanced progression curve required careful planning and implementation.

  - Game State Management: Managing various game states, including start, pause, restart, and game over, requires intricate scripting and coordination. Implementing systems to handle state transitions, GUI updates, and player input during different game states was challenging and required meticulous attention to detail.

  - Optimizing Performance: With complex ball behavior and obstacle interactions, optimizing performance becomes crucial. Balancing visual fidelity, physics simulations, and gameplay responsiveness required efficient coding, algorithm optimization, and consideration of hardware limitations.

  - Playtesting and Balancing: Creating a distinct and engaging gameplay experience involved extensive playtesting and balancing. Iteratively refining the obstacle course, adjusting the ball behavior, and fine-tuning difficulty levels based on player feedback and testing resulted in a complex and time-consuming process.

In summary, the distinctness and complexity of the project lie in the intricate physics interactions, the design and scripting of the dynamic obstacle course, adaptive difficulty systems, precise timing and coordination requirements, real-time decision-making, collision detection and response, scoring and progression systems, game state management, performance optimization, and the iterative playtesting and balancing process.

Scripts Used For Implementation:
  - Ball Behaviour - In the gameplay, the ball's behavior serves as an obstacle, infusing the player's navigation through the circuit with an exhilarating and unpredictable dimension. As the ball is introduced, it dynamically interacts with forces such as gravity, generating a captivating experience abundant with unforeseen twists and turns. These dynamic characteristics elevate the gameplay, bestowing it with an irresistible blend of intrigue and challenge for the player.

  - Cube Fall - In the game, "Cube Fall," players must skillfully avoid colliding with a falling cube to successfully complete the game without any object collisions. The cube descends from above, adding a challenging element as players navigate their way through the game environment, employing precision and agility to evade contact with obstacles. Mastering the art of avoiding the descending cube becomes crucial in accomplishing the game's objective unscathed.

  - DestroyGameobject - In my game, I have implemented the Scene Management Unity feature that enables the destruction of objects that are no longer necessary for the gameplay. By utilizing this functionality, I can efficiently remove objects from the game, ensuring they no longer impact the gameplay experience. This capability allows for effective management of game elements, enhancing performance and maintaining a streamlined and optimized game environment.

  - GameController - The GameController module in my game serves as a central control hub, managing various aspects such as instructions, menus, quitting, restarting, and text rendering. It acts as a coordinator, orchestrating the flow of information and user interactions within the game. Through the GameController, players can access game instructions and initiate actions like quitting or restarting the game. Additionally, it handles the rendering of text elements, ensuring clear and informative visual feedback throughout the gameplay experience. The GameController component plays a pivotal role in providing a seamless and user-friendly interface for players to interact with the game.

  - LevelTimer - The LevelTimer component in my game serves the purpose of tracking and displaying the time taken by the player to complete a level. It functions as a countdown or stopwatch mechanism, measuring the elapsed time from the start of the level until its completion. The LevelTimer provides a visual representation of the time through a GUI implementation, allowing players to monitor their progress and strive for faster completion times. This feature adds an element of challenge and encourages players to improve their speed and efficiency as they strive to beat their own or others' time records.

  - Mover - The Mover component in my game serves as a crucial tool for moving the ball in a specified direction while also controlling its rotation and other related attributes. By utilizing the Mover, players can navigate the ball through the game environment, maneuvering around obstacles and avoiding potential collisions. This component allows for precise control over the ball's movement, enabling players to apply directional forces and rotations as needed to navigate challenging paths. The Mover enhances gameplay by empowering players with the ability to skillfully steer the ball, adding an element of strategy and skill to overcome obstacles and successfully progress through the game.

  - ObjectHit - The ObjectHit component in my game serves the purpose of keeping track of the number of objects hit by the player while navigating through the circuit. It acts as a counter, incrementing each time the player collides with an object within the game environment. The ObjectHit component provides a visual or numerical representation of the accumulated hits, allowing players to monitor their progress and potentially incorporate it into gameplay mechanics, such as achieving a high score. This feature adds an element of challenge and engagement as players strive to minimize the number of object collisions and aim for a flawless run through the circuit.

  - PingPongObstacle, RotatingPole - In the game, the PingPongObstacle and RotatingPole serve as challenging obstacles that players must navigate through. The PingPongObstacle presents a dynamic barrier, potentially moving back and forth or bouncing within the game environment, requiring players to time their movements carefully to avoid collision. On the other hand, the RotatingPole adds an additional layer of complexity by continuously spinning or rotating, creating a moving obstacle that players must navigate around. Both of these obstacles demand precise control and quick reflexes from the player, enhancing the difficulty and excitement of the gameplay as they strive to successfully maneuver past these obstacles and progress further in the game.

  - StartandFinish - In the game, the StartandFinish component utilizes the StartCoroutine function, which enables the suspension of execution until a specified YieldInstruction completes. This functionality is particularly useful for managing game states such as starting and finishing conditions. When the game is over, the execution of the StartCoroutine function is paused, allowing for necessary actions or transitions to take place. Once the appropriate conditions are met, the execution resumes from where it left off, ensuring a seamless continuation of the game flow. By utilizing StartCoroutine, the game effectively controls the timing and sequence of events, enhancing the overall gameplay experience and ensuring smooth transitions between different game states.

How to Play the Game:
- Download the zip file
- Then just click on the Obstacle Course.exe application to run the game

