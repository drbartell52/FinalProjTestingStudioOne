using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShirtList : MonoBehaviour
{
    public List<Material> shirtColor = new List<Material>();
    public ScenedataSO ScenedataSO;
    
    private GameObject shirt;
    private MeshRenderer my_renderer;
    
    //Amount of shirts in material list
    public int shirtCount;
    void Start()
    {
        //setting "shirt" to this game object
        shirt = this.gameObject;
        shirtCount = shirtColor.Count;
        my_renderer =  shirt.GetComponent<MeshRenderer>();
        my_renderer.material = shirtColor[0];
    }

    public void ChangeShirtColor()
    {
        //
        my_renderer.material = shirtColor[ScenedataSO.sceneSelect];
    }

    private void Update()
    {
       // Debug.Log(shirtSelect);
    }
}
