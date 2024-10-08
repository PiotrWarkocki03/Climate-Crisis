using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    private HashSet<string> collection = new HashSet<string>(); // Collection of unique items
    public Timer timerManager; // Reference to the Timer manager

    // This method is called when the object enters a trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object has the tag "Berries"
        if (other.tag == "Berries")
        {
            CollectionItem(other.gameObject); // Collect the item
            
        }

        // Check if the object has the tag "Bush"
        if (other.CompareTag("Bush"))
        {
            Destroy(other.gameObject); // Destroy the bush object
            Debug.Log("Destroyed a Bush");
        }
    }

    // Method to collect the item
    public void CollectionItem(GameObject obj)
    {
        string itemName = obj.name;

        // Check if the item is already collected
        if (!collection.Contains(itemName))
        {
            collection.Add(itemName); // Add the item to the collection
            Debug.Log($"Collected: {itemName}");

            Destroy(obj); 

            // Add time to the timer manager
            if (timerManager != null) // Ensure timerManager is assigned
            {
                timerManager.AddTime(5f);
            }
        }
        else
        {
            Debug.Log($"Already collected: {itemName}"); // Item already collected
        }
    }

    // Method to display all collected items
    public void DisplayCollectedItems()
    {
        foreach (var item in collection)
        {
            Debug.Log($"Collected Item: {item}");
        }
    }
}
