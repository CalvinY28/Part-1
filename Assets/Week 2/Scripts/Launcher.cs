using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{


    public GameObject missleprefab;

    public Transform spawn;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(missleprefab, spawn.position, spawn.rotation);
        Debug.Log("qwdwqdpowqkdpoqkdpo");
    }
}
