using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public float timeRemain = 30f;
    public bool timerIsRunnning = false;
    public Text timerText;

    private void Start()
    {
        timerIsRunnning = true;
    }
    private void Update()
    {
        if (timerIsRunnning)
        {
            if (timeRemain > 0)
            {
                timeRemain -= Time.deltaTime; // Decrement time
            }
            else
            {
                // Timer has reached zero
                timeRemain = 0;
                timerIsRunnning = false;
                Debug.Log("Timer finished!");
                // You can trigger any event here
            }
        }

        // Update the timer display if a UI Text element is assigned
        if (timerText != null)
        {
            timerText.text = "Time Remaining: " + Mathf.Round(timeRemain).ToString();
        }
    }

    public void AddTime(float amount)
    {
        timeRemain += amount;
    }
}
