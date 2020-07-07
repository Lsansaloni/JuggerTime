using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GeneralController: MonoBehaviour
{

    public GameObject spawnLocalTeam;
    public GameObject spawnVisitorTeam;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
              PutPlayers();
        }
    }

    public void PutPlayers()
    {
        //LocalTeam(red)
        for (int i = 0; i < spawnLocalTeam.transform.childCount; i++)
           {
            Debug.Log(spawnLocalTeam.transform.GetChild(i).name);
            Instantiate(player, spawnLocalTeam.transform.GetChild(i).transform.position, spawnLocalTeam.transform.GetChild(i).transform.rotation);
                                 
        }
        //VisitorTeam(blue)
        for (int i = 0; i < spawnVisitorTeam.transform.childCount; i++)
           {
            Debug.Log(spawnVisitorTeam.transform.GetChild(i).name);
            var jugador = Instantiate(player, spawnVisitorTeam.transform.GetChild(i).transform.position, spawnVisitorTeam.transform.GetChild(i).transform.rotation);
            jugador.GetComponent<Renderer>().material.color = Color.blue;
        }
       
    }
}
