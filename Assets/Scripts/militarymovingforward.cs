using UnityEngine;
using UnityEngine.AI;

public class militarymovingforward : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 90f;

    private Vector3 initialPosition;
    private Quaternion initialRotation;
    private bool movingForward = true;
    private bool turning = false;
    public float limitdistance;
    public float yrotation;

    void Start()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }

    void Update()
    {
        if (movingForward)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

            // Check if the military has moved forward 60 units
            if (Vector3.Distance(transform.position, initialPosition) >= limitdistance)
            {
                movingForward = false;
                turning = true;
            }
        }
        else if (turning)
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

            // Check if the military has turned 90 degrees
            if (Quaternion.Angle(transform.rotation, initialRotation * Quaternion.Euler(0, yrotation, 0)) < 1)
            {
                turning = false;
                movingForward = true;

                // Update initial position and rotation for the next cycle
                initialPosition = transform.position;
                initialRotation = transform.rotation;
            }
        }
    }
}
