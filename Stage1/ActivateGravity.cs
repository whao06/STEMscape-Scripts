// Handle gravity activation

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGravity : MonoBehaviour
{
    public Rigidbody rig;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    public void OnLeverActivated()
    {
        rig.useGravity = true;  // Enable gravity when lever is activated
        AudioManager.instance.Play("Activate_Gravity"); // Play sfx
    }
}
