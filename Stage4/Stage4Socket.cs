using UnityEngine;

public class Stage4Socket : MonoBehaviour
{
    public int targetValue;
    private bool isCorrect;

    public bool IsCorrect()
    {
        return isCorrect;
    }

    public void CheckEnergyCube(EnergyCubeReturnValue energyCube)
    {
        if (energyCube.energyValue == targetValue)
        {
            isCorrect = true;
        }
        else
        {
            isCorrect = false;
        }
    }
}
