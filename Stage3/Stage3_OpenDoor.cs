using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3_OpenDoor : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator doorAnimator;
    private bool isDoorOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LightBeam"))
        {
            if(!isDoorOpen)
            {
                doorAnimator.SetBool("Open", true);
                isDoorOpen = true;
                AudioManager.instance.Play("Door_Open_Mathemathics");
            }   
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("LightBeam"))
        {
            if (isDoorOpen)
            {
                doorAnimator.SetBool("Open", false);
                isDoorOpen = false;
                AudioManager.instance.Play("Door_Open_Mathemathics");
            }
        }
    }
}
