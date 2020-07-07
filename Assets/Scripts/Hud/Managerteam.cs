using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class Managerteam : MonoBehaviour { 

    public Dropdown myDropdown;

    // Start is called before the first frame update
    void Start()
    {
        CreateText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
    void CreateText()
    {
        string path = Application.dataPath + "/Scripts/jugadores.txt.txt";
       // Debug.Log(path + " /hola" );

        string[] lines = File.ReadAllLines(path);
        List<string> names = new List<string>();
        myDropdown.options.Clear();

        foreach (string line in lines)
        {
            names.Add(line);
            
        }

        myDropdown.AddOptions(names);

    }
}
