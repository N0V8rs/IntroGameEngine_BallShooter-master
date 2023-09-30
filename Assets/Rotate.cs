using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 10f; // Speed at which the object rotates

    void Update()
    {
        // Get the current rotation
        Vector3 currentRotation = transform.rotation.eulerAngles;

        // Calculate the new rotation
        float newRotation = currentRotation.z + rotationSpeed * Time.deltaTime;

        // Apply the rotation to the object
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, newRotation));
    }
}
