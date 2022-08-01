using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotateController : MonoBehaviour
{

    [SerializeField] private float lerpValue;
    public bool playerRightTurn = false;



    void Update()
    {
        if (transform.position.z <= -94)
        {
            transform.rotation = Quaternion.Slerp
           (transform.rotation, Quaternion.Euler(0, 90f, 0), lerpValue * Time.deltaTime);
            playerRightTurn = true;

        }
        if (transform.position.x >= 45)
        {
            transform.rotation = Quaternion.Slerp
           (transform.rotation, Quaternion.Euler(0, 270f, 0), lerpValue * Time.deltaTime);
            playerRightTurn = false;

        }
    }
}
