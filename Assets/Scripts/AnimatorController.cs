using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private Animator anim;
    public bool IdleAnim=false;
    public bool IdleController = false;
   

    

    IEnumerator Start()
    {
        anim = GetComponent<Animator>();
        while (true)
        {
            yield return new WaitForSeconds(2f);

            {
                Debug.Log("randomsayý");
                anim.SetInteger("RandomAnimNumber", Random.Range(0, 3));

            }
        }
    
    }

    private void Update()
    {
        if(this.anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            IdleController = true;
            Debug.Log("IdleTrue");
        }
        else
        {
            IdleController= false;
            Debug.Log("IdleFalse");
            IdleAnim= false;
        }
    }

    public void IdleAnim_()
    {
        IdleAnim = true;
        Debug.Log("IdleAcýldý");
        anim.SetBool("Idle",true);
    }

    public void WalkingAnim()
    {
        anim.SetTrigger("walking");
    }

    public void IdleAnimFalse()
    {
        IdleAnim = false;
        anim.SetBool("Idle", false);
    }
}
