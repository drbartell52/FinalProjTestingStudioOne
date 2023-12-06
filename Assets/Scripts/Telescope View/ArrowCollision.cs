using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class ArrowCollision: MonoBehaviour
{

    public int amountToChange;
    //Getting Shirt List and Shirt Changing script
    public ShirtList shirtObject;
    [FormerlySerializedAs("ScenedataSo")] public ScenedataSO ScenedataSO;
    

    private void OnTriggerEnter(Collider other)
    {
        //On Trigger adding 1 to the int which selects material from list
         ScenedataSO.sceneSelect += amountToChange;
        //Add logic 
        
        if (ScenedataSO.sceneSelect< 0)
        {
            Debug.Log("Below Zero!!!!");
            //if the shirt select goes below list amount, cycle back to the top of the list
            ScenedataSO.sceneSelect = ScenedataSO.sceneCount;
        }
        else if (ScenedataSO.sceneSelect >= ScenedataSO.sceneCount)
        {
            ScenedataSO.sceneSelect = 0;
        }
        
            //Running function to change shirt color
            shirtObject.ChangeShirtColor();
    }

    // private void PlayAudio()
    // {
    //     
    //     if(firstPlay == 0)
    //     {
    //         leverSong.Play();
    //     }
    //     else
    //     {
    //         buttonClick.Play(); 
    //     }
    //    
    //     
    // }
    
}
