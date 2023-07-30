using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Order : MonoBehaviour
{
    public int orderNumber;
    public TextMeshProUGUI orderText;
    public int Random_Image_Num;
    //public Image[] images;
    public GameObject[] images;

    public void orderRandom()
    {
        orderNumber = Random.Range(1, 5);
        Debug.Log("order number"+orderNumber);
        orderText.text = ("X" + orderNumber.ToString());
    }

    public void Random_Images()
    {
        Random_Image_Num = Random.Range(0, 2);
        Debug.Log("Order image"+ Random_Image_Num);
        images[Random_Image_Num].gameObject.SetActive(true);

    }





}
