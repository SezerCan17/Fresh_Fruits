using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Is_it_ınsade3 : MonoBehaviour
{
    public AnimatorController animController;
    public Customer customer;
    private void OnTriggerEnter(Collider other)
    {
        animController.IdleAnim = true;
        customer.agentStop = true;
        Debug.Log("Target_icerde");
    }

    private void OnTriggerExit(Collider other)
    {
        animController.IdleAnim=false;
        customer.agentStop = false;
        Debug.Log("Target_dısarda");
    }

}
