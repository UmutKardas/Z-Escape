using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairTargetController : MonoBehaviour
{

    [SerializeField] private GameObject fireAnimation;
    private Ray ray;
    private RaycastHit hit;


    void Update()
    {
        SetCrosshairPosition();
    }


    private void SetCrosshairPosition()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        bool isHit = Physics.Raycast(ray, out hit);
        transform.position = new Vector3(hit.point.x, 1.5f, hit.point.z);
        fireAnimation.SetActive(false);


        if (isHit && hit.collider.CompareTag("Enemy"))
        {
            hit.collider.GetComponent<EnemyDeadController>().SetEnemyDead();
            fireAnimation.SetActive(true);
        }

    }




}
