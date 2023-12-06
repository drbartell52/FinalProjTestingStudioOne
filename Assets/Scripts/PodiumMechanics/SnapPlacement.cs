using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapPlacement : MonoBehaviour
{
    public Transform objectPlacement;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (other.CompareTag("Building"))
            {
                other.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                //other.transform.position = objectPlacement.position;
                other.transform.position = new Vector3(objectPlacement.position.x,
                    (other.transform.lossyScale.y/2) + 6, objectPlacement.position.z);
                Debug.Log("Placement!");
            }  
        }
    }
}
