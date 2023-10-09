using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class PlanetMovement : MonoBehaviour
{
    public float range = 25f;
    private NavMeshAgent _agent;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (_agent.pathPending || !_agent.isOnNavMesh || _agent.remainingDistance > 0.5f)
         return;

        _agent.destination = range * Random.insideUnitCircle;
    }
}
