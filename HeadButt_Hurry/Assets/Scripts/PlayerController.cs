using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    public bool canJump;
    public float jumpSpeed = 10f;
    private Rigidbody2D player;
    public UnityEvent loseGame;
    private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;
    public Vector2 playerStartPos;

    private void Awake() 
    {
        playerStartPos = transform.position;
    }
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
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;

            if(endTouchPosition.y > startTouchPosition.y)
            {
                    Jump();
                
            }
        }
        
    }

    void Jump()
    {
        if(player.velocity.y > -1 && player.velocity.y <= 0)
            {
                player.velocity = new Vector2(player.velocity.x, jumpSpeed);
                //canJump = false;
            }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("DeathFloor"))
        {
            transform.position = playerStartPos;
            loseGame.Invoke();
            Debug.Log("Loser");
        }
        if(other.CompareTag("Floor"))
        {
            canJump = true;
        }
        
    }
}
