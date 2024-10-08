using UnityEngine;
using UnityEngine.UI; // Needed for UI elements

public class TimerScript : MonoBehaviour
{
    public Text timerText; // Reference to the UI Text element
    private float timer = 0f; // Variable to store the elapsed time

    void Update()
    {
        // Increment the timer based on the real time (ignores Time.timeScale)
        timer += Time.deltaTime;

        // Convert the timer to minutes and seconds
        int minutes = Mathf.FloorToInt(timer / 60f);
        int seconds = Mathf.FloorToInt(timer % 60f);

        // Update the text to show the timer in MM:SS format
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    // Method to reset the timer
    public void ResetTimer()
    {
        timer = 0f;
    }
}
