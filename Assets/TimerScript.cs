using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public float countDown = 5;
    public TMP_Text text;

    void Update()
    {
        if(countDown > 0)
        {
            countDown -= Time.deltaTime;
        } else {
          countDown = 5;
        }
        double roundedCount = System.Math.Round(countDown, 0);
        text.text = roundedCount.ToString();
    }
}
