// Handle normal door interaction with button

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Button_Push_OpenDoor : MonoBehaviour
{
    public Animator animator; // Scripting API | Class -> Inherit from Behaviour
    public string boolName = "Open";
    // Start is called before the first frame update

    // Setup XR based interaction listener -> trigger function
    void Start()
    {
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => toggleDoorOpen());
    }

    public void toggleDoorOpen()
    {
        bool isOpen = animator.GetBool(boolName);
        animator.SetBool(boolName, !isOpen);

        AudioManager.instance.Play("Door_Open"); // To play sfx
    }
}
