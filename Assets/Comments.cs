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
    // Variable to store all of the Star objects in the level display
    // Variable to store the finish time text from the GUI
    // Get the star count of the level from the player preferences using the name of the object as part of the key
    // Get the finish time of the level from the player preferences using the name of the object as part of the key
    // Display the Star Count
    // Display the Finish Time
    // Method to display the number of stars received
    // If there are no stars for a level return
    // Loop through for each number of stars
    // Set the Star object to active to display it in the GUI
    // Method to display the finish time of a level
    // If the finish time is greater than equal to or less than 0 return
    // Divide the finish time by 60 and use the remainder for seconds
    // Divide the finish time by 60 for minutes
    // Divide the finish time by 3600 for hours
    // Set the text in the GUI to the calculate times casting each to an integer to remove any decimal places

    /***** Scripts/Oscillator.cs *****/
    // Variable to store the starting position of the object
    // Variable to store the axis' the object should move on
    // Variable to store the amplitude of the movement idfk
    // Variable to store the period of time the object oscillates over
    // Choose a random period of time the object oscillates over
    // Set the starting position to the objects current position
    // If the fltPeriod is less than or equal to the smallest possible float return
    // Continually growing over time
    // Constant value of 6.28
    // Going from -1 to 1
    // Recalculated to go from 0 to 1
    // Calculate the offset
    // Set the position of the object to its starting position plus the offset to move it

    /***** Scripts/Powerup.cs *****/
    // Powerups dont do anything but print to the console then destroy themselves
    // Variable to store the types of powerups
    // Variable to store the objects powerup type
    // Choose powerup from powerup array
    // On collision apply affect
    // Check the powerup type of the object and apply the effect
    // Apply speed powerup
    // Apply jump powerup
    // Apply grip powerup
    // Default to nothing so it does not break, it does nothing anyway
    // Destroy the powerup object so it cant be used multiple times

    /***** Scripts/Resetinator.cs *****/
    // If the collided object is the player
    // Get the current scene/level index
    // Reload the current scene/level

    /***** Scripts/SimpleCarController.cs *****/
    // https://docs.unity3d.com/Manual/WheelColliderTutorial.html (Everything except for Update() is from here)
    // Left wheel collider
    // Right wheel collider
    // Is this wheel attached to motor?
    // Does this wheel apply steer angle?
    // The information about each individual axle
    // Maximum torque the motor can apply to wheel
    // Maximum steer angle the wheel can have
    // If the Escape key is down
    // Load the level select scene
    // If the R key is down
    // Get and reload the current scene
    // Get vertical input for forward/backward movement
    // Get horizontal input for turning movement
    // Pretty self explanitory
    // If there is steering input
    // Apply steering angle to both wheels
    // If there is motor input
    // Apply torque to both wheels
}
