using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class ParaCord : MonoBehaviour
{

    public Transform endPointTop, endPointBottom;

    private LineRenderer lineRenderer;
    void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    public void CreateString()
    {
        Vector3[] linePoints = new Vector3[2];
        linePoints[0] = endPointTop.localPosition;
        linePoints[1] = endPointBottom.localPosition;
        lineRenderer.positionCount = linePoints.Length;
        lineRenderer.SetPositions(linePoints);
    }

    private void Start()
    {
        CreateString();
    }

    private void Update()
    {
        CreateString();
    }
}
