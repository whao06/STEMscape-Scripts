// Handle rotation of objects with button

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Button_Push_RotateObjects : MonoBehaviour
{
    public GameObject[] objectsToRotate; 
    public string[] audioClipNames;
    private bool isRotating = false;
    private int rotationIndex = 0;
    

    // Button press -> rotate objects along y-axis sequentially -> play audio
    void Start()
    {
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => RotateObjectsBy90Degrees());
    }

    public void RotateObjectsBy90Degrees()
    {
        StartAudioSequence();

        if (!isRotating) // Check rotation status first -> avoid multiple rotations
        {
            StartCoroutine(RotateCoroutine());
        }
    }

    // Quaternion -> q= w+ xi+ yj+ zk

    IEnumerator RotateCoroutine() // Coroutine use here to handle rotation animation
    {
        isRotating = true;

        while (rotationIndex < objectsToRotate.Length)
        {
            // Check rotation status from disable rotation script (if blocked -> disable rotation)
            if (objectsToRotate[rotationIndex].GetComponent<DisableRotation>().CanRotate)  
            {

                Quaternion startRotation = objectsToRotate[rotationIndex].transform.rotation; 
                Quaternion endRotation = objectsToRotate[rotationIndex].transform.rotation * Quaternion.Euler(0, 90, 0); // (X, Y, Z)

                // Try to smooth animation with following code
                float t = 0;
                float rotationDuration = 1.0f; // Try and error might change ltr
                while (t < 1)
                {
                    t += Time.deltaTime / rotationDuration;
                    // Decide to use Slerp instead of Lerp for smoother rotation
                    objectsToRotate[rotationIndex].transform.rotation = Quaternion.Slerp(startRotation, endRotation, t);
                    yield return null;
                }
            }

            rotationIndex++;
            PlayNextAudio();
            yield return new WaitForSeconds(1.0f);
        }

        rotationIndex = 0; // Reset rotation index for future use
        isRotating = false;
    }

    private void StartAudioSequence()
    {
        PlayNextAudio();
    }

    private void PlayNextAudio()
    {
        if (rotationIndex < audioClipNames.Length)
        {
            AudioManager.instance.Play(audioClipNames[rotationIndex]);
        }
    }
}
