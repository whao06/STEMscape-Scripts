using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyCubeInteractor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        EnergyCubeReturnValue energyCube = other.GetComponent<EnergyCubeReturnValue>();
        if (energyCube != null)
        {
            Stage4Socket socket = GetComponent<Stage4Socket>();
            socket.CheckEnergyCube(energyCube);
        }
    }
}
