using UnityEngine;

public class spcaecontrol : MonoBehaviour
{
   public static bool uthse = false;
    public float moveSpeed = 5.0f;
    public float rotationSpeed = 90.0f;

void Start()
{
    GetComponent<Spaceship>().enabled=false;
}
    void Update()
    {
        // if(Spaceship.consta==true)
        // {
        //  //distance.failtext.enabled=false;
        //   HandleInput();
        // }
        HandleInput();
    }

    void HandleInput()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // Rotate left
            transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            // Rotate right
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            // Move forward
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            // Move backward
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        // else if (Input.GetKey(KeyCode.LeftControl))
        // {
        //     // Move downward
        //     transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        // }
        // else if (Input.GetKey(KeyCode.LeftShift))
        // {
        //     // Move upward
        //     transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        // }

        // Check for specific combination of left and down arrows
        if (Input.GetKey(KeyCode.L) )
        {
            // Move downward on y-axis
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }

        // Check for specific combination of up and right arrows
        if (Input.GetKey(KeyCode.U) )
        {
            // Move upward on y-axis
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }

        uthse = true;
    }
}
