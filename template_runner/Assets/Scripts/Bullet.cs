using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //si toca un objeto con tag enemy o floor, la bala desaparece
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Floor"))
        {
            Destroy(this.gameObject);
        }
    }
    
}
