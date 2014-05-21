using UnityEngine;
using System.Collections;

public class WeaponGUI : MonoBehaviour 
{

    public GameObject ammo;

    public int AmmoCount = 3;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AmmoCount -= 1;
        }



        if (AmmoCount == 6)
        {
            ammo.GetComponent<GUITexture>().texture = Resources.Load("six") as Texture2D;
        }
        else if (AmmoCount == 5)
        {
            ammo.GetComponent<GUITexture>().texture = Resources.Load("five") as Texture2D;
        }
        else if (AmmoCount == 4)
        {
            ammo.GetComponent<GUITexture>().texture = Resources.Load("four") as Texture2D;
        }
        else if (AmmoCount == 3)
        {
            ammo.GetComponent<GUITexture>().texture = Resources.Load("three") as Texture2D;
        }
        else if (AmmoCount == 2)
        {
            ammo.GetComponent<GUITexture>().texture = Resources.Load("two") as Texture2D;
        }
        else if (AmmoCount == 1)
        {
            ammo.GetComponent<GUITexture>().texture = Resources.Load("one") as Texture2D;
        }
        else
        {
            ammo.GetComponent<GUITexture>().texture = Resources.Load("empty") as Texture2D;
        }
        
	
	}
}
