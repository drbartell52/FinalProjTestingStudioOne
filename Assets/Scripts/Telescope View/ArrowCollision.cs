using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using UnityEngine;

public class ArrowCollision: MonoBehaviour
{

    public int amountToChange;
    //Getting Shirt List and Shirt Changing script
    public ShirtList shirtObject;
    public AudioSource buttonClick;
    public AudioSource leverSong;
    
    private int firstPlay;

    private void Awake()
    {
        firstPlay = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        //On Trigger adding 1 to the int which selects material from list
        shirtObject.shirtSelect += amountToChange;
        PlayAudio();
        firstPlay = 1;
        //Add logic 
        
        if (shirtObject.shirtSelect < 0)
        {
            Debug.Log("Below Zero!!!!");
            //if the shirt select goes below list amount, cycle back to the top of the list
            shirtObject.shirtSelect = 3;
        }
        else if (shirtObject.shirtSelect >= shirtObject.shirtCount)
        {
             shirtObject.shirtSelect = 0;
        }
        
            //Running function to change shirt color
            shirtObject.ChangeShirtColor();
    }

    private void PlayAudio()
    {
        
        if(firstPlay == 0)
        {
            leverSong.Play();
        }
        else
        {
            buttonClick.Play(); 
        }
       
        
    }
    
}
