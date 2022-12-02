using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comments : MonoBehaviour
{ // Good Luck
    /***** Scripts/MainMenuController.cs *****/
    // Variabled to store the two menu objects
    // On start, deactivate the settings menu so only one is displayed
    // On start, activate the Main menu so only one is displayed
    // Method to handle the button click and load the corrisponding scene
    // When the play button is clicked load the level select scene
    // Method to display the settings menu
    // When the settings button is clicked, activate the settings menu
    // When the settings button is clicked, deactivate the main menu
    // Method to quit the game
    // Quits the application
    // Method to handle clicking the back button in the settings menu
    // Deactivate the settings menu
    // Activate the main menu

    /***** Scripts/MainMenuController.cs *****/
    // Methods to handle button clicks and load the corrisponding level
    // Load level 1 scene
    // Load level 2 scene
    // Load level 3 scene
    // Load level 4 scene
    // Load level 5 scene
    // Load level 6 scene
    // Load main menu scene

    /***** Scripts/Credits.cs *****/
    // Variable to store the credits animator
    // Variable to store an audio clip
    // Variable to store the amount of time to wait before going to the main menu
    // Variable to store the audio source
    // Get the audio source component from the object
    // Set the animation speed to 0
    // Play the audio in the audio source
    // Start the main menu coroutine to go to the main menu after a set time
    // While this is true, which happens to be all the time
    // Return and wait for a set amount of seconds
    // Load the main menu scene after a set amount of seconds

    /***** Scripts/Level1Tutorial.cs *****/
    // Variables to store the tutorial prompts
    // Variables to store whether the W/S keys have been pressed
    // Enable the accelerate prompt to show the user the first prompt
    // Disable the brake prompt
    // Disable the quit prompt
    // If the W key has not been pressed and the W key has been pressed
    // Set the W key has been pressed variable to true
    // Disable the accelerate prompt
    // Enable the brake prompt to show the user the next action
    // If the W key has been pressed, the S key has not been pressed, and the D key was pressed
    // Set the S key has been pressed variable to true
    // Disable the brake prompt
    // Enable the quit prompt to show the user the next action
    // If both the W and S keys have been pressed
    // Start a courotine to delete all prompts
    // While this is true, which happens to be all the time
    // Return and wait for a set amount of seconds
    // After the set amount of seconds, destroy the parent object, which is the "Prompt" object

    /***** Scripts/Level2Tutorial.cs *****/
    // Variables to store the tutorial prompts
    // Variables to store whether the A/D keys have been pressed
    // Enable the turn left prompt to show the user the first action
    // Disable the turn right prompt to only show one action at a time
    // If the A key has not been pressed and the A key was pressed
    // Set the A key has been pressed variable to true
    // Enable the turn right prompt to show the user the next action
    // Disable the turn left prompt
    // If the A key has been pressed, the D key has not been pressed, and the D key was pressed
    // Set the D key has been pressed variable to true
    // If both keys have been pressed
    // Destroy the parent object, which is the "Prompt" object (This could be moved to line 38 and eliminated but I already made the comment so I am not changing it)

    /***** Scripts/Controller.cs *****/
    // Variable to store the Text Mesh Pro GUI timer
    // Variable to store all of the Star objects in the GUI
    // Variable to store the one, two, and three star times of a track
    // Variable to store the star count of a track
    // Variable to store the time elapsed in a track
    // Reset the time variable
    // Increase the time variable by the delta time every frame
    // Call to set timer time method to update the displayed time
    // Variables to calculate and store the time in seconds, minutes, and hours
    // Set the text mesh pro variables text to a formated time
    // If the current time is greater than the tracks two star time and the star count is equal to two
    // Update the star count
    // Decrement the star count variable by one
    // If the current time is greater than the tracks One star time and the star count is equal to one
    // Update the star count
    // Decrement the star count variable by one
    // If the current time is greater than the tracks zero star time and the star count is equal to zero
    // Update the star count
    // Method to update the number of displayed stars
    // Deactivate a star by using the star count variable
    // Method to return the intStarCount variable
    // Returns the intStarCount variable
    // Method to return the fltTime variable
    // Returns the fltTime variable

    /***** Scripts/HandleFinish.cs *****/
    // Variable to store the name of the next level (this is a bad way to do it, but I am lazy)
    // Variable to store the controller class of the controller object
    // If the collided object has the player tag
    // Call the Finish method to handle the player finishing the track
    // Method to handle the finish event
    // If the next level string is null
    // Load the level select scene
    // Call to save information to save the star count and time
    // Load the next level based on the next level string (Bad but lazy)
    // Method to save the star count and track time in the playerprefs file
    // Get the active scene name and remove all whitespace using regex
    // Using the key <levelname> + "StarCount" set an integer of the star count of the level
    // Using the key <levelname> + "FinishTime" set a float of the track time 
    // Write the new playerprefs to disk

    /***** Scripts/LevelSelectDisplay.cs *****/

}
