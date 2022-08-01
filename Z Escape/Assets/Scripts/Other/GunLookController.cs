using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunLookController : MonoBehaviour
{

    [SerializeField] private GameObject crosshair;


    void Update()
    {
        SetGunLook();
    }


    void SetGunLook()
    {
        transform.LookAt(crosshair.transform);
    }
}
