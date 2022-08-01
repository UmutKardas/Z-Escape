using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataTransmitter : MonoBehaviour
{

    [SerializeField] private PlayerRotateController playerRotateController;
    [SerializeField] private PlayerGoingHelicopterController playerGoingHelicopterController;


    public bool SetPlayerRightTurn()
    {
        return playerRotateController.playerRightTurn;
    }


    public void SetGoingHelicopter()
    {
        playerGoingHelicopterController.SetGoingHelicopter();
    }


}
