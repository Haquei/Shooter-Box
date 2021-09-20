using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMover : MonoBehaviour
{

    public float SpinSpeed = 180.0f;
    public float motionMagnitude = 0.1f;



    void Update()
    {
        gameObject.transform.Rotate(Vector3.up * SpinSpeed * Time.deltaTime);

        gameObject.transform.Translate(Vector3.up * Mathf.Cos (Time.timeSinceLevelLoad) * motionMagnitude);


    }
}
