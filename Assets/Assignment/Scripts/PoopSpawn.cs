using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopSpawn : MonoBehaviour
{
    public GameObject Poop;
    public Transform poopSpawn;
    public float poopSpeed = 10f;
    public float poopTorque = 100f;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject newPoop = Instantiate(Poop, poopSpawn.position, poopSpawn.rotation); // Instantiate through variable

        Rigidbody2D rigidbody = newPoop.GetComponent<Rigidbody2D>();
        if (rigidbody != null) // if rigidbody is not valueless run code -- or if poop is around run the code that gives it force
        {

            Vector2 poopVelocity = Vector2.up * poopSpeed; // variable with stored value to make it shoot up
            rigidbody.velocity = poopVelocity; // make it shoot up
            rigidbody.AddTorque(poopTorque); // make it spin
        }

        GameObject newPoop2 = Instantiate(Poop, poopSpawn.position, poopSpawn.rotation); // Instantiate 2nd poop through variable for funsies

        Rigidbody2D rigidbody2 = newPoop2.GetComponent<Rigidbody2D>();
        if (rigidbody != null)
        {

            Vector2 poopVelocity = Vector2.down * poopSpeed;
            rigidbody2.velocity = poopVelocity;
            rigidbody2.AddTorque(poopTorque);
        }
    }
}
