using UnityEngine;

public class Spaceshipcamera : MonoBehaviour
{
    public Transform targetObject; // The object whose position you want to attach to

    void Update()
    {
        if (targetObject != null)
        {
            // Set the position of this object to be the same as the target object
            transform.position = targetObject.position;
        }
    }
}
