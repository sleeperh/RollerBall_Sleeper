# RollerBall_Sleeper
 Roll A Ball With Modifications
- Completed Unity tutorial "Roll A Ball"  https://learn.unity.com/project/roll-a-ball

- Modified pick up objects by using a coin model instead of cubes. 

- Created an introductory scene so that the player can manipulate certain aspects of the game before playing it. 

- Created a dropdown menu to choose the color of the ball by making a script (ColorPicker.cs) with a switch statement which sets RGB values. These values are captured by another script (DataManager.cs) which stores the values to be used in the next scene. A script (ColorChange.cs) attached to the Player object then uses the values to change the color of the Player's material. 

- Created a slider that dictates the speed of the balls movement along its course. This uses another system of three scripts. One which takes in the value of the slider (SpeedSlider.cs); the slider value is saved in the DataManager.cs script; then the value is used in the PlayerController.cs script to dictate Player speed. 

- Created a toggle switch for allowing the Player to have an oversized ball. This was also implemented by 3 scripts. One (SizeToggle.cs) to detect whether or not the switch has been toggled; DataManager.cs stores the boolean state; and SizeChange.cs which is attached to the Player object takes the boolean state and changes the scale of the Player Sphere accordingly. 

- Once in the game proper, players can hit the "Esc" key to pause where they have the option to quit the game. "Esc" again to unpause. This is done in one script (PauseMenu.cs) that uses a method to enable or disable a set of UI components and sets Time.timeScale to 0 or 1 accordingly to stop or start game activity. 

- In addition to the introductory and mini game scenes, I added an ending scene which thanks the player for playing and allows them to start over or quit the game. 
