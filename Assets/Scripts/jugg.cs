using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugg : MonoBehaviour
{
    public bool isPickable = true;
    
    private void OnTriggerEnter(Collider other)
    {
      
        if (other.tag == "prueba")
        {
                       other.GetComponentInParent<corredor>().ObjectToPickUp = this.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Jugg"){
            //other.GetComponentInParent<jugg>()

               
        }
    }
}
