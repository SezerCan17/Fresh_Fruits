using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Is_it_Insade : MonoBehaviour
{
    public Customer customer;
    public ParticleController particleController;
    public RandomColor RandomColor;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("customer"))
        {
            customer.is_it_inside = true;
            Debug.Log("Ýçerde");

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("customer"))
        {
            RandomColor.Color();
            particleController.DeactivateParticle();
            Debug.Log("dýsarda");
            customer.is_it_inside = false;
        }

    }
}
