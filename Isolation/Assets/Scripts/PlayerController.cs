using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotationSpeed;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private BoxCollider2D bc;

    // Reference to the player animator
    public Animator animator;
    // reference to animator parameters
    public string speed = "Speed";
    public string attacking = "Attacking";


    private bool isAttacking = false;

    private float attackDuration = 0.75f;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Code for Attack
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
        if (isAttacking)
        {
            timer += Time.deltaTime;

            if (timer >= attackDuration)
            {
                timer = 0;
                isAttacking = false;
                animator.SetBool(attacking, isAttacking);
            }
        }

        // Code for Movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


        Vector2 moveDirection = new Vector2(horizontalInput, verticalInput);
        float inputMagnitude = Mathf.Clamp01(moveDirection.magnitude);
        moveDirection.Normalize();

        animator.SetFloat(speed, Mathf.Abs(inputMagnitude));     // Set animation speed parameter when moving
        
        transform.Translate(moveDirection * moveSpeed * inputMagnitude * Time.deltaTime, Space.World);

        // For rotating toward movement direction
        if (moveDirection != Vector2.zero)
        {
            Quaternion toRotate = Quaternion.LookRotation(Vector3.forward, moveDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotate, rotationSpeed * Time.deltaTime);
        }

    }

    // Method to attack
    private void Attack()
    {
        isAttacking = true;
        animator.SetBool(attacking, isAttacking);
    }

}
