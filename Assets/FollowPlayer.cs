using UnityEngine;
using UnityEngine.AI;
public class FollowPlayer : MonoBehaviour
{
    private NavMeshAgent agent;
    [SerializeField] private Transform Player;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {
            agent.SetDestination(Player.position);
        }
    }
}