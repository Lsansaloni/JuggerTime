﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class corredor : MonoBehaviour
{
    public Transform jugg;
    private NavMeshAgent agent;
    
    public Transform localGoal;
    public Transform visitorGoal;


    //Piking 
    public GameObject ObjectToPickUp;
    public GameObject picketObject;
    public Transform interactionZone;
   

    // Start is called before the first frame update
    void Start()
    {
        jugg = GameObject.FindGameObjectWithTag("Jugg").transform;
        agent = GetComponent<NavMeshAgent>();
        localGoal = GameObject.FindGameObjectWithTag("LocalGoal").transform;
        visitorGoal = GameObject.FindGameObjectWithTag("VisitorGoal").transform;

    }

    // Update is called once per frame
    void Update()
    {
        Ia(agent);
        Picking();

    }

    public void Ia(NavMeshAgent agent) {
      

        if (picketObject == null)
        {
            agent.destination = jugg.position;
         }
        else if (picketObject == true)
        {
            agent.destination = visitorGoal.position;
        }
    }

       
    public void Picking()
    {
      
        if (ObjectToPickUp != null && ObjectToPickUp.GetComponent<jugg>().isPickable == true && picketObject == null)
        {
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

        }
        else if (picketObject != null)
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
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
