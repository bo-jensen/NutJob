using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour 
{
    public bool isQuit = false;
    public bool isCredits = false;
    public bool isHighScore = false;
    public bool isPlay = false;

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
        else if (isCredits)
        {
            Application.LoadLevel(2);
        }

        else if (isHighScore)
        {
            Application.LoadLevel(3);
        }

        else if(isPlay)
        {
            Application.LoadLevel(1);
        }
    }
}
