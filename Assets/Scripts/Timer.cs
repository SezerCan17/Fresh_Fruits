using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float totalTime = 60f; // Toplam süre (saniye)
    private float currentTime;
    public TextMeshProUGUI textMeshProUGUI;
    public LevelManager levelManager;
    
    public GameObject panel2;
    public GameObject panel3;
    public OrderCalculate orderCal;
    

    public Customer customer;
    private void Awake()
    {
        currentTime = totalTime;
    }

    public void Update()
    {
        Debug.Log("2. kez update time a girdi");
        if (currentTime >= 0)
        {
            currentTime -= Time.deltaTime;
            int intValue = Convert.ToInt32(currentTime);
            textMeshProUGUI.text = intValue.ToString();
        }
        else
        {
            EndTimer();
        }
    }
    public void newCurrentTime()
    {
        Debug.Log("NewCurrentTime a girdi");
        currentTime = totalTime;
    }


    private void EndTimer()
    {
        if (customer.is_it_inside)
        {
            Debug.Log("Musteri Bekleniyor");
        }
        else
        {

            Debug.Log("Timer Ended!");
            if(levelManager.goal<=orderCal.score)
            {
                Time.timeScale = 0f;
                Debug.Log("NextLevel");
                panel2.SetActive(true);
            }
            else
            {
                Time.timeScale = 0f;
                Debug.Log(levelManager.goal);
                //Debug.Log(orderC._gain);
                Debug.Log("RestartGame");
                panel3.SetActive(true);
            }

        }



    }

    


}
