using UnityEngine;
using UnityEngine.AI;

public class militarythelastrun : MonoBehaviour
{
    public GameObject military;
    public float detectionDistance = 100f;
    private bool detected = false;
    private NavMeshAgent navMeshAgent;
    private Animator animator;
    public Transform player;
    public float moveSpeed = 5f;
    public float detectionRadius = 100f;
    public Light pointlight;
    private bool lighton = false;
    public Transform gunMuzzle;
    public float shootingRange = 20f;

    public bool yes = false;
    public int bullet_received = 5;
    public bool bull_rec = false;

    // New variables
    private int bulletsShot = 0;
    public static int bulletsToKillPlayer = 300;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.stoppingDistance = 10f;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        
        // Check if the player has received a bullet
        if (bull_rec == true)
        {
            
            FacePlayer();
            // Check if there are remaining bullets
            if (bullet_received != 0)
            {
                
                bullet_received -= 1;
                //animator.SetTrigger("Back-Run");
                
                bull_rec = false;
            }
            else
            {
                // Disable AI when no bullets are left
                navMeshAgent.enabled = false;

                // Check if the Dying animation is not already playing
                if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Dying"))
                {
                    // Set the Dying trigger
                    animator.SetTrigger("Dying");

                    // Additional actions after triggering dying, e.g., disabling movement scripts, etc.
                    // ...

                    // Disable the Animator component

                    // Disable this script
                    this.enabled = false;
                   
                    
                }
                military.SetActive(false);
                
            }
            
        }

        // Player detection 
        RaycastHit hit;
        if (Physics.Raycast(transform.position, player.position - transform.position, out hit, detectionRadius))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("Detected");
                detected = true;
                FacePlayer();
            }
        }

        if (detected)
        {
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);

            if (distanceToPlayer >= navMeshAgent.stoppingDistance)
            {
                animator.SetTrigger("Fin");
                FacePlayer();
                animator.ResetTrigger("Start");
                MoveTowardsPlayer();
            }
            else
            {
                animator.SetTrigger("Start");
                animator.ResetTrigger("Fin");
                FacePlayer();
                if (lighton == false)
                {
                    pointlight.enabled = true;
                    lighton = true;
                }
                else
                {
                    pointlight.enabled = false;
                    lighton = false;
                }
                ShootAtPlayer(hit);
            }
        }
    }

    void MoveTowardsPlayer()
    {
        navMeshAgent.SetDestination(player.position);
    }
//  void playerposition()
//  {
//     Vector3 directionofplayer=player.position-transform.position;
//      Quaternion lookRotation = Quaternion.LookRotation(directionToPlayer);
//  }
    void FacePlayer()
    {
        Vector3 directionToPlayer = player.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(directionToPlayer);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    void ShootAtPlayer(RaycastHit hit)
    {
        // Perform raycast to detect the player
        // RaycastHit hit;
        // if (Physics.Raycast(gunMuzzle.position, gunMuzzle.forward, out hit, shootingRange))
        // {
        //     if (hit.collider.CompareTag("Player"))
        //     {
        // Play muzzle flash particle effect

        // Increment the number of bullets shot
        // Debug.Log("Hit the player");
        bulletsShot++;
          bulletsToKillPlayer--;
        // Check if enough bullets have been shot to kill the player
        //200 add korsi karon health bar update er agei player 
        //more zacche
        if (bulletsToKillPlayer==0)
        {
            // KillPlayer();
            Playerdeath playerDeath = hit.transform.GetComponent<Playerdeath>();
            if (playerDeath != null)
            {
                yes = true;
                playerDeath.KillPlayer();
            }
        }
        // }
        // }
    }
}
