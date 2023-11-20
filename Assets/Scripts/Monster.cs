using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{

    public Player player;

    public float speed = 0.001f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x > transform.position.x)  
            transform.position = new Vector3(transform.position.x+speed, transform.position.y,transform.position.z);
        else transform.position = new Vector3(transform.position.x-speed, transform.position.y,transform.position.z);
        
    }
}
