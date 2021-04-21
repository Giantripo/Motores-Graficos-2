using UnityEngine;
using UnityEngine.UI;

public class Controller_Hud : MonoBehaviour
{
    public static bool gameOver = false;
    public Text distanceText;
    public Text recordTxt;
    public Text recordTxt2;
    public Text gameOverText;
    public float distance = 0;
    public float maxDistance = 0;
    public float newPM = 0;



    void Start()
    {
        
        gameOver = false;
        distance = 0;
        int recordToInt = (int) Persistencia.instancia.data.record;
        recordTxt2.text = "Actual record :" + recordToInt;
        recordTxt2.gameObject.SetActive(true);
        distanceText.text = distance.ToString();
        gameOverText.gameObject.SetActive(false);
        recordTxt.gameObject.SetActive(false);


    }

    void Update()
    {
        if (gameOver)
        {
            //hace que el tiempo se detengay activa la UI con el numero de distancia recorrida y que perdio.
            Time.timeScale = 0;
            int distanceToInt = (int)distance;
            gameOverText.text = "Game Over \n Total Distance: " + distanceToInt.ToString();
            gameOverText.gameObject.SetActive(true);

            //si el record persistido es menor a la distancia maxima se muestra en pantalla el nuevo record y la distancia persistida pasa a ser igual a la maxdistance
            if (Persistencia.instancia.data.record < maxDistance)
            {
                recordTxt.gameObject.SetActive(true);
                Persistencia.instancia.data.record = maxDistance;
                int recordToInt = (int)Persistencia.instancia.data.record;
                recordTxt.text = "New record: " + recordToInt;
            }
            
           

        }
        //si gameOver sigue siendo true aumenta la distancia y la imprime en pantalla con la UI
        else
        {
            distance += Time.deltaTime;
          
            //transformo float en int
            int distanceToInt = (int)distance;
            distanceText.text = distanceToInt.ToString();

        }

        //si la distancia es mayor a la distancia maxima anteior y a la distancia maxima persistida, la distancia maxima se convierte en ese numero, de forma que es el nuevo record
        if(distance > maxDistance && distance> Persistencia.instancia.data.record)
        {
            maxDistance = distance;
        }
        
    }
}
