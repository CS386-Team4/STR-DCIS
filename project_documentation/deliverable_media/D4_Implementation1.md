
# Project Requirements

_Group 04 – “Galactic Gunslingers”\
Date: March 20, 2022\
Group Members: Caroline Fye, Jaron Bauers, Isaiah Raspet, Henry Fye, Jack Normand, Bronwyn Wedig_
## 1. Introduction
The system that has been implemented thus far is a simple single player game that allows players to traverse a start level and fight an enemy. Future implementation will allow for multiplayer and permanent death. As of now, the game consists of a menu screen with buttons for "start game", "settings", and "exit" along with the title Galactic Gunslingers. Background art and music have been added to this menu screen as well. The settings screen currently only has a volume adjuster and a "back" button. Once the "start game" button is selected, the player is brought to a starting level with an animated enemy and more background art. The player can walk towards the enemy and when they collide the battle scene is loaded. This final scene that has been created allows the player to either attack the enemy or heal themselves, with more background art. 

## 2. Implemented Requirements 
Requirement: "As a PC gamer, I want to be able to play with friends so I can share fun experiences in real time."\
Issue: N/A\
Pull request: https://github.com/CS386-Team4/STR-DCIS/pull/1\
Implemented by: Jaron Bauers\
Approved by: Caroline Fye\
Print screen: <img src ="/project_documentation/deliverable_media/images/Menu.png">\
\
Requirement: "As an end user, I want to be able to adjust game settings so I won't get annoyed if the game is too bright/loud."\
Issue: N/A\
Pull request: https://github.com/CS386-Team4/STR-DCIS/pull/2\
Implemented by: Jack Normand\
Approved by: Caroline Fye\
Print screen: <img src ="/project_documentation/deliverable_media/images/OptionScreen.png">\
\
Requirement: "As a gamer who enjoys turn based mechanics, I want a game that requries strategy and thought so that I can feel rewarded for using my brain"\
Issue: N/A\
Pull request: https://github.com/CS386-Team4/STR-DCIS/pull/3\
Implemented by: Caroline Fye\
Approved by: Jaron Bauers\
Print screen: <img src ="/project_documentation/deliverable_media/images/CombatScreen.png">\
\
Requirement: "As a gamer who enjoys community experiences, I like to be able to play with friends"\
Issue: N/A\
Pull request: https://github.com/CS386-Team4/STR-DCIS/pull/4\
Implemented by: Jaron Bauers\
Approved by: Caroline Fye\

## 3. Tests
*3.1.1*
- The framework used to develop our tests was the Unity Test Framework (UTF) which is the built in unit-testing framework in Unity.

*3.1.2*
- Link to our unit tests (https://github.com/CS386-Team4/STR-DCIS/tree/main/Source/STR-DCIS/Assets/Tests/EditMode)

*3.1.3*
- Test Case Example: In this example, we unit tested our user's health functionality that returns True or False depending on whether or not their character still has health. We also unit tested the healing functionality and made sure that the character's health never exceeded our max health limit in these unit tests.
- Class Being Tested (https://github.com/CS386-Team4/STR-DCIS/blob/main/Source/STR-DCIS/Assets/Scripts/HealthCalculator.cs)
- Unit Test (https://github.com/CS386-Team4/STR-DCIS/blob/main/Source/STR-DCIS/Assets/Tests/EditMode/unit_test.cs)

*3.1.4*

![](./images/Test_Run.png)

## 4. Adopted Technologies
*Unity* 
- A game engine is required to create the game and Unity is very widely used with quite a bit of online information and tutorials. It is also known for being one of the more user friendly engines for beginners in creating video games.

*Visual Studio*
- C# goes hand-in-hand with Unity making it an obvious choice for the scripts in the game. Visual Studio is also a fairly easy-to-use IDE for writing in C# so it was widely used in writing the scripts for the project.

## 5. Learning and Training
Some of the team members already had some experience with Unity but a vast majority of the learning done for the implementation of this project was conducted through Youtube. There are plenty of tutorials on how to create everything from menu screens to the health bars that were put in the video game. For any questions that go beyond what the Youtube videos showed, forum-type websites were used to find the answers. Two main examples incldue StackOverflow and Unity's own forum on their website. Unity has a decent learning curve at the very start but once the basics were understood was not too big of an issue for the team.

## 6. Deployment
The game server is deployed with AWS, which gives us free access to remote computation.
The Server is opened up to be able to receive User Datagram Protocol (UDP) requests from 
any source but only responds to requests in a specific format. The actual serving 
application is built in C# with the .NET framework that makes working with network 
requests very simple. The game communicated with the server with an API that is currently 
being written. The goal of this API is to make the requests to and from the server 
relatively simple.

## 7. Licensing
**MIT License**
- [Our Lincense](https://github.com/CS386-Team4/STR-DCIS/blob/main/LICENSE)
- [MIT Lincense Description](https://choosealicense.com/licenses/mit/)

Our group decided we wanted to implement an MIT License so everyone can have access to our game's files and be able to have full creative control over how they would create our game differently. We also chose this particular license so that we have no responsibility/liability if our code doesn't work, breaks something, etc.

## 8. Readme File
The [README.md](/README.md) file has been updated along with the creation of [CONTRIBUTING.md](/CONTRIBUTING.md), [CODE_OF_CONDUCT.md](/CODE_OF_CONDUCT.md), and [LICENSE](/LICENSE).

## 9. Look and Feel
The look and feel of the project was aimed at making the experience as easy to understand as possible for the user. A simple menu screen with a "play", "settings", and "exit" button are all intuitive on their functionality. The game itself has the user walk around with the "wasd" keys which are widely known in video games for player movement and buttons clicked with a mouse for attacking and healing. As for the actual art style of the game, we went with a cartoon/pixel-like approach. We wanted the game to have a playful and non-serious feel and accomplished that with the style and color choices. 
<img src ="/project_documentation/deliverable_media/images/GG1.JPG">
<img src ="/project_documentation/deliverable_media/images/GG2.JPG">
<img src ="/project_documentation/deliverable_media/images/GG3.JPG">

## 10. Lessons Learned
In retrospective, the team found out that creating the simplest ideas in a video game can take a lot more time than initially thought. As we are all relatively new to game-design and Unity, this issue should lessen as we all gain more knowledge of the engine. We made the correct choice at the beginning of the implementation to create smaller sub-groups that each work on different scenes. Splitting up the project this way allowed for much more work to get done but opened up the possibility of an inconsistent feel to the game. In the future, it may be a good idea to have one person stitch together all of the created scenes to allow for more fluidity in the game. Overall, this minimal implementation felt largely successful and we will continue to work together in a similar fashion for future implementation.

## 11. Demo
https://youtu.be/lvE9MsS3pXU
