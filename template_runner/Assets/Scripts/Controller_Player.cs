using UnityEngine;
using UnityEngine.UI;
public class Controller_Player : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce = 10;
    private float initialSize;
    private int i = 0;
    private bool floored;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialSize = rb.transform.localScale.y;
    }

    void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        Jump();
        Duck();
    }

    private void Jump()
    {
        //si es que esta en el piso y se presiona la W salta
        if (floored)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            }
        }
    }

    private void Duck()
    {
        //si esta en el piso y se presiona la S disminuye su tamaño
        if (floored)
        {
            if (Input.GetKey(KeyCode.S))
            {
                if (i == 0)
                {
                    rb.transform.localScale = new Vector3(rb.transform.localScale.x, rb.transform.localScale.y / 2, rb.transform.localScale.z);
                    i++;
                }
            }
            else
            {
                if (rb.transform.localScale.y != initialSize)
                {
                    rb.transform.localScale = new Vector3(rb.transform.localScale.x, initialSize, rb.transform.localScale.z);
                    i = 0;
                }            }
        }
        else
        //si es que esta en el piso y se presiona la S baja 
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                rb.AddForce(new Vector3(0, -jumpForce, 0), ForceMode.Impulse);
            }
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        //cuando toca un objeto con el tag enemy el jugador desaparece y la IU aparece
        if (collision.gameObject.CompareTag("Enemy"))
        {

            Destroy(this.gameObject);
            Controller_Hud.gameOver = true;
            
        }
        //cuando toca un objeto con el tag floor el jugador puede saltar, ya que floored se hace verdadero
        if (collision.gameObject.CompareTag("Floor"))
        {
            floored = true;
        }
        if (collision.gameObject.CompareTag("nafta"))
        {
            ScrollBar.distanceScrollBar -= 2.5f;
            
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        //esto funciona para que cuando deje de estar contacto con el "floor" el booleano floored pase a ser falso, para que player no pueda saltar en el aire
        if (collision.gameObject.CompareTag("Floor"))
        {
            floored = false;
        }

        if (collision.gameObject.CompareTag("nafta"))
        {
            ScrollBar.distanceScrollBar += Time.deltaTime;
        }
    }
}
