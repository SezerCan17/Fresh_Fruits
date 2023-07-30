using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class OrderCalculate : MonoBehaviour
{
    public Order order;
    
    public Fruits fruits;
    public FruitsScore fruits_score;
    public ObjectsMoving objMove;
    public Rotten_Apple rotten_Apple;
    public int fruits_counter = 0;
    public int fruits_counter2 = 0;
    public int score;
    public TextMeshProUGUI scoreTMP;
    public bool wrongFruits=false;
    public string stringValue;
    public ParticleController particleController;

    private void Awake()
    {
        wrongFruits = false ;
    }
    private void Update()
    {
        stringValue = order.Random_Image_Num.ToString();
    }
    public void OrderCalculate_(string name)
    {
        
        if (stringValue == name)
        {
            fruits_counter++;
            Debug.Log("fruits_counter" + fruits_counter);
        }
        
        else
        {
            wrongFruits = true;
            
        }
    }
    public void OrderCalculate2_(string name2)
    {
        Debug.Log("fruits_counter2__girdi1");
        

        if (stringValue != name2)
        {
            fruits_counter2++;
            Debug.Log("fruits_counter2__ " + fruits_counter2);
        }
        else
        {
            Debug.Log("fruits_counter2__girdi2");
            wrongFruits = true;

        }
    }

    public void ScoreCalculate()
    {
        if((wrongFruits) && (order.orderNumber==fruits_counter+fruits_counter2))
        {
            score += fruits_counter2 * fruits_score.rottens_score[objMove.index];
            score += fruits_counter * fruits_score.fruits_score[order.Random_Image_Num];
            Debug.Log("fruits_score****1" + score);
            ResultScore();
            particleController.ActivateParticle();
        }
        else if((wrongFruits==true) && (order.orderNumber<fruits_counter+fruits_counter2))
        {
            score += order.orderNumber * fruits_score.fruits_score[order.Random_Image_Num];
            Debug.Log("fruits_score****2" + score);
            ResultScore();
            particleController.ActivateParticle();
        }
        else
        {
            score -= 30;
            ResultScore();
        }
        

    }
    public void ResultScore()
    {
        scoreTMP.text = ("Score:" + score);
        wrongFruits=false;
        fruits_counter2 = 0;
        fruits_counter = 0;
    }
}
