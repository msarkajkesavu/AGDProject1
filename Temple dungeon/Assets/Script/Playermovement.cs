using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{   public int speed;
    private Rigidbody2D rb;

    Vector2 move;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
      rb.MovePosition(rb.position+move*speed*Time.fixedDeltaTime);   
    }
}
