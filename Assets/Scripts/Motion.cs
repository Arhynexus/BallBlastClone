using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    [SerializeField] private float RotationX;
    [SerializeField] private float RotationY;
    [SerializeField] private float RotationZ;

    [SerializeField] private float PositionX;
    [SerializeField] private float PositionY;
    [SerializeField] private float PositionZ;
    void Update()
    {
        
        // Debug.Log(Time.deltaTime);
        transform.Translate (PositionX * Time.deltaTime, PositionY * Time.deltaTime, PositionZ * Time.deltaTime);
        transform.Rotate(RotationX * Time.deltaTime, RotationY * Time.deltaTime, RotationZ * Time.deltaTime);
    }
}
