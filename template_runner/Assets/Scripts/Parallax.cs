using UnityEngine;

public class Parallax : MonoBehaviour
{
    public GameObject cam;
    private float length, startPos;
    public float parallaxEffect;

    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        //hace que se mueva el fondo
        transform.position = new Vector3(transform.position.x - parallaxEffect, transform.position.y, transform.position.z);
        //hace que el fondo se repita cuando termina
        if (transform.localPosition.x < -20)
        {
            transform.localPosition = new Vector3(20, transform.localPosition.y, transform.localPosition.z);
        }
    }
}
