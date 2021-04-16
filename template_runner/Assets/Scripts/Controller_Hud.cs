using UnityEngine;
using UnityEngine.UI;

public class Controller_Hud : MonoBehaviour
{
    public static bool gameOver = false;
    public Text distanceText;
    public Text gameOverText;
    private float distance = 0;

    void Start()
    {
        gameOver = false;
        distance = 0;
        distanceText.text = distance.ToString();
        gameOverText.gameObject.SetActive(false);
    }

    void Update()
    {
        if (gameOver)
        {
            //hace que el tiempo se detengay activa la UI con el numero de distancia recorrida y que perdio.
            Time.timeScale = 0;
            gameOverText.text = "Game Over \n Total Distance: " + distance.ToString();
            gameOverText.gameObject.SetActive(true);
        }
        //si gameOver sigue siendo true aumenta la distancia y la imprime en pantalla con la UI
        else
        {
            distance += Time.deltaTime;
            //transformo float en int
            int distanceToInt = (int)distance;
            distanceText.text = distanceToInt.ToString();
        }
    }
}
