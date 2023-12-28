# TheLegendOfBoggus

This repository has the project designed by Michael Erickson, Christopher Linne, Avery Doctor, Abhinay Putta, Isabel Furl, and Tyra Shin for the CSE 3902 class. This project implements the first dungeon in the original Legend of Zelda game using C#

Current Controls 

Player controls
Arrows and "wasd" keys move Link and change his facing direction.
The 'm' key causes Link to attack using his sword.


Use Item controls
O : Use Item B
P : Use Item A

Item Selector controls
B : Selects B Item
A : Selects A Item
U : Shift Cursor Up 
J : Shift Cursor Down 
K : Shift Cursor Left 
H : Shift Cursor Right 

Other controls
Use 'q' to quit 
Use'r' to reset the program back to its initial state.
Use 'Esc' to pause game.
Use 'Enter' to start game when on start screen.

Extra Implementation added for Sprint 5
-"Infinte" level generation. When link traverses into a room that hasn't been made, it will procedurly make a random room. Also, it is not necesarily infinte since I put a barrier on how far link can go.
-A minigame room. Target shooting game to practice your aiming for fighting enemies.
-Save Files. Can save what items you previously had in a previous run through the game.
-Portal. Allows link to teleport to another in the current room when link walks through a portal.
-Ganondorf boss fight. Another boss added into the dungeon.

Othere Notes
-The diamond doors in the room above the starting room and in the Triforce only open when you collect the triforce piece. 
-The minigame room is the left and up starting from the starting room.
-Save File 1 contains all of the items which makes it easier to test.
-Save File 2 and 3 are unused.

Documentation
Documentation for the team's meeting notes, code reviews, and task board can be found on the notion page here : https://woozy-buckaroo-6ec.notion.site/CSE-3902-Documentation-edd64f49e6c24c07b0f65ea4e5d2ca19
