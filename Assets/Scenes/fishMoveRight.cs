using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishMoveRight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {
        transform.Translate(0.50f, 0f, 0f);
    }
    /*public Vector3 targetPosition;
    public float speed = 10;
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }*/
}
