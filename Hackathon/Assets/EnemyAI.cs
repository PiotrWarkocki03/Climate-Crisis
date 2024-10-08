using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player; // Reference to the player
    public float speed = 3.0f; // Speed of the enemy
    public float chaseDistance = 10.0f; // Distance at which the enemy will start chasing

    private void Update()
    {
        // Check the distance to the player
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // If the player is within the chase distance
        if (distanceToPlayer < chaseDistance)
        {
            // Calculate direction to the player
            Vector3 direction = (player.position - transform.position).normalized;
            // Move the enemy towards the player
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}