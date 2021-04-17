using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollBar : MonoBehaviour
{
 
    Slider bar;
    public static float distanceScrollBar;

    void Start()
    {
        bar = GetComponent<Slider>();
        distanceScrollBar = 1;
    }

    void Update()
    {
        if (Controller_Hud.gameOver==false)
        {
            distanceScrollBar += Time.deltaTime;
            bar.value = distanceScrollBar;
        }

        if (bar.value == 10)
        {
            Controller_Hud.gameOver = true;

        }
    }
}
