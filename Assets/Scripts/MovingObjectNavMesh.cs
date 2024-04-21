using UnityEngine;
using UnityEngine.AI;

public class MovingObjectNavMesh : MonoBehaviour
{
    private NavMeshObstacle navMeshObstacle;

    void Start()
    {
        // Add NavMeshObstacle component to the object
        navMeshObstacle = gameObject.AddComponent<NavMeshObstacle>();
        navMeshObstacle.carving = true;
        navMeshObstacle.carveOnlyStationary = false;
        navMeshObstacle.size = new Vector3(1f, 1f, 1f); // Adjust the size based on your needs
    }

    void Update()
    {
        // Move the object dynamically
        MoveObject();
    }

    void MoveObject()
    {
        // Implement the movement logic for your object here
        // Example: transform.Translate(Vector3.forward * Time.deltaTime);

        // Update the position and size of the NavMeshObstacle
        navMeshObstacle.transform.position = transform.position;
        // Adjust the size based on your needs
        navMeshObstacle.size = new Vector3(1f, 1f, 1f);
    }
}
