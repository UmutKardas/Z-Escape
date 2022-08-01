using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{

    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    [SerializeField] private Rigidbody playerRigidbody;
    [SerializeField] private float movementSpeed;


    void FixedUpdate()
    {
        SetPlayerMovement();
    }


    private void SetPlayerMovement()
    {

        if (playerDataTransmitter.SetPlayerRightTurn())
        {
            playerRigidbody.velocity = Vector3.right * movementSpeed * Time.fixedDeltaTime;

        }
        else
        {
            playerRigidbody.velocity = Vector3.back * movementSpeed * Time.fixedDeltaTime;
        }
    }
}
