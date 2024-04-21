using UnityEngine;
using UnityEngine.UI;
public class rocketmovement : MonoBehaviour
{
    public static int housecounter=15;
    public GameObject explosion; // Prefab for explosion effect
    public GameObject particles; // Prefab for particle effect
    public Transform SpaceShip;
    public Transform Missile;
    public static Transform target;
    public float speed = 5f;
    public float rotateSpeed = 0.03f;

    private Rigidbody rb;
    public static bool missilehitkorse = false;

    public AudioClip missilehitsoundclip;
    //By adding [SerializeField], the Letterobject field will now be visible in the Unity Editor, and you can drag objects into it as needed.
      public GameObject Letterobject;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SpaceShip = Missile;
    
    
        Letterobject.SetActive(false);
    
    }

    void Update()
    {
        if (SpaceShip != null && Missile != null)
        {
            SpaceShip = Missile;
        }
        //  if( housecounter<=0)
        //     {
        //     Debug.Log("Next scene");
        //     Letterobject.SetActive(true);
        //     }
        // else
        // {
        //     Debug.Log("Housecounter: " + housecounter);
        // }
    }

    void FixedUpdate()
    {
        if (target != null)
        {
            // Calculate the direction to the target
            Vector3 direction = (target.position - transform.position).normalized;

            // Calculate the rotation angle to face the target
            float angle = Vector3.Dot(transform.forward, direction);

            // Rotate the missile towards the target
            Vector3 rotationAmount = Vector3.Cross(transform.forward, direction);
            rb.angularVelocity = rotationAmount * rotateSpeed;

            // Move the missile forward
            rb.velocity = transform.forward * speed;
        }
        else
        {
            Debug.LogWarning("Target not assigned to MissileController!");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "House")
        {
            missilehitkorse = true;
            Destroy(collision.gameObject);

            // Instantiate the particle effect only if the prefab is not null
            if (particles != null)
            {
                Instantiate(particles, transform.position, transform.rotation);

                // Play the audio clip using PlayOneShot
                if (missilehitsoundclip != null)
                {
                    AudioSource.PlayClipAtPoint(missilehitsoundclip, Camera.main.transform.position,1.0f);
                }
            }
            else
            {
                Debug.LogError("Particle prefab is missing!");
            }
            Destroy(gameObject);
             housecounter--;
            //  if(housecounter<=0)
            //  {
            //     Letterobject.SetActive(true);
            //  }
           
     
        }

    }
}
