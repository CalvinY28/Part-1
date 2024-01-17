using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector2 direction;
    public Rigidbody2D myrigidbody;
    public float speed = 10f;

    // Start is called before the first frame update
    private void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        Vector2 force = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed * Time.deltaTime;
        myrigidbody.AddForce(direction * force * Time.deltaTime);
    }
}
