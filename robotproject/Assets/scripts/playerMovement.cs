using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class playerMovement : MonoBehaviour
{
    [SerializeField] const float playerSpeed = 4;
    [SerializeField] float xValue = 0;
    [SerializeField] float zValue = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
        xValue = (Input.GetAxis("Horizontal")* -1)* Time.deltaTime * playerSpeed;
        zValue = (Input.GetAxis("Vertical")*-1) * Time.deltaTime * playerSpeed;
        transform.Translate(xValue, 0, zValue);
        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.Quit();
        }
    }
}
