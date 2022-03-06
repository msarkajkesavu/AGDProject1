using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{   public int speed;
    private Rigidbody2D rb;
    private Animator anim;
    Vector2 move;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
        //For Animation
        anim.SetFloat("Horizontal",move.x);
        anim.SetFloat("Vertical",move.y);
        anim.SetFloat("Speed",move.sqrMagnitude);
    }
    void FixedUpdate()
    {
      rb.MovePosition(rb.position+move*speed*Time.fixedDeltaTime);   
    }
}
