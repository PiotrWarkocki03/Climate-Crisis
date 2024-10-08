using UnityEngine;
using UnityEngine.SceneManagement; // Needed to switch between scenes

public class ChangeSceneOnTrigger : MonoBehaviour
{
    // The name of the scene to load, set this in the Inspector
    public string sceneName;

    // This method is called when the object enters a trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that triggered the event has the tag "Player" (or any other tag you prefer)
        if (other.gameObject.tag == "Player")
        {
            // Call the method to load the specified scene
            LoadScene();
        }
    }

    // Method to load the specified scene
    private void LoadScene()
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            Debug.Log("Loading scene: " + sceneName);
            SceneManager.LoadScene(sceneName); // Load the scene by name
        }
        else
        {
            Debug.LogWarning("Scene name is empty! Please assign a valid scene name.");
        }
    }
}
