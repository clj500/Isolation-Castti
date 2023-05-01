using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoundaries : MonoBehaviour
{
    public GameObject topRight;
    public GameObject bottomLeft;

    private Vector3 topRightLimit;
    private Vector3 bottomLeftLimit;

    void Start()
    {
        topRightLimit = topRight.transform.position;
        bottomLeftLimit = bottomLeft.transform.position;
    }


}

//Reference Code: https://www.youtube.com/watch?v=L6Q0h8VNbGk