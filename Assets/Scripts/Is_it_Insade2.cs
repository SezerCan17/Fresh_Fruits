using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Is_it_Insade2 : MonoBehaviour
{
    public Order order;

    public Customer customer;
    public GameObject orderPanel;
    public bool orderCollider;


    public AnimatorController animController;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("customer"))
        {
            orderCollider = true;
            order.orderRandom();
            order.Random_Images();
            orderPanel.SetActive(true);
            animController.IdleAnim_();       
            customer.agentStop = true;
            Debug.Log("Target_icerde");
            Debug.Log("Order_Ýçerde");

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("customer"))
        {
            orderCollider = false;
            orderPanel.SetActive(false);
            Debug.Log("Order_dýsarda");
            customer.agentStop = false;
            Debug.Log("Target_dýsarda");

        }
    }
}
