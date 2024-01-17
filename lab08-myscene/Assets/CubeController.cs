using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float moveSpeed = 1.0f;

    void Update()
    {
        // Get thumbstick input from the left and right Oculus Touch controllers
        float leftThumbstickX = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, OVRInput.Controller.LTouch).x;
        float leftThumbstickY = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, OVRInput.Controller.LTouch).y;

        float rightThumbstickX = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, OVRInput.Controller.RTouch).x;
        float rightThumbstickY = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, OVRInput.Controller.RTouch).y;

        // Calculate movement based on thumbstick input
        Vector3 movement = new Vector3(rightThumbstickX - leftThumbstickX, 0, rightThumbstickY - leftThumbstickY) * moveSpeed * Time.deltaTime;

        // Move the cube
        transform.Translate(movement);
    }
}