using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public GameObject particleSystemObject; // ParticleSystem'�n bulundu�u GameObject'u atamak i�in kullanaca��m�z de�i�ken

    private ParticleSystem particleSystemComponent; // ParticleSystem bile�enini saklamak i�in kullanaca��m�z de�i�ken

    public void Start()
    {
        particleSystemComponent = particleSystemObject.GetComponent<ParticleSystem>();
        // ParticleSystem bile�enini alarak sakl�yoruz
    }

    public void ActivateParticle()
    {
        particleSystemComponent.Play();
        // Particle System'� aktifle�tir
    }

    public void DeactivateParticle()
    {
        particleSystemComponent.Stop();
        // Particle System'� devre d��� b�rak
    }
}
