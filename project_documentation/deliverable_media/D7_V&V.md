# Project Requirements

_Group 04 – “Galactic Gunslingers”\
Date: March 20, 2022\
Group Members: Caroline Fye, Jaron Bauers, Isaiah Raspet, Henry Fye, Jack Normand, Bronwyn Wedig_
## 1. Description
Galactic Gunslingers brings a never seen before gaming experience where you get to play as tough rootin tootin cowboys shootin in space. This game brings a unique spin to your favorite roguelike, dungeon crawler games by implementing both a realtime movement system and turned based combat. Users will have to either create an account or log into an already existing one, that is saved in our server, in order to access the rest of the game. From there you can access our options menu where you can configure the setting to your liking, or just jump right into the game. Galatic Gunslingers has a playful feel to it thanks to its unique pixel/cartoonish art-style and old-westerny soundtrack that will really help immerse the users. This game will hopefully bring countless hours of gameplay with its strong replayability value when we start to add more than one level and when we add items the user will be able to collect throughout the game. You and your friends will be able to play Galatic Gunslingers on your personal computer.

## 2. Verification (tests)

**Unit Test**

*2.1.1*
- The framework used to develop our tests was the Unity Test Framework (UTF) which is the built in unit-testing framework in Unity. In order to be able to carry out these "Mock" operations we had to import 4 different plugins from the [Moq website](https://www.nuget.org/packages/moq/).

*2.1.2*
- Link to our unit tests (https://github.com/CS386-Team4/STR-DCIS/tree/main/Source/STR-DCIS/Assets/Tests/EditMode)

*2.1.3*
- Test Case Example: In this example, we unit tested our random dmg generator class in that was added to our Unit c# file. This new class we added utilizes a "Stats" class where our random damage number is being generated. So in our unit test we tested our new class in we made in Unit c# file and mocked the "Stats" class object and manually set the random number generator through mocking it. Then finally made sure that was the correct number we expected.
- Class Being Tested (https://github.com/CS386-Team4/STR-DCIS/blob/main/Source/STR-DCIS/Assets/Scripts/Unit.cs)
- Unit Test (https://github.com/CS386-Team4/STR-DCIS/blob/main/Source/STR-DCIS/Assets/Tests/EditMode/unit_test.cs)

*2.1.4*

![](./images/mock_unittest.jpg)

**Acceptance Test**

*2.2.1*
- The framework used to develop our tests was the Unity Test Framework (UTF) which is the built in unit-testing framework in Unity.

*2.2.2*
- Link to our unit tests (https://github.com/CS386-Team4/STR-DCIS/tree/main/Source/STR-DCIS/Assets/Tests/EditMode)

*2.2.3*
- Test Case Example: In this example, we decided to create an acceptance test for our Stats class that holds important class values and we wanted to make sure that when it is ran, it was run correctly whenever you create a class object.
- Class Being Tested (https://github.com/CS386-Team4/STR-DCIS/blob/main/Source/STR-DCIS/Assets/Scripts/Stats.cs)
- Unit Test (https://github.com/CS386-Team4/STR-DCIS/blob/main/Source/STR-DCIS/Assets/Tests/EditMode/AcceptanceTest_test.cs)

*2.2.4*

![](./images/acceptanceTest.jpg)

## 3. Validation (user evaluation)
Script: The tasks we gave the user are the following
1. Explore the main menu
2. Explore the options menu
3. Start the game using the start button from the menu
4. Create user login credentials 
5. Log in with said credentials
6. Play around with character movement, explore level scene
7. Begin combat scene
8. Win, move to next scene
9. Explore the rest of the game at your own pace

QUESTIONS TO ASK POST-GAMEPLAY:<br/>
How would you describe the main menu screen?<br/>
What were your favorite and least favorite features of the game?<br/>
What were you initial thoughts on gameplay, movement, and combat?<br/>
What about the game turned you away from it?<br/>
Was there anything in the game that you wish wasn't in the game?<br/>
Was there anything you wish was in the game?<br/>

Results:<br/>
User one: Jack's roommate Brandon (gamer)<br/>
How would you describe the main menu screen?<br/>
The main menu is simple and intuitive. I really like the responsive buttons.<br/>
What were your favorite and least favorite features of the game?<br/>
My favorite feature was the pixel art, least favorite was the combat.<br/>
What were you initial thoughts on gameplay, movement, and combat?<br/>
Gameplay was fine, movement was good, and combat was great.<br/>
What about the game turned you away from it?<br/>
The lack of content and multiplayer.<br/>
Was there anything in the game that you wish wasn't in the game?<br/>
No not really.<br/>
Was there anything you wish was in the game?<br/>
Multiplayer that worked.<br/><br/>


User two: Jacks's friend Wil (gamer)<br/>
How would you describe the main menu screen?<br/>
The main menu sucks. It looks cheap.<br/>
What were your favorite and least favorite features of the game?<br/>
My favorite feature was the movement, my least favorite was the art.<br/>
What were you initial thoughts on gameplay, movement, and combat?<br/>
The gameplay was slow, the movement was good, and the combat was pretty good actually.<br/>
What about the game turned you away from it?<br/>
The lack of promised features.<br/>
Was there anything in the game that you wish wasn't in the game?<br/>
Yes. Some of the art like the wood or stone could look better.<br/>
Was there anything you wish was in the game?<br/>
Multiplayer.<br/><br/>


User three: Jack's friend Jamari (gamer)<br/>
How would you describe the main menu screen?<br/>
The main menu was amazing. Loved the music volume and slider.<br/>
What were your favorite and least favorite features of the game?<br/>
Favorite was the menu screen and art, least favorite was the shortness.<br/>
What were you initial thoughts on gameplay, movement, and combat?<br/>
Gameplay was pretty cool I guess. Movement was quick and reactive, combat was interesting.<br/>
What about the game turned you away from it?<br/>
The speed of the scene switching and lack of animation for it.<br/>
Was there anything in the game that you wish wasn't in the game?<br/>
Yea the music was annoying after a little but the volume slider helped.<br/>
Was there anything you wish was in the game?<br/>
Voice chat.<br/><br/>

Reflections:<br/>
The things that seemed to work well were the art, the menu, and the movement.<br/>
People loved the art style and thought it worked well in the game.<br/>
The gameplay was overall well-liked, but could use some fixes.<br/>
There wasn't a real learning curve, because of the linearity of the game.<br/><br/>

Users performed all the expected tasks just as expected, and the results produced were as expected as well.<br/>
Our value proposition is half-accomplished. If we had implemented multiplayer, then we could argue that the value proposition was met.




