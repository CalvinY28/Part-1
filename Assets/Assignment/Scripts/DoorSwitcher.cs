using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitcher : MonoBehaviour
{
    public GameObject door;
    public float speed = 200f;
    public float stop = 1f;
    private float colliding = 0; // was not sure if boolean true/false was allowed so i use float 0/1
    void Start()
    {
        door.transform.Rotate(0, 0, 0);
    }

    
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            colliding = 1;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
            colliding = 0;
    }

    private void FixedUpdate()
    {
        if (colliding == 1)
        {
            if (door.transform.eulerAngles.z < 90f)
            {
                door.transform.Rotate(0, 0, speed * Time.deltaTime);
            }
        }

        if (colliding == 0) // FAILED ATTEMPT AT STOPPING THE DOOR FROM GOING BACKWARDS!!!! // nvm i got it sorta good enough for now
        {
            if (door.transform.eulerAngles.z > 0f)
            {

                door.transform.rotation = Quaternion.Euler(0, 0, 0); // rotation is current rotation of object -- rotate is rotating it
            }
        }
    }
}
