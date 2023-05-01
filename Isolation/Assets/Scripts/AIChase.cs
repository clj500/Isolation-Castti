using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIChase : MonoBehaviour
{
    public GameObject player;
    public float speed;

    Animator animator;

    private float distance;

    //Variables for detecting boundaries
    public GameObject topRight;
    public GameObject bottomLeft;

    private Vector3 topRightLimit;
    private Vector3 bottomLeftLimit;

    // Start is called before the first frame update
    void Start()
    {
        topRightLimit = topRight.transform.position;
        bottomLeftLimit = bottomLeft.transform.position;

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        bool move = false;

        if(distance < 5)
        {
            move = true;
            animator.SetBool("Moving", move);
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
        else
        {
            move = false;
            animator.SetBool("Moving", move);
        }
    }
}

//Script Reference: https://www.youtube.com/watch?v=2SXa10ILJms