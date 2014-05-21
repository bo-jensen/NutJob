using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour
{

    public Transform target;
    public Transform spawn;
   

    public float speed = 1;

    // Use this for initialization
    void Start()
    {
        transform.position = spawn.position;
        //Instantiate(this.transform.gameObject);

    }

    // Update is called once per frame
    void Update()
    {
       
        move();
        remove();
    }

    public void move()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        transform.LookAt(target);
    }

    public void remove()
    {
        if (transform.position == target.position)
        {
            GameObject clone = Instantiate(this.transform.gameObject) as GameObject;
           GameObject.DestroyImmediate(clone);

            Start();

        }
    }

}
