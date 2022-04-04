
# Design

_Group 04 – “Galactic Gunslingers”\
Date: April 3, 2022\
Group Members: Caroline Fye, Jaron Bauers, Isaiah Raspet, Henry Fye, Jack Normand, Bronwyn Wedig_
## 1. System Description
&emsp;Multiplayer games have been severely lacking in niche challenges nowadays and players are constantly looking for new ways to cure boredom. Galactic Gunslingers fills that void as a turn-based roguelike that allows gamers to tackle unique challenges with their friends every time they play. **Users** can connect to our multiplayer **servers** to find or create a **session** with teammates from around the world. **Profile** creation also allows the **user** to customize and identify with their character. For gamers who want a unique mix of an immersive universe full of wild west astronauts along with the intensity of a turn-based roguelike, Galactic Gunslingers will provide just that.

&emsp;Galactic Gunslingers **users** will download the program from the internet and run it on their **system** <ins>using</ins> our high-*speed* **servers**. In order to run the program, they will need a *computer* that meets certain *graphics* and *operating system* specifications. All **users** will need to either create a new **profile** or sign in to a pre-existing one before accessing the **game**. **Profile** creation will require a *username*, *password*, and *email*. **Developers** can also log in to a **profile** with admin privileges that allows them to perform *testing* and create new *updates*. 

&emsp;Once in the **game**, the **user** will be brought to a main menu where they can change settings, customize their *character*, and <ins>join</ins> new games. Before diving into a **session**, the **user** can <ins>view</ins> their **friends** list along with all of their *statuses*. The **user** can also <ins>send</ins> a **session** *invite* to any of these **friends**. Once in a **session**, they will come across **other users**, new *items*, *enemies*, and *bosses* with variation in *difficulty*. These **other users** will <ins>display</ins> their *active character* to the **user** and the **user** will also have the ability to <ins>send</ins> them a **friend** request. The **user** will also be able to **message** with the **other users** through a <ins>chat box</ins>. The <ins>chat box</ins> contains *mute* and *profanity filter* functions. Once the **game** has finished, all players return to the home screen.

## 2. Architecture
![System Archtecture](https://github.com/CS386-Team4/STR-DCIS/blob/main/project_documentation/deliverable_media/images/System_Architecture.png)


The server and the game client are the two main modules in the game. The server contains a database of clients as well as a queue of instructions that determine what is going on for every given player as well as what kind of information to send. The client contains a local copy of the information stored in the database on the server. On every startup of the game, the information between the two locations is checked with a hash to see if anything needs to be updated locally. The client also contains an instance of a game and a series of players, as well as a defined host.


## 3. Class Diagram
![UML diagram](https://user-images.githubusercontent.com/21299000/161398068-555315e2-7002-4e7d-8bed-65dc06a624f3.png)


## 4. Sequence Diagram

<img src ="/project_documentation/deliverable_media/images/SequenceDiagram.png">

Use Case: Attack enemy\
Actor: User\
Description: The user attacks and deals damage to enemy\
Pre-Conditions: the user is at a fair level against enemy and is in battle scene 
Post-Conditions: Enemy takes damage and either faints or is able to fight back\
Main Flow & Alternative Flows:
1. User level determines attack damage
2. User attacks enemy\
2.1. Enemy faints\
2.2. Enemy survives and may attack back, flee, or defend
3. User takes damage
4. User defeats enemy and gains experience points\
4.1 XP goes over threshold leveling up player\
4.2 XP does not go over threshold and level stays the same



## 5. Design Patterns
### Strategy Design Pattern:
![Strategy Diagram](https://github.com/CS386-Team4/STR-DCIS/blob/main/project_documentation/deliverable_media/images/StrategyDiagram.JPG)


## 6. Design Principles
__Single Responsibility Principle__: [link](https://github.com/CS386-Team4/STR-DCIS/blob/main/Source/STR-DCIS/Assets/Scripts/PlayerMovement.cs) - The PlayerMovement class is only in control of executing the player's movement and nothing else is being done in this class.

__Open/Close Principle__: [link](https://github.com/CS386-Team4/STR-DCIS/blob/main/Source/STR-DCIS/Assets/Scripts/MainMenu.cs) - The code follows this principle because the MainMenu Class is in charge of directing the Users to different scenes like the options menu, main menu, exiting the game, etc. Ultimately this class won't change in the future and the code is already being extended to our options menu scene and will be implemented in our pause menu in the future.

__Liskov Substitution Principle__: [link](https://github.com/CS386-Team4/STR-DCIS/blob/main/Source/STR-DCIS/Assets/Scripts/BattleSystem.cs#L17) - Lines 17 and 18 follow this principle because there are "player/enemy unit" objects that are being used throughout the code and are being passed through many different methods to determine if they are alive, dead, being damaged, healed, the unit's name, etc. This code is very reusable because it can be reused whenever we have a combat scene in our game.

__Interface Segregation Principle__: [link](https://github.com/CS386-Team4/STR-DCIS/blob/main/Source/STR-DCIS/Assets/Scripts/MainMenu.cs#L14) - Line 14 is a great example of this principle because, instead of having the settings already built into the main menu we have an options button that will take you to an optional "options menu" where you can use a different UI to change the game settings. We created a new options meny UI apart from the main menu UI to break up the complexity of our main menu UI. Also this options menu is an OPTIONAL scene to our game and the client can possibly never have to use it.

__Dependency Inversion Principle__: [link](https://github.com/CS386-Team4/STR-DCIS/blob/Server/Source/Server/GGServer/GGServer/Program.cs) - The code that will handle our server requests follows this particular principle because it will not depend on the client for anything. The code will focus on the user's input and will queue and dequeue the server requests.
