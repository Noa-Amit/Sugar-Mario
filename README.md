# sugar mario

link to itch.io: https://noa-amit.itch.io/task6-phycics

![WhatsApp Image 2020-12-01 at 23 39 44](https://user-images.githubusercontent.com/57709369/100800089-c0a34e80-342e-11eb-9960-91874483b361.jpeg)


This repository is a basic sugar mario game. 
The game opens with a brief explanation of the background story and how the game is played.

## The Tutorial
![WhatsApp Image 2020-12-22 at 15 24 09](https://user-images.githubusercontent.com/57709369/102893297-08cff280-446a-11eb-9ae9-caa80fe6de56.jpeg)


The tutorial scene explaine the player how to play.It has all the objects in the game (Mario, enemies, food, etc.). It also has a doctor that explain the game.
The main object is Bubble- an speech buble with text inside (attached to the doctor).
Bubble has 3 main objects:
1. canvas-> button - the button used to Switch between texts in the bubble. It has a script https://github.com/Noa-Amit/Task-6-new/blob/main/Assets/Scripts/NextText.cs
that when the player press the button, it switch between the texts, and the bolds.
2. text- every text has an explanation about part of the game. When the explanation is about one of the objects in the screen, there is also a bord (an image of arrow) that points on the specific object (for example, when the text explain the sugar field, there is an arroe point on it).
3. bold- an object that have an image of an arrow and point about objects in the screen

## The game
The game has 3 levels with a different difficulty levels.
Every level has this main objects:
1. player- Mario
2. Ground-Keeps the whole objects from falling.

3. Shelf-Mario can jump on the shelfs. Every sheld has couple of block and a groung (kipping the block from falling).https://github.com/Noa-Amit/Task-6-new/blob/main/Assets/Prefabs/Block.prefab

4. foods-every food in the game has a different level of sugar. And when Mario take it the sugar level of Mario is up. For example, when Mario takes the cola the sugar up on 50 point. Ice cream gets the sugar up with 10 points, (like in real life, cola has more sugar then icecream).https://github.com/Noa-Amit/Task-6-new/blob/main/Assets/Prefabs/IceCream.prefab


5. Enemy- When Mario hits a enemy he loses life. https://github.com/Noa-Amit/Task-6-new/blob/main/Assets/Prefabs/Enemy.prefab

6. Pipe- when mario gets to the pipe he moves to the next level.https://github.com/Noa-Amit/Task-6-new/blob/main/Assets/Scripts/GoToNextLevel.cs

7. sugar field- the game begin with some level of sugar. Mario needs to keep the sugar around 100. If the sugar gets too low or too high- Mario lose life. https://github.com/Noa-Amit/Task-6-new/blob/main/Assets/Scripts/SugarField.cs

8. life field- counts the number of life the player has.
https://github.com/Noa-Amit/Task-6-new/blob/main/Assets/Scripts/LifeField.cs

9.insulin block- special block that give the player super power! changes the sugar score to be 100.
 
