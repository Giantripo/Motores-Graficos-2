using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float velDisparo;
    public Rigidbody balaPrefab;
    public Transform disparador;
    public Rigidbody balaImpulso;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            balaImpulso = Instantiate(balaPrefab, disparador.position, Quaternion.identity);
            balaImpulso.AddForce(disparador.forward * 100 * velDisparo);
        }
    }
}
