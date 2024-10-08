using UnityEngine;
using UnityEngine.SceneManagement; // For loading the main menu

public class ReturnToMainMenu : MonoBehaviour
{
    // Method to be called when the button is pressed
    public void GoToMainMenu()
    {
        // Ensure the time scale is set back to normal
        Time.timeScale = 1;

        // Load the Main Menu scene (replace "MainMenu" with the actual scene name)
        SceneManager.LoadScene("MainMenu");
    }
}
