using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShirtColor : MonoBehaviour
{
    public GameObject shirtObject;
    public Material materialTest;
    public MeshRenderer my_renderer;
    void Start()
    {
        my_renderer =  shirtObject.GetComponent<MeshRenderer>();
    }
    public static void ChangeColor()
    {
        
    }
    void Update()
    {
    }
}
