using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeadController : MonoBehaviour
{

    public void SetEnemyDead()
    {
        gameObject.SetActive(false);
    }

}
