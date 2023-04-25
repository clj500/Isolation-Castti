using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variables for movement
    private float moveX;
    private float moveY;
    public float moveSpeed;

    public Rigidbody2D rb;

    private Vector2 moveDirection;

    //Variables for detecting boundaries
    public GameObject topRight;
    public GameObject bottomLeft;

    private Vector3 topRightLimit;
    private Vector3 bottomLeftLimit;

    void Start()
    {
        topRightLimit = topRight.transform.position;
        bottomLeftLimit = bottomLeft.transform.position;
    }

    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    void Move()
    {
        if ((transform.position.x <= bottomLeftLimit.x && moveDirection.x == -1) || (transform.position.x >= topRightLimit.x && moveDirection.x == 1))
        {
            moveDirection.x = 0;
        }

        if ((transform.position.y <= bottomLeftLimit.y && moveDirection.y == -1) || (transform.position.y >= topRightLimit.y && moveDirection.y == 1))
        {
            moveDirection.y = 0;
        }

        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}

//Script References
//Player Movement: https://www.youtube.com/watch?v=u8tot-X_RBI
//Detect Boundaries: https://www.youtube.com/watch?v=L6Q0h8VNbGk && https://www.youtube.com/watch?v=QeSUSeYRdDY
