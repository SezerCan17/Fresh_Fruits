using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotten_Apple : MonoBehaviour
{
    public ObjectsMoving objectMove;
 
    public Animator anim;
    public AnimatorController anim_controller;
    public VibrationController Vib_controller;
    public OrderCalculate orderCal;
    public Customer customer;
    public ObjectsMoving objMove;
    public Fruits fruits;
    public TMPScore tMPScore;
    public bool rotten=false;
    public int index;

    
    public void Rotten_appleControl()
    {
        if(anim_controller.IdleController)
        {
            orderCal.score_ = 30;
            orderCal.score -= 30;
            tMPScore.ShowTMPText2();
            orderCal.ResultScore();
            Debug.Log("yakalandýnn");
            Vib_controller.VibrateDevice();
            objectMove.TorbaPos();
            customer.target1_finished = true;
            customer.agentStop = false;
            customer.agentTarget2 = true;
            
            
        }
        else
        {
            
            Debug.Log("noyaka");
            
        }

    }

    public void Rotten_FruitsControl(string name)
    {
        Debug.Log("rotten girdi1");
        for(int i=0;i<=0;i++)
        {
            Debug.Log("rotten girdi2");
            Debug.Log("rotten"+ fruits.rotten_fruits[i].name);
            
            string fruname2 = fruits.rotten_fruits[i].name;
            if (name==fruname2)
            {
                Debug.Log("ARAS");
                index = i;
                rotten = true;
                Debug.Log("rotten" + rotten);
                break;
                
            }
            else
            {
                rotten = false;
            }
            
            
        }
        
    }
}
