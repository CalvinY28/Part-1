using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector2 direction;
    public Rigidbody2D myrigidbody;
    public float force = 10f;

    // Start is called before the first frame update
    private void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        myrigidbody.AddForce(direction * force * Time.deltaTime);
    }
}
