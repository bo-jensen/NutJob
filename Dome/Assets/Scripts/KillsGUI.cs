using UnityEngine;
using System.Collections;

public class KillsGUI : MonoBehaviour 
{

    public float Kills = 0;
    private float tempKillVal = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddKill();
        }

        guiText.text = "Kills :" + " " + Kills;
	}

    void AddKill()
    {
        Kills += tempKillVal;

    }
}
