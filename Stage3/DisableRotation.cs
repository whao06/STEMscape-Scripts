using UnityEngine;

public class DisableRotation : MonoBehaviour
{
    public bool CanRotate = true; // Default state is rotatable

    private Rigidbody rb;

    // Cache rigidbody component for optimization reason
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Blocker"))
        {
            CanRotate = false;
            rb.constraints = RigidbodyConstraints.FreezeRotation;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Blocker"))
        {
            CanRotate = true;
            rb.constraints &= ~RigidbodyConstraints.FreezeRotation;
        }
    }
}