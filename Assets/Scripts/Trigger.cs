using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject prefabToSpawn; // Assign your prefab in the inspector

    void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object is a ball
        if (collision.gameObject.CompareTag("Ball"))
        {
            // Instantiate the prefab at the position of the empty game object
            Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        }
    }
}
