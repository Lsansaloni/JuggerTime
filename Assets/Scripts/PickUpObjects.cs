using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObjects : MonoBehaviour
{
    public GameObject ObjectToPickUp;
    public GameObject picketObject;
    public Transform interactionZone;
   
    
    // Update is called once per frame
    void Update(){
        if (ObjectToPickUp != null && ObjectToPickUp.GetComponent<jugg>().isPickable == true && picketObject == null ){
            if (ObjectToPickUp.GetComponent<jugg>().isPickable == true)
            {
                Debug.Log("lo cojo loco");
                picketObject = ObjectToPickUp;
                picketObject.GetComponent<jugg>().isPickable = false;
                picketObject.transform.SetParent(interactionZone);
                picketObject.transform.position = interactionZone.position;
                picketObject.GetComponent<Rigidbody>().useGravity = false;
                picketObject.GetComponent<Rigidbody>().isKinematic = true;         
                
            }

        }else if (picketObject != null)
        {
            if (Input.GetKeyDown(KeyCode.G)){
                Debug.Log("suelto loco");
                picketObject.GetComponent<jugg>().isPickable = true;
                picketObject.transform.SetParent(null);
                picketObject.GetComponent<Rigidbody>().useGravity = true;
                picketObject.GetComponent<Rigidbody>().isKinematic = false;
                picketObject = null;

            }
        }
        
    }
}
