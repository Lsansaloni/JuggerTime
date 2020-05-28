using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class corredor : MonoBehaviour
{
    public Transform jugg;
    private NavMeshAgent agent;
    //public float speedMov = 5f;
    //public int posesion = 0;  

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
             
    }

    // Update is called once per frame
    void Update()
    {
         agent.destination= jugg.position;
    
    }

   
     
}
