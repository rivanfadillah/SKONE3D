using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroChecker : MonoBehaviour
{
    void Start()
    {
        Input.gyro.enabled = true;
        Debug.Log("Gyroscope aktif? " + Input.gyro.enabled);
    }

    void Update()
    {
        Debug.Log("Rotasi Gyro: " + Input.gyro.attitude.eulerAngles);
    }
}

