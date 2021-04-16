using UnityEngine;
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
            //desactiva la ui
            SceneManager.LoadScene(0);
        }
    }
}
 