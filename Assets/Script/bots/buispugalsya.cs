using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buispugalsya : MonoBehaviour
{
    public GameObject player;
    private UnityEngine.AI.NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (agent != null)
        {
            agent.destination = player.transform.position;
        }
    }
}
