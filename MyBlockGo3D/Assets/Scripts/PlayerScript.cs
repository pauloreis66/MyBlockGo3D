using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rigid;
    public float moveForce = 50.0f;
    public CameraScript mainCamera;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            rigid.AddForce(0,0, moveForce *  Time.deltaTime, ForceMode.VelocityChange);
            mainCamera.SetDirection("up");
        }

        if (Input.GetKey("down"))
        {
            rigid.AddForce(0, 0, -moveForce * Time.deltaTime, ForceMode.VelocityChange);
            mainCamera.SetDirection("down");
        }

        if (Input.GetKey("right"))
        {
            rigid.AddForce(moveForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            mainCamera.SetDirection("right");
        }

        if (Input.GetKey("left"))
        {
            rigid.AddForce(-moveForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            mainCamera.SetDirection("left");
        }

    }

}
