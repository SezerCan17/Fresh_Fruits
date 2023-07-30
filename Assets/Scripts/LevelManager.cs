using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public int goal=10;
    public int level=1;
    public TextMeshProUGUI goalText;
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI gainText;
    public GameObject panel3;
    public GameObject panel2;
    
    public OrderCalculate orderCal;
    public Timer timer;

    private void Awake()
    {
        goal = 10;
        level = 1;
    }
    public void NextLevel()
    {
        newGoal();
        newLevel();
        mygain();
        newTime();
        TextManager();
    }

    public void RestartGame()
    {
        newTime();
        firstGoal();
        firstLevel();
        firstmygain();
        TextManager();
    }

    public void newGoal()
    {
        Debug.Log("newxtGoal");
        goal += (goal * 2) + 20;
        PlayerPrefs.SetInt(nameof(goal), goal);
    }
    public void firstGoal()
    {
        goal = 10;
        PlayerPrefs.SetInt(nameof(goal), goal);
    }
    public void newLevel()
    {
        level++;
        PlayerPrefs.SetInt(nameof(level), level);
    }
    public void firstLevel()
    {
        level = 1;
        PlayerPrefs.SetInt(nameof(level), level);
    }

    public void mygain()
    {
        PlayerPrefs.SetInt(nameof(orderCal.score), orderCal.score);
    }
    public void firstmygain()
    {
        
        orderCal.score = 0;
        PlayerPrefs.SetInt(nameof(orderCal.score), orderCal.score);
    }
    public void newTime()
    {
        timer.totalTime = 60f;
        Debug.Log("NewTime a girdi");
        timer.newCurrentTime();
        timer.Update();
    }

    public void TextManager()
    {
        goalText.text=("goal:"+goal.ToString());
        levelText.text=("Day:"+level.ToString());
        gainText.text=("Score:"+orderCal.score.ToString());
        
    }

    

}
