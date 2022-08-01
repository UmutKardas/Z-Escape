using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGoingHelicopterController : MonoBehaviour
{

    [SerializeField] private PlayerMovementController playerMovementController;
    [SerializeField] private Rigidbody playerRigidbody;
    [SerializeField] private float movementSpeed;
    [SerializeField] private Vector3 targetPosisition;


    public void SetGoingHelicopter()
    {
        playerMovementController.enabled = false;
        playerRigidbody.AddForce(targetPosisition * movementSpeed * Time.fixedDeltaTime);
    }
}
