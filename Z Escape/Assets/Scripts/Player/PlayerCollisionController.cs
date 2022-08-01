using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionController : MonoBehaviour
{

    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    [SerializeField] private GameObject hutDoor;
    [SerializeField] private GameObject hitİnEnemy;
    [SerializeField] private GameObject gameover;
    [SerializeField] private GameObject soGood;
    [SerializeField] private GameObject restartButton;
    [SerializeField] private GameObject crosshair;
    [SerializeField] private GameObject gun;
    [SerializeField] private Animator cameraAnimator;


    private void Start()
    {
        Time.timeScale = 1;
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            gameover.SetActive(true);
            restartButton.SetActive(true);
            crosshair.SetActive(false);
            Time.timeScale = 0;
        }


        if (other.gameObject.CompareTag("Helicopter"))
        {
            Time.timeScale = 0;
            soGood.SetActive(true);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Door"))
        {
            hutDoor.SetActive(false);
            hitİnEnemy.SetActive(true);

        }


        if (other.gameObject.CompareTag("Helipad"))
        {
            cameraAnimator.Play("AdditionalCamera");
            gun.SetActive(false);
            crosshair.SetActive(false);
            playerDataTransmitter.SetGoingHelicopter();

        }
    }


    public void RestartButton()
    {
        SceneManager.LoadScene(0);
    }
}
