// Handle breakable objects into pieces

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    // Start is called before the first frame update

    public List<GameObject> breakablePieces;
    public float timeToBreak = 2;
    private float timer = 0;
    void Start()
    {
        foreach (var item in breakablePieces)
        {
            item.SetActive(false);
        }
    }

    public void Break()
    {
        timer += Time.deltaTime;

        if (timer > timeToBreak )
        {
            foreach (var item in breakablePieces)
            {
                item.SetActive(true);
                item.transform.parent = null; // Detach from parent object
            }

            gameObject.SetActive(false);
        }
    }
}
