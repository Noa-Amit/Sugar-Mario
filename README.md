# sugar mario

link to itch.io: https://noa-amit.itch.io/task6-phycics

![WhatsApp Image 2020-12-01 at 23 39 44](https://user-images.githubusercontent.com/57709369/100800089-c0a34e80-342e-11eb-9960-91874483b361.jpeg)


This repository is a basic sugar mario game. 
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
 
### The difference between the scenes:
1. The inital sugar score.level 1- start with 100 points. level 2- start with 150 points. level 3- start with 70 points.In all the scene mario needs to keep the blanace of 100 points.

2. The number of enemies.level 1- has no enemies. level 2- has 3 enemies. level 3- has 5 enemies.
