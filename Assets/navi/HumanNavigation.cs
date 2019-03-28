using UnityEngine;
using UnityEngine.AI;

public class HumanNavigation : MonoBehaviour
{
    public GameObject destination;
    NavMeshAgent agent;
    LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        agent = GetComponent<NavMeshAgent>();
        agent.updatePosition = false;
    }

    void Update()
    {
        agent.SetDestination(destination.transform.position); 
        agent.nextPosition = Camera.main.transform.position;  

        var positions = agent.path.corners;
        lineRenderer.positionCount = positions.Length;
        for (int i = 0; i < positions.Length; i++)
        {
            Debug.Log("point " + i + "=" + positions[i]);
            lineRenderer.SetPosition(i, positions[i]);
        }
    }
}