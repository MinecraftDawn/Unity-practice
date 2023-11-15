using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector = new Vector3(0,0); 
        if (Input.GetKey(KeyCode.UpArrow))
        {
            vector = new Vector3(0, speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            vector = new Vector3(speed,0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            vector = new Vector3(-speed, 0);
        }

        this.gameObject.transform.position += vector;
    }
}
