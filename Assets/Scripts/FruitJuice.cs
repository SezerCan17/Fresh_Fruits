using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitJuice : MonoBehaviour
{
    public Order order;
    public int fruitsforjuiceCalculate;
    private string stringValue;
    public Juices juices;
    public void FruitJuiceMachine(string name)
    {
        stringValue = order.Random_Image_Num.ToString();
        if(stringValue==name)
        {
            fruitsforjuiceCalculate++;
            if(fruitsforjuiceCalculate==2)
            {
                juices.juices[order.Random_Image_Num].SetActive(true);
            }
        }
        
    }
}
