using UnityEngine;
using System.Collections;

public class TimerGUI : MonoBehaviour 
{
    public float timeInSeconds = 5.0f;
    
    
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        CountDown();

        if (timeInSeconds <= 0)
        {
            Application.LoadLevel(4);
        }
        
	
	}

    void CountDown()
    {
        guiText.text = "Fiskemand :" + " " + timeInSeconds.ToString();
        timeInSeconds -= Time.deltaTime;
    }

}
