using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class chasing : MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject player;
    string theCollider;
    public GameObject receiver;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
    }


    public void OnTriggerEnter(Collider other)
    {
        theCollider = other.tag;
        if(theCollider == "Player")
        {
            receiver.SendMessage("DecreaseHealth");
        }
    }


}
