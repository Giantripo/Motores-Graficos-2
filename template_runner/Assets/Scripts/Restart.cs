﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    void Update()
    {
        GetInput();
    }

    private void GetInput()
    {         
        if (Input.GetKeyDown(KeyCode.R))
        {
            //reanuda el tiempo
            Time.timeScale = 1;
            //carga la escena desde 0 para que el juego vuelva a comenzar
            SceneManager.LoadScene(0);
        }
    }
}
 