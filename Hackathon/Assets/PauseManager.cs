using UnityEngine;
using UnityEngine.SceneManagement; // Needed to load the Main Menu scene

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenuUI; // Reference to the pause menu panel
    private bool isPaused = false; // Variable to track if the game is paused

    void Update()
    {
        // Check if the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.P))
        {

            Time.timeScale = 1f; // Ensure time scale is reset to normal before leaving the game
            SceneManager.LoadScene("FirstScene"); // Load the main menu scene (replace with your actual scene name)
        }
    }

    // Method to pause the game
    

    // Method to return to the main menu
    public void BackToMenu()
    {
        Time.timeScale = 1f; // Ensure time scale is reset to normal before leaving the game
        SceneManager.LoadScene("FirstScene"); // Load the main menu scene (replace with your actual scene name)
    }
}
