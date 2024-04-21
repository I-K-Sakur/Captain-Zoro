using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 5f;
    public float detectionRadius = 10f;

    void Update()
    {
        // Ensure the player is not null before performing detection
        if (player != null)
        {
            // Check if the player is within the detection radius
            if (Vector3.Distance(transform.position, player.position) <= detectionRadius)
            {
                // Player detected, move towards the player
                MoveTowardsPlayer();
            }
        }
    }

    void MoveTowardsPlayer()
    {
        // Look at the player
        transform.LookAt(player.position);

        // Move towards the player
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
