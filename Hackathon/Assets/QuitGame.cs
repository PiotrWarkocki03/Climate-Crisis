using UnityEngine;

public class QuitGame : MonoBehaviour
{
    // This method will be called when the button is clicked
    public void CloseApp()
    {
#if UNITY_EDITOR
        // If the game is running in the editor, stop playing
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // If the game is running as a standalone application, quit
        Application.Quit();
#endif
    }
}
