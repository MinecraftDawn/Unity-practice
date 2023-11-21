using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float speed_x = 0.02f;
    public float speed_y = 0.1f;
    public float max_speed_x = 1f;
    public float max_speed_y = 1f;
    public bool isOnFloor = false;
    Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector = new Vector3(0,0); 
        if (Input.GetKey(KeyCode.UpArrow) && isOnFloor)
        {
            this.rigidbody.AddForce(new Vector2(0, speed_y), ForceMode2D.Impulse);
            if (rigidbody.velocity.y > max_speed_y) rigidbody.velocity = new Vector2(rigidbody.velocity.x, max_speed_y);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.rigidbody.AddForce(new Vector2(speed_x, 0), ForceMode2D.Impulse);
            if (rigidbody.velocity.x > max_speed_x) rigidbody.velocity = new Vector2(max_speed_x, rigidbody.velocity.y);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.rigidbody.AddForce(new Vector2(-speed_x, 0), ForceMode2D.Impulse);
            if (rigidbody.velocity.x < -max_speed_x) rigidbody.velocity = new Vector2(-max_speed_x, rigidbody.velocity.y);
        }
        

        
    }


    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isOnFloor = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isOnFloor = false;
        }
    }
}
