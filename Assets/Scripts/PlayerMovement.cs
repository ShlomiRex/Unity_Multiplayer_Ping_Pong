using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerMovement : NetworkBehaviour
{
    private Rigidbody2D rb;
    //public float force = 50;
    public float deltePos = 0.08f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if(isLocalPlayer)
        { 
            float x = rb.position.x;
            float y = rb.position.y;
            if (Input.GetKey("w"))
            {
                //rb.AddForce(new Vector2(0, force * Time.deltaTime));

                rb.MovePosition(new Vector2(x, y + deltePos));
            }
            if (Input.GetKey("s"))
            {
                //rb.AddForce(new Vector2(0, -force * Time.deltaTime));
            
                rb.MovePosition(new Vector2(x, y - deltePos));
            }
        }
    }
}
