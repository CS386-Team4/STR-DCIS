
# Project Requirements

_Group 04 – “Galactic Gunslingers”\
Date: February 10, 2022\
Group Members: Caroline Fye, Jaron Bauers, Isaiah Raspet, Henry Fye, Jack Normand, Bronwyn Wedig_
## Positioning
**Problem Statement:** \
The problem of lack of roguelike multiplayer games affects multiplayer gamers, the impact of which is a dearth of specific types of multiplayer challenges.

**Product Position Statement:**\
For gamers who want a roguelike game to play with friends, Galactic Gunslingers is a multiplayer roguelike that allows players to tackle roguelike challenges with friends; unlike many games, our product incorporates multiplayer without sacrificing key features of the genre.

**Value Proposition and Customer Segment:**\
Galactic Gunslingers is a multiplayer roguelike that allows gamers to tackle roguelike challenges with their friends.

## Stakeholders
Players: The players will be the end users of our game.\
Developers: The developers are responsible for creating the software and making sure it works properly.

## Functional Requirements (Features)
1. Multiplayer
2. Tile Based Movement
3. Multiple Characters
4. Player Accounts
5. Matchmaking
6. Graphical Models
7. Sprite Animations
8. Looting/Inventory
9. Combat

## Non-functional Requirements
1. Accessibility
2. Data Integrity
3. Operability
4. Durability
5. Fault Tolerance
6. Licensing
7. Network Topology
8. Privacy
9. Security/Safety
10. Usability
11. Localization

## MVP
Constructing a minimal viable product for a turn-based, roguelike, dungeon crawler computer game means finding the key game feature requirements that are a must need to still have a playable game. In our game's scenario, the MVP will consist of a simple game hub, one game level to start, focus on singleplayer game design, basic artwork/sound, and just enough in game functionality to play (ex. movement, attacking, jumping, etc.). After we have completed desining this very early state of our computer game, we will release it to a couple of users in order to gain constructive feedback on how this game could be improved upon. After the users are done testing our game, we will take in whatever feedback provided whether it be they want a new artstyle, multiplayer, specific game items, etc. We will then start implementing only these specified features and have users test our game again in this interative game development process. This practice is useful because it will prevent us from going overboard with features that we assume our users want. It also prevents us from creating a finished game that has had no user input throughout the game development process.


## Use Cases

**Use Case Diagram**

<img src ="/UseCaseDiagram.png">

**Use Case Descriptions and Interface Sketch**

**Use case 1**: Plays game\
**Primary Actor**: Gamer/Player\
**Description**: The gamer interacts with the game by following through on in game objectives\
**Pre-conditions**: Gamer logs on to game\
**Post-conditions**: Gamer wins or loses game\
**Main flow**:
1. The player logs onto the game
2. The player starts the game from the title screen
3. The player adds friends
4. The player goes room to room
5. The player gains loot
6. The player defeats or is defeated by bosses
7. The player loses or wins the game

**Alternative flow**:\
2a. Player creates an account\
5a. Player does not gain loot\
5b. Other players gain Player's loot

<img src="/UseCase1.png">

**Use case 2**: Buys in game purchases\
**Primary Actor**: Gamer/Player\
**Description**: Player is prompted with an interface and then purchases an in-game item\
**Pre-conditions**: Player has an account associated with the game\
**Post-conditions**: Player gains the item associated with the purchase\
**Main flow**: 
1. Player chooses in game purchase to buy
2. Player is redirected to another page
3. Player is prompted for their account
4. Player is prompted for their payment information
5. Player pays
6. Player is redirected back to the game
7. Player is given item associated with purchase

**Alternative flow**:\
2a. Player may stay in game with no redirection\
3a. Player is already logged on to account

<img src="/UseCase2.png">

**Use case 3**: Maintains software\
**Primary Actor**: Game Developers\
**Description**: Game developers maintain the game by regularly updating it\
**Pre-conditions**: The game must already be complete\
**Post-conditions**: The game is updated with new events and items\
**Main flow**:
1. Game Developers complete game
2. Developers implement new C code into game
3. Developers track bugs in the new code
4. Developers test and run this update
5. Once ready, Developers release the update
6. Players see update screen

**Alternative flow**:\
3a. Developers hire testers to test the update

<img src="/UseCase3.png">

**Use case 4**:
**Primary Actor**:
**Description**:
**Pre-conditions**:
**Post-conditions**:
**Main flow**:
**Alternative flow**:

**Use case 5**:
**Primary Actor**:
**Description**:
**Pre-conditions**:
**Post-conditions**:
**Main flow**:
**Alternative flow**:

**Use case 6**:
**Primary Actor**:
**Description**:
**Pre-conditions**:
**Post-conditions**:
**Main flow**:
**Alternative flow**:


## User Stories
User Story 1: "As a PC gamer, I want to be able to play with friends so I can share fun experiences in real time." 
Priority: 10 
Estimated Hours: 30

User Story 2: "As an end user, I want to be able to adjust game settings so I won't get annoyed if the game is too bright/loud." 
Priority:5 
Estimated Hours: 10

User Story 3: "As a person who enjoys sci-fi media, I want a cool theme to the game so that it doesn't feel bland and boring." 
Priority: 7 
Estimated Hours: 15

User Story 4: "As a gamer who enjoys turn based mechanics, I want a game that requries strategy and thought so that I can feel rewarded for using my brain" 
Priority: 8 
Estimated Hours: 15

User Story 5: "As a gamer who enjoys a turn based game, I want a game with quick combat so I do not have to waste time on slow mechanics"
Priority: 8
Estimated Hours: 15

User Story 6: "As a person who enjoys sci-fi media, I want a game with a lot of player customization so that I can feel immersed."
Priority: 1
Estimated hours: 20

User story 7: "As a gamer who wants to be entertained, I want variations in gameplay so I don't get bored from doing the same thing constantly." 
Priority: 4
Estimated Hours: 15

User story 8: "As a gamer whose experience is impacted by style, I want a consistent art style so I can better focus on the gameplay itself." 
Priority: 7
Estimated Hours: 20

User story 9: "As a gamer whose enjoys high stakes, I enjoy permanent death"
Priority: 4
Estimated Hours: 20

User Story 10: "As a gamer who enjoys community experiences, I like to be able to play with friends"
Priority: 4
Estimated Hours: 25

## Issue Tracker
https://github.com/CS386-Team4/STR-DCIS/projects/2
