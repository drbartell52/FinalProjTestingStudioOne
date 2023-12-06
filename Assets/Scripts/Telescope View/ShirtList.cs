using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ShirtList : MonoBehaviour
{
    [FormerlySerializedAs("shirtColor")] public List<Material> sceneMaterial = new List<Material>();
    public ScenedataSO ScenedataSO;
    
    private GameObject shirt;
    private MeshRenderer my_renderer;
    
    //Amount of shirts in material list
    [FormerlySerializedAs("shirtCount")] public int sceneCount;
    void Start()
    {
        //setting "shirt" to this game object
        shirt = gameObject;
        ScenedataSO.sceneCount = sceneMaterial.Count;
        my_renderer =  shirt.GetComponent<MeshRenderer>();
        ScenedataSO.sceneSelect = 0;
    }

    public void ChangeShirtColor()
    {
        //
        my_renderer.material = sceneMaterial[ScenedataSO.sceneSelect];
    }

    private void Update()
    {
        ChangeShirtColor();
    }
}
