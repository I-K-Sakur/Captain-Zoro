using UnityEngine;

public class rotate : MonoBehaviour
{
    public float sensitivity = 2.0f; // Adjust this value to control the mouse sensitivity

    private void Update()
    {
        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Rotate the player horizontally based on mouse movement
        transform.Rotate(Vector3.up * mouseX * sensitivity);

        // Rotate the camera vertically based on mouse movement
        float newRotationY = transform.eulerAngles.y + mouseX * sensitivity;
        float newRotationX = transform.eulerAngles.x + mouseY * sensitivity; // Negate the Y-axis rotation value

        // Limit vertical rotation
        newRotationX = Mathf.Clamp(newRotationX, -90f, 90f);

        // Apply rotations
        transform.rotation = Quaternion.Euler(newRotationX, newRotationY, 0f);
    }
}
