using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
    
    void OnCollisionEnter2D(Collision2D other) {
        
        foreach (ContactPoint2D contact in other.contacts)
        {
            // 获取接触点的碰撞物体
            GameObject collidedObject = contact.collider.gameObject;

            // 检查碰撞物体是否是你感兴趣的子物体
            if (collidedObject.CompareTag("PlayerFoot"))
            {
                print("kill");
                Destroy(gameObject);
                break; // 如果找到匹配的子物体，就可以提前结束循环
            }
        }
        // Transform attackChild = other.transform.Find("attack");
        // if (attackChild  && attackChild.gameObject.CompareTag("PlayerFoot"))
        // {
        //     print("kill");
        //     Destroy(gameObject);
        // }
    }
}
