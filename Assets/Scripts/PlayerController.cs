using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rgb2d;
    SurfaceEffector2D surfaceEffector2D;

    [SerializeField] float torque = 1f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 20f;
    private bool restrictControls=false;
    void Start()
    {
        rgb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindAnyObjectByType<SurfaceEffector2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if(!restrictControls){
            RoatatePlayer();
            RespondeToBoost();
        }
    }
    public void DisableControls(){
        restrictControls=true;
    }
    private void RespondeToBoost()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }

    private void RoatatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rgb2d.AddTorque(torque);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rgb2d.AddTorque(-torque);
        }
    }
}
