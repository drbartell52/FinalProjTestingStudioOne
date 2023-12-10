using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialLERP : MonoBehaviour
{
    [Range(0, 1)] 
    public float t;

    public Material matA;
    public Material matB;

    public AnimationCurve ease;

    private MeshRenderer _meshRenderer;

    private int sign = 1;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();

        sign = 1;
    }

    // Update is called once per frame
    void Update()
    {
        t = t + sign * Time.deltaTime;

        if (t > 1)
        {
            sign = -1;
        }
        else if (t < 0)
        {
            sign = 1;
        }
        
        _meshRenderer.material.Lerp(matA, matB, ease.Evaluate(t));
    }
}
