using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    Rigidbody2D rigidbody; // reference Rigidbody to move
    float acceleration;
    float steering;
    public float forwardSpeed = 300;
    public float steeringSpeed = 30;
    public float maxSpeed = 250;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        acceleration = Input.GetAxis("Vertical");
        steering = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate() // FOR MOVEING RIGIDBODYS
    {
        rigidbody.AddTorque(steering * -steeringSpeed * Time.deltaTime);
        Vector2 force = transform.up * acceleration * forwardSpeed * Time.deltaTime; // vector movmeent scale speed
        if (rigidbody.velocity.magnitude < maxSpeed) {
            rigidbody.AddForce(force); // Check
        }
    }

}
