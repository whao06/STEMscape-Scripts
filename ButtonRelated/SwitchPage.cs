using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ToggleObjectsButton : MonoBehaviour
{
    public GameObject[] gameObjects;
    private int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => ToggleObjects());
    }

    public void ToggleObjects()
    {

        gameObjects[currentIndex].SetActive(false);

        // Loop thru pages and go back if reach end
        currentIndex = (currentIndex + 1) % gameObjects.Length;


        gameObjects[currentIndex].SetActive(true);
    }
}
