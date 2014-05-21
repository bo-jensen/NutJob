using UnityEngine;
using System.Collections;

public class ScoreGUI : MonoBehaviour 
{

    public float Score = 0;
    private float tempScoreVal = 25;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddScore();
        }

        guiText.text = "Score :" + " " + Score;
    }

    void AddScore()
    {
        Score += tempScoreVal;

    }
}
