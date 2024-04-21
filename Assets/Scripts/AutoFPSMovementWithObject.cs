using UnityEngine;

public class AutoFPSMovementWithObject : MonoBehaviour
{
    public  Transform player;
    private Transform originalParent;
    private bool isInsideObject = false;
   public static bool enter=false;
   public static bool gameover=false;
    void Start()
    {
        enter=false;
        // Save the original parent (presumably, this is the FPSController or another root object)
        originalParent = transform.parent;
    }
void Update()
{
    if(player.position.y<=-150)
    {
        enter=true;
        gameover=true;
    }
}
    void OnTriggerEnter(Collider other)
    {
        // Check if the FPS character entered the trigger zone of the moving object
        if (other.CompareTag("spaceship"))
        {
            EnterObject(other.transform);
            enter=true;
        }
        // if(other.CompareTag("the end"))
        // {
        //   enter=true;
        // }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the FPS character exited the trigger zone of the moving object
        if (other.CompareTag("spaceship"))
        {
            ExitObject();
        }
    }

    void EnterObject(Transform otherTransform)
    {
        if (!isInsideObject)
        {
            // Set as a child of the moving object
            transform.SetParent(otherTransform, true);
            isInsideObject = true;
        }
    }

    void ExitObject()
    {
        // Reset the parent to the original parent
        transform.SetParent(originalParent, true);
        isInsideObject = false;
    }
}
