using UnityEngine;

public class DoorCheck : MonoBehaviour
{
    public Stage4Socket[] sockets;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (CheckSockets())
        {
            animator.SetTrigger("Open");
        }
    }

    private bool CheckSockets()
    {
        foreach (Stage4Socket socket in sockets)
        {
            if (!socket.IsCorrect())
            {
                return false;
            }
        }
        return true;
    }
}
