using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterPropellerRotationController : MonoBehaviour
{

    [SerializeField] private float speedRotation;


    void Update()
    {
        SetPropellerRotation();
    }


    private void SetPropellerRotation()
    {
        transform.Rotate(new Vector3(0, 90f, 0) * speedRotation * Time.deltaTime);
    }
}
