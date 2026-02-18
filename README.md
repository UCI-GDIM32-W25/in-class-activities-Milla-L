# GDIM32 In Class Activities

## W1
### Activity 1
- Go to office hours, Get work done early, Even if you can only work for 15 min... work for 15 min, If you need help outside office/LA hours, ask in questions channel in Discord, Playtest more , Make sure link works (playtest in incognito if no friends)
### Activity 2
1. 10
2. 2
3. "hello world" in the console every frame
4. MonoBehavior
5. print "x = 10" in console when the game is started
6. the parameter sets the x to 10  and then puts the 10 in the "x = " area at the start
7. transform is a class and cannot be translated and cannot put Vector3 into a Transform
8. change to _playertransform.Translate(_direction);
### Activity 3
[MG1 Breakdown](https://docs.google.com/document/d/1ItG4dZjoaa4lzg4txGNIlp00ONVVm-BPawFd5McfTTc/edit?tab=t.0)

## W2
### Activity 1: MG2 Breakdown
![MG2 Breakdown](https://github.com/user-attachments/assets/1cbb0a0f-f809-4a96-9c37-d4b2b781b38a)
### Activity 2: Work on MG2
[MG2 Class Commit](https://github.com/UCI-GDIM32-W25/mg2-Milla-L/commit/40227b3f860eea2e48d5f7ebf44faea45ed57c59)

## W3
### Activities 0-2: Partner Coding
Landon
### Activity 3: MG3 Breakdown
![MG3 Breakdown](https://github.com/user-attachments/assets/1d654c86-85cf-4a78-88d8-aed78bf6e437)

## W4
### Activity 1: Partner Coding Events
Landon
When there are multiple locator scripts, all but the most recent script gets deleted but the game objects remain. This is because the script makes it so that it can only be instantiated once. 
### Activity 2: MG4 Breakdown
![MG4BD](https://github.com/user-attachments/assets/db8cf8d2-d334-4746-8bba-4a4c22949cb8)
### Activity 3: In Class Coding
[MG4 Class Commit](https://github.com/Milla-L/HW4/commit/d99f28d329c495d9b45c5166ba29db8d92bf4275)
I created the project, got it in Github, imported all the assets, and started making the script types for the objects. I also started on the bird and ground game objects. 

## W5
### Activity 1: Abstract Classes and Interfaces
If I were editing it in an actual game setting, I would separate everything out to have their own scripts. It is much easier to read small spurts than the massive logics. I would also make _durability a SerializeField so that it can be tested easier and without having to hard code it. I think that the rest is fine for what it is right now. 
### Activity 2: Scriptable Objects Demo
In the first demo, the MVC pattern has the player controlling everything, displaying everything, and modelling everything with there only being the two other classes that were empty. In the second demo, the MVC pattern has the player as a singleton that updates movement and shows the inventory which is the View. The inventory has the controller part so that it can move through the logic separately. The model comes from the EnemyStats and ItemDemo scripts. This version works better because all aspects are able to function separately while collaborating to form the pattern. 
### Activity 3: Design Patterns Discussion
Inheritance: The parent class would be the inputs so that the individual input indicators can function the same. The different inputs would be the child classes so that they are unique. 
Finite State Machine: The state machine would comprise of the button rankings seen at the end. It would determine what classifies as Cool, Fine, Safe, or Sad between the inputs.
Singleton: The audio manager would be a singleton as well as the UI elements and Miku animator in the back. 
### Activity 4: Attendance and First Draft
Minjoo Shin, Sonia Mangat, Milla Lucido
[Final First Draft Work](https://docs.google.com/document/d/1t76iuo2Br_0iJsKgst12nwN4ChwI5BFe61iVY1-cFXg/edit?tab=t.0)

## W6
### Activity 1: Tool Demos
Demo 1: Performance Profiling
- Window->Analysis->Profiler-> run game-> pause game; 
- Go through objects and see what is causing lag
- Important: GC Alloc, Calls, & Time
- Remove Debugs as fixed, Do not Update() too many strings
 -Use member variables to avoid Update() cluttering
- Use GetComponent() sparingly and not in Update()
- No giant textures or dense meshes, and not much need for mesh colliders (GPU)
- Only physics objects need Rigidbodies or if still needed, set to Kinematic

Demo 2: Breakpoints
- Go to error
- Put in Breakpoint to stop game at that code line
- Shows variables that are active at the time of stop
- Hover over to see what is null
- Call stack shows what methods were called before that line

Demo 3: Merging
- Merge often and in small bursts
- When running into errors >>>>Head is where your code is and <<<<misc numbers is the other persons code
- Try not to run into scene merge conflicts (very bad)
### Activity 2: Attendance and Final Draft
Milla Lucido, Sonia Mangat
[Final Proposal Draft](https://docs.google.com/document/d/1t76iuo2Br_0iJsKgst12nwN4ChwI5BFe61iVY1-cFXg/edit?tab=t.0)

## W7
### Activity 1: Raycasting & NPC state machine demo
- Raycasting keeps chicken within duck sight
- Using gizmos to monitor line of sight
- Keeps track of line of sight for the NPC when outside and inside sight
- HasLineOfSight is really important to keep track
- In that, Raycast is the most important physics thing to keep track of plate
- Fire arrow from duck to exact line of sight
- Raycast returns true or false, hitInfo is what activates brackets
- Use a sphere cast to check for looking directions because when looking, it is better than a line if needing to go around something
### Activity 2: Attendance
Minjoo Shin, Sonia Mangat, Milla Lucido
### Activity 3: Final Breakdown
![GDIM32BD](https://github.com/user-attachments/assets/3f853932-fcb4-44ab-8eff-53bc8e4da45f)
### Activity 4: Initial Tasks
Sonia: Player and item script

Minjoo: Setting up UI

Milla: Building Scene and uploading assets
### Activity 5: Commit Proof
[Final In Class Commit](https://github.com/jedi-narwhal/GDIM32-Final/commit/d738058a06230d8deb7b7d042b5c56e2984f7a66)
I found and uploaded good, free assets for what we wanted as the aesthetic of our game. I also fixed a bit of the player Start() method. 
