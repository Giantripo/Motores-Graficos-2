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
        //la scrollbar comienza en 1
        distanceScrollBar = 1;
    }

    void Update()
    {
        //mientras el juego no haya terminado
        if (Controller_Hud.gameOver==false)
        {
            //igualo el valor de la scrollbar a distanceScrollBar para que vaya incrementando el numero a la par del tiempo transcurrido
            distanceScrollBar += Time.deltaTime;
            bar.value = distanceScrollBar;
        }
        //termina el juego cuando el valor de la bar llega a 10
        if (bar.value == 10)
        {
            Controller_Hud.gameOver = true;
        }
        //if (bar.value < 1 )
        //{
        //    distanceScrollBar = 1;
        //    distanceScrollBar += Time.deltaTime;
        //}
    }
}
