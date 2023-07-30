using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TMPScore : MonoBehaviour
{
    public TMP_Text tmpText;
    public TMP_Text tmpText2;
    public float displayDuration = 2f;
    public OrderCalculate orderCalculate;
    public Transform tmptext;
    private Transform firtPos;

    void Start()
    {
        firtPos = tmptext;
        if (tmpText == null)
        {
            Debug.LogWarning("TMP Text nesnesi atanmamýþ!");
            return;
        }

        tmpText.gameObject.SetActive(false);
    }

    public void ShowTMPText()
    {
        tmpText.transform.position = firtPos.position;
        StartCoroutine(DisplayTMPTextForDuration());
    }

    IEnumerator DisplayTMPTextForDuration()
    {
        tmpText.gameObject.SetActive(true);
        tmpText.text = ("+" + orderCalculate.score_);
        yield return new WaitForSeconds(displayDuration);
        tmpText.gameObject.SetActive(false);
        
    }

    public void ShowTMPText2()
    {
        tmpText2.transform.position = firtPos.position;
        StartCoroutine(DisplayTMPTextForDuration2());
    }

    IEnumerator DisplayTMPTextForDuration2()
    {
        tmpText2.gameObject.SetActive(true);
        tmpText2.text = ("-" + orderCalculate.score_);
        yield return new WaitForSeconds(displayDuration);
        tmpText2.gameObject.SetActive(false);
        
    }
}
