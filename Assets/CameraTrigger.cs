using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{

    public Transform myCameraTransform; 
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            Camera.main.transform.position = myCameraTransform.transform.position; 
            Camera.main.transform.rotation = myCameraTransform.transform.rotation; 

        }
    }

}
