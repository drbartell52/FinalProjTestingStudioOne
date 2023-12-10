using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingMovement : MonoBehaviour
{
    public float turnSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.forward, -turnSpeed * Time.deltaTime / 20f);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime / 20f);

    }
}
