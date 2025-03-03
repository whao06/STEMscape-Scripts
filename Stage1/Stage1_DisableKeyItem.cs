using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1_DisableKeyItem : MonoBehaviour
{
    private bool isInteractable = true;
    private Rigidbody rb;

    // Snap object to socket when enter
    // Freeze position and rotation to prevent grabbing
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Socket") && isInteractable)
        {
            isInteractable = false;
            transform.position = other.transform.position;

            // Freeze the position and rotation to prevent grabbing
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
