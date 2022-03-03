using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simpleinput : MonoBehaviour
{   private Rigidbody rb;
    public int force;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Vertical")*force;

        rb.AddForce(x*Time.deltaTime,0,0);
    }
}
