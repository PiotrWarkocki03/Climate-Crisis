using UnityEngine;
using UnityEngine.SceneManagement; // Needed to reload the scene

public class DestroyOnTrigger : MonoBehaviour
{
    // This method is called when the object enters a trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that triggered the event is tagged "Water"
        if (other.gameObject.tag == "Water" || other.gameObject.tag == "Penguin")
        {
            // Destroy the player object
            Destroy(gameObject);

            // Restart the scene after the player dies
            RestartScene();
        }
    }

    // Method to restart the scene when the player "dies"
    private void RestartScene()
    {
        Debug.Log("Player has died. Restarting scene...");
        // Reload the current active scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
