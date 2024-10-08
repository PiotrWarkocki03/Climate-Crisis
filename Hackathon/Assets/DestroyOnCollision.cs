using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    // Tag for the player, you can set this from the Unity Editor
    public string playerTag = "Player";

    // This function gets called when another collider enters the object's trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger has the tag "Player"
        if (other.CompareTag(playerTag))
        {
            // Destroy the game object this script is attached to
            Destroy(gameObject);
        }
    }
}
