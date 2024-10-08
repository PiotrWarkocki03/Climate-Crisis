using UnityEngine;


public class MoveBackAndForth : MonoBehaviour
{
    public Vector3 pointA; // The first point (starting position)
    public Vector3 pointB; // The second point (destination)
    public float speed = 2f; // Speed of movement

    private bool movingToB = true; // Direction flag to track movement

    private Vector3 originalScale; // To store the original scale of the character

    void Start()
    {
        // Store the original scale of the object (used for flipping)
        originalScale = transform.localScale;
    }

    void Update()
    {
        // Move towards pointB if movingToB is true, otherwise move towards pointA
        if (movingToB)
        {
            // Move towards point B
            transform.position = Vector3.MoveTowards(transform.position, pointB, speed * Time.deltaTime);

            // If the object reaches point B, switch direction
            if (Vector3.Distance(transform.position, pointB) < 0.01f)
            {
                movingToB = false;

                // Flip the character to face point A
                FlipCharacter(-1);
            }
        }
        else
        {
            // Move back to point A
            transform.position = Vector3.MoveTowards(transform.position, pointA, speed * Time.deltaTime);

            // If the object reaches point A, switch direction
            if (Vector3.Distance(transform.position, pointA) < 0.01f)
            {
                movingToB = true;

                // Flip the character to face point B
                FlipCharacter(1);
            }
        }
    }

    // Flip the character based on direction
    void FlipCharacter(int direction)
    {
        // Flip the character's localScale on the x-axis by multiplying with the direction (-1 or 1)
        Vector3 newScale = originalScale;
        newScale.x = originalScale.x * direction;
        transform.localScale = newScale;
    }
}
