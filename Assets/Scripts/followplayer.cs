using UnityEngine;
using UnityEngine.AI;

public class followplayer : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // Ensure the player and navMeshAgent are assigned
        if (player != null && navMeshAgent != null)
        {
            // Set the destination of the military unit to the player's position
            navMeshAgent.SetDestination(player.position);
        }
    }
}
