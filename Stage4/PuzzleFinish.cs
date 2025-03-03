using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleFinish : MonoBehaviour
{
    // Start is called before the first frame update
    public Stage4Socket[] sockets;
    public GameObject gameObjectToActivate;

    // Update is called once per frame
    void Update()
    {
        if(CheckSockets())
        {
            gameObjectToActivate.SetActive(true); // Set puzzle finish trigger zone active
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
