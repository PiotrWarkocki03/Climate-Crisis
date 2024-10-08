using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class RestartOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object has the tag "Enemy"
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Restart the current scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (collision.gameObject.CompareTag("End"))
        { 
            SceneManager.LoadScene("NextScene");
        }
        else if (collision.gameObject.CompareTag("Fire"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
