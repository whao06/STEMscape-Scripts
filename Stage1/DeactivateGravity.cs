using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateGravity : MonoBehaviour
{
    public Rigidbody rig;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    public void OnLeverDeactivated()
    {
        rig.useGravity = false;  // Disable gravity when lever is deactivated
        AudioManager.instance.Play("Deactivate_Gravity");
    }
}
