using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    //access rigid bodies
    public Rigidbody2D playerRB2D1;
    public Rigidbody2D playerRB2D2;

    //Movement
    public float moveSpeed;
    private Vector2 player1Location;
    private Vector2 player2Location;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Track player locations
        player1Location = new Vector2(playerRB2D1.position.x, playerRB2D1.position.y);
        player2Location = new Vector2(playerRB2D2.position.x, playerRB2D2.position.y);
    }

    private void FixedUpdate()
    {
        //Player1 Movement
        if (Input.GetKey(KeyCode.A))
        {
            playerRB2D1.transform.position = player1Location + new Vector2(-moveSpeed, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerRB2D1.transform.position = player1Location + new Vector2(moveSpeed, 0);
        }

        //Player2 Movement
        if (Input.GetKey(KeyCode.LeftArrow))
        { 
            playerRB2D2.transform.position = player2Location + new Vector2(-moveSpeed, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRB2D2.transform.position = player2Location + new Vector2(moveSpeed, 0);
        }
    }
}
