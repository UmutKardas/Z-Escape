using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementController : MonoBehaviour
{

    [SerializeField] private GameObject playerGameobject;
    public float movementSpeed;
    private Vector3 enemyVectorPosition;


    private void Start()
    {
        playerGameobject = GameObject.FindGameObjectWithTag("Player");
    }


    void Update()
    {
        SetEnemyMovement();
    }


    private void SetEnemyMovement()
    {
        enemyVectorPosition = Vector3.MoveTowards(transform.position, playerGameobject.transform.position, movementSpeed * Time.deltaTime);
        transform.position = enemyVectorPosition;
    }
}
