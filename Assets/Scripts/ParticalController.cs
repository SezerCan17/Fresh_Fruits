using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public GameObject particleSystemObject; // ParticleSystem'ýn bulunduðu GameObject'u atamak için kullanacaðýmýz deðiþken

    private ParticleSystem particleSystemComponent; // ParticleSystem bileþenini saklamak için kullanacaðýmýz deðiþken

    public void Start()
    {
        particleSystemComponent = particleSystemObject.GetComponent<ParticleSystem>();
        // ParticleSystem bileþenini alarak saklýyoruz
    }

    public void ActivateParticle()
    {
        particleSystemComponent.Play();
        // Particle System'ý aktifleþtir
    }

    public void DeactivateParticle()
    {
        particleSystemComponent.Stop();
        // Particle System'ý devre dýþý býrak
    }
}
