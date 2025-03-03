using UnityEngine;

public class Socket : MonoBehaviour
{
    public Animator doorAnimator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Energy"))
        {
            doorAnimator.SetTrigger("Open");
            AudioManager.instance.Play("Door_Open_Technology");
            // Open the door using your specific door opening logic
        }
    }
}
