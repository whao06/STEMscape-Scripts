using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public GameObject objectToActivate;
    
    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering collider is the cylinder game object
        if (other.gameObject.CompareTag("LightBeam"))
        {
            objectToActivate.SetActive(true); 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the exiting collider is the cylinder game object
        if (other.gameObject.CompareTag("LightBeam"))
        {
            objectToActivate.SetActive(false);
        }
    }
}
    