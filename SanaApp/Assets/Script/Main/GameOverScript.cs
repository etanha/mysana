using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{

    public GameObject GameOverImage;

    float timeLeft = 10.0f;

    string message = "Game over";

    bool displayMessage = false;
    void Start()
    {

        GameOverImage.SetActive(false);
    }


    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            Debug.Log(message);
            displayMessage = true;
            //   GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200f, 200f), message);
            //  GameOver();

        }
    }




    void OnGUI()
    {
        if (displayMessage)
        {
            GameOverImage.SetActive(true);
            Debug.Log("ongui");
            //  WaitUnhide();
        //    GameOver();
            // GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200f, 200f), message);
        }
    }
   
    IEnumerator WaitUnhide()
    {


        yield return (new WaitForSeconds(4));
        Debug.Log("WaitUnhideafter4");


        Debug.Log("WaitUnhide");
        GameOverImage.SetActive(true);
    }
}
