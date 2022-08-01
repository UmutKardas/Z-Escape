using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterBackrotorRotateController : MonoBehaviour
{

    [SerializeField] private float speedRotation;


    void Update()
    {
        SetBackrotorRotate();
    }


    private void SetBackrotorRotate()
    {
        transform.Rotate(new Vector3(90f, 0, 0) * speedRotation * Time.deltaTime);
    }
}
