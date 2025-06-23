using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5f;
    private float leftedge;
    public float acceleration = 0.1f;

    private void Start()
    {
        leftedge = Camera.main.ScreenToWorldPoint(Vector3.zero).x-2f;
    }

    private void Update()
    {
        speed += acceleration * Time.deltaTime;
        transform.position += Vector3.left * speed * Time.deltaTime ;

        if (transform.position.x < leftedge)
        {
            Destroy(gameObject);
        }
    }

}
