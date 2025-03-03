// Check object entered has light beam tag -> (yes) -> activate another light beam

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class SpaceOutsideController : MonoBehaviour
{
    // Start is called before the first frame update
    public XRLever lever;
    public XRKnob knob;

    public float forwardSpeed;
    public float sideSpeed;

    private bool isOn;

    // Update is called once per frame
    void Update()
    {
        float forwardVelocity = forwardSpeed * (lever.value ? 1 : 0); // To detect if the lever is turned on
        float sideVelocity = sideSpeed * (lever.value ? 1 : 0) * Mathf.Lerp(-1, 1, knob.value); // To correctly turn left or right

        Vector3 velocity = new Vector3(sideVelocity, 0, forwardVelocity); // (X, Y, Z)
        transform.position += velocity * Time.deltaTime;

        if(lever.value != isOn) 
        {
            if (lever.value)
            {
                AudioManager.instance.Play("Ship_Engine");
            }
            else
            {
                AudioManager.instance.Stop("Ship_Engine");
            }
        }

        isOn = lever.value;
    }
}
