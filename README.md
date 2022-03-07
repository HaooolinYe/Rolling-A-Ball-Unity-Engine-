<h1 id="opener"> Rolling A Ball (Unity Engine)  <img src="https://user-images.githubusercontent.com/90864900/152657420-f1a5e9e4-c1ef-49e0-8487-9eb6b6307370.png" height=50 width=50></h1>

Classic 3D game made using Unity Engine. The prototype of my game can be found in <a href="https://learn.unity.com/project/roll-a-ball">this tutorial link</a>. Besides all the classic features of Rolling a Ball, I added some additional ones such as respawning, random rotation of the cubs, score board and so on.

<a href="https://learn.unity.com/project/roll-a-ball"><img src="https://user-images.githubusercontent.com/90864900/157091146-f698c47f-2689-48e0-958d-910a33100d01.png"></a>


<h2> Goals </h2>
<p>
  <ul>
 <li>Use Unity Editor and its built-in capabilities to set up a simple game environment</li>
    <li>Customize scripts in <em>C#</em> to create the game functionality</li>
 <li>Create a basic <em>user interface</em> to improve the game experience</li>
 <li>Set up input using the new Input System</li>
 </ul>
</p>

<h2> Description </h2>
<p>
 The player will use <em>W</em>, <em>A</em>, <em>S</em> and <em>D</em> to control the movement of the ball in the map, aka <em>BALL == PLAYER</em>. To give a brief idea on how the map looks like, there's what you will see when you enter the game:
  <p align="center">
  <img src="https://user-images.githubusercontent.com/90864900/157111864-60f9ea70-f674-4f0b-8fc7-164f3d3d95b8.png" height=500 width=600>
</p>

  The goal of this game is to collect all the <em>yellow cubes</em>. There are in total 16 of them, suspending in the air while maitainting their self-rotation. As you may realize there is <em>a NoteBoard</em> on the top left called <strong><em>Count</em></strong>. The player will win the game when <em>Count</em> reaches tp 16.
 <br>
<i>(They may look somewhat scary while rotating, but don't worry;) Rock the cubes and get yourself a <strong>victory</strong>!)</i>
  <br>
  <br>
  Do be careful with <em>the void</em> in this game. That is, try <strong>not</strong> to fell into <em>the empty space external to the map</em>. Like in other games such as Minecraft, the player would get <em>eliminated</em> once they get too deep in the void. <strong>Luckily</strong>, in this game <em>does not end</em> after that. You will <em>respawn </em>at the middle of the map and start over. The points you get would be initialized to 0 and the cubes you have gained will also get reset.
</p>
  
