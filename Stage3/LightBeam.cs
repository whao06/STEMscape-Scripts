// To creaate light beam effect

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LightBeam : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Settings")]
    public LayerMask targetLayer;
    public float lightBeamLength;

    private LineRenderer lineRenderer;
    private RaycastHit hit;

    void Start()
    {
        lineRenderer= GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.SetPosition(0, transform.position); // Start from object position

        // Check collision
        if (Physics.Raycast(transform.position, transform.forward, out hit, lightBeamLength, targetLayer)) 
        {
            lineRenderer.SetPosition(1, hit.point);
        }

        else
        {
            lineRenderer.SetPosition(1, transform.position + (transform.forward * lightBeamLength));
        }
    }
}
