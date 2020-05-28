using UnityEngine.UI;
using UnityEngine;

public class Scor : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
  //  public GameObject ObjectToPickUp;
  
    // Update is called once per frame
    void Update(){
        //condition for change the score
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score = score + 1;
            scoreText.text = score.ToString();
        }
        else {
            //Debug.Log("Estamos mal");
        }

    }
}
