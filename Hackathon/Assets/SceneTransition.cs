using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management
using UnityEngine.UI; // Required for working with UI components

public class SceneTransition : MonoBehaviour
{
    public string sceneName; // Name of the scene to load

    // This method will be called when the button is clicked
    public void LoadNextScene()
    {
        // Check if the scene name is not empty
        if (!string.IsNullOrEmpty(sceneName))
        {
            Debug.Log($"Loading scene: {sceneName}");
            SceneManager.LoadScene(sceneName); // Load the specified scene
        }
        else
        {
            Debug.LogWarning("Scene name is empty! Please assign a valid scene name.");
        }
    }

}
