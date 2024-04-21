using UnityEngine;

public class rocketrotate : MonoBehaviour
{
    public float rotationSpeed = 50f; // Adjust this value to control the speed of rotation

    void Update()
    {
        // Rotate the object around its up axis (Y-axis) continuously
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
