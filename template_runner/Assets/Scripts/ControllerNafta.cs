using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerNafta : MonoBehaviour
{
    public static float naftaVelocity;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //hace que los enemigos se muevan hacia la izquierda
        rb.AddForce(new Vector3(-naftaVelocity, 0, 0), ForceMode.Force);
        OutOfBounds();
    }

    //hace que el gameObject asignado, se destruya cuando su posicion sea menor a 15, es decir no se vea en pantalla
    public void OutOfBounds()
    {
        if (this.transform.position.x <= -15)
        {
            Destroy(this.gameObject);
        }

    }

    public void OnCollisionEnter(Collision collision)
    {
        //cuando toca un objeto con el tag enemy el jugador desaparece y la IU aparece
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }

    }
}