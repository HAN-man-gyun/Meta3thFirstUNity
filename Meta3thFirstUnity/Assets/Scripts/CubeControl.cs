using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    private float rotationSpeed = 50f;
    private Vector3 cubeRotation = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("이게 Unity의 Hello world다.");
        //transform.Rotate(new Vector3(0f, 45f, 0f));
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("이것또한 어디선가 Call하고있다.");

        cubeRotation.y = rotationSpeed *Time.deltaTime;
        transform.Rotate(cubeRotation);
    }
}
