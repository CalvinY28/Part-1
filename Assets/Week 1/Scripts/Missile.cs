using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float missleSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(missleSpeed * Time.deltaTime, 0, 0);
        // use rigid body move positon not transform.translate (eg. rigidbody.Moveposition(rigidbody.positon + new vector * time.delttime;)) and use vectors
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

}
