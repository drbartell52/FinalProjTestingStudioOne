using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpin : MonoBehaviour
{
    //Change Rotation Speed Here
    public float rotationSpeed;

    private float rotationConstantSpeed;
    void Update()
    {
        //Spins the spawner
        rotationConstantSpeed = rotationSpeed * Time.deltaTime;
        transform.rotation *= Quaternion.Euler(0,rotationConstantSpeed,0);
    }
}
