using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    float countDown = 5;
    public TMP_Text text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(countDown > 0)
        {
            countDown -= Time.deltaTime;
        }
        double roundedCount = System.Math.Round(countDown, 0);
        text.text = roundedCount.ToString();
    }
}
