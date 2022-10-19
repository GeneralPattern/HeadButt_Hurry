using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpSpeed = 10f;
    private Rigidbody2D player;

    void Start() 
    {
        player = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        player.velocity = new Vector2(player.velocity.x, jumpSpeed);
    }
}
