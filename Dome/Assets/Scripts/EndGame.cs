using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {

    public bool restartGame = false;
    public bool startMenu = false;
    public bool isQuit = false;

    void OnMouseEnter()
    {
        renderer.material.color = Color.red;
    }

    void OnMouseExit()
    {
        renderer.material.color = Color.white;
    }

    void OnMouseDown()
    {
        if (isQuit)
        {
            Application.Quit();
        }

        if (startMenu) 
        {
            Application.LoadLevel(0);
        }

        if (restartGame)
        {
            Application.LoadLevel(1);
        }
    }

   

}
