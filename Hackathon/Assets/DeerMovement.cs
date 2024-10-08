using UnityEngine;

public class DeerMovement : MonoBehaviour
{
    public Animator animator; // Reference to Animator component

    private bool isEating = false; // Tracks if the deer is eating

    void Update()
    {

        // Toggle eating state (press "E" to start/stop eating)
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Is Eating: " + isEating);
            isEating = !isEating;  // Toggle eating state
            animator.SetTrigger("IsEating");  // Update the Animator with eating state
        }

        // Prevent movement while eating
        if (isEating)
        {
            Debug.Log("Is Eating: " + isEating);
            // Don't move or rotate if eating
            animator.SetFloat("Speed", 0);  // Set speed to 0 to trigger idle or eating animation
            return;
        }
    }
}
