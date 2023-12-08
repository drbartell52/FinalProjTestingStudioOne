using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapPlacement : MonoBehaviour
{
    //For now, this script is intended to be put on the trigger that is placed where you want the object to go while the
    //grabbed building is within the trigger, the user can press a button to snap the building into it's final location
    
    //Location the object snaps to
    public Transform objectPlacement;
    [SerializeField]private int heightDif;

    //Assign other object with life capacity script to this in editor (one-way dependency)
    public LifeCapacity lifeCapacity;

    private void OnTriggerStay(Collider other)
    {
        
        //Jump should/will be changed to input on Oculus controller
        // if (Input.GetButtonDown("Jump"))
        // {
            //Add tag "Building" To the grabbable building objects
            if (other.CompareTag("Building"))
            {
                //Stops buildings from flying away after placement (if gravity is turned off in rigidbody)
                other.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                
                //Sets placement of the grabbed building to the location chosen, height is determined by dividing
                //building scale by 2, heightDif is the height of the selection circle
                other.transform.position = new Vector3(objectPlacement.position.x,
                    (other.transform.lossyScale.y/2) + heightDif, objectPlacement.position.z);

                other.transform.rotation = new Quaternion(0, 0, 0, 0);
                
                //Calls function from the LifeCapacity script to increase max capacity by 50
                lifeCapacity.IncreaseCapacity();
            }  
        // }
    }

    private void Start()
    {
        heightDif = Mathf.RoundToInt(transform.position.y);
    }
    
}
