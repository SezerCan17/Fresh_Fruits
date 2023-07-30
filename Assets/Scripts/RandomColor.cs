using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomColor : MonoBehaviour
{
    public SkinnedMeshRenderer meshRenderer;
    //public MeshRenderer ;

    public void Color()
    {
        meshRenderer.material.color = Random.ColorHSV();
    }
}
