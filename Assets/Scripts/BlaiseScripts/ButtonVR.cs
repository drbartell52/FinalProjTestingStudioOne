using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    AudioSource buttonclick;
    bool isPressed;
    public GameObject ceiling;
    public float turnSpeed = 50f;
    void Start()
    {
        buttonclick = GetComponent<AudioSource>();
        isPressed = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (isPressed)
        {
            button.transform.localPosition = new Vector3(0, 0.003f, 0);
            presser = other.gameObject;
            onPress.Invoke();
            buttonclick.Play();
            isPressed = true;
            
        }
         


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == presser)
        {
            button.transform.localPosition = new Vector3(0, 0.015f, 0);
            onRelease.Invoke();
            isPressed = false;
        }
    }
    public void RotateLeft()
    {
        ceiling.transform.Rotate(Vector3.forward, -turnSpeed * Time.deltaTime / 20f);
    }
    

   
}
