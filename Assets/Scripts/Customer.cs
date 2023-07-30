using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Customer : MonoBehaviour
{
    NavMeshAgent agent;

    public Order order;

    public Transform Target1;
    public Transform Target2;
    Vector3 firtPos;

    

    public bool target1_finished=false;
    public bool inTarget2=false;
    public bool is_it_inside=false;

    public bool agentStop=false;
    public bool agentTarget2=false;

    
    private void Start()
    {
        firtPos = transform.position;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if(!target1_finished && is_it_inside)
        {
            Target1_();
        }
        else if(target1_finished && is_it_inside && agentTarget2 )
        {
            //RandomColor.Color();
            Debug.Log("sdgsd");
            gameObject.GetComponent<NavMeshAgent>().enabled = true;
            agent.destination = Target2.transform.position;
        }
        else if(!is_it_inside)
        {
            gameObject.SetActive(false);
            Target2_();
        }
    }

    public void Target1_()
    {
        if(!agentStop)
        {
            gameObject.GetComponent<NavMeshAgent>().enabled = true;
            agent.destination = Target1.transform.position;
        }
    }
    public void Target2_()
    {
        transform.position = firtPos;
        gameObject.SetActive(true);
        target1_finished = false;
        Target1_();
    }

    




}
