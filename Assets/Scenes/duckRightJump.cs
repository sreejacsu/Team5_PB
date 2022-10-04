using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duckRightJump : MonoBehaviour
{
    // Start is called before the first frame update
    /*public float speed = 1.19f;
    Vector3 pointA;
    Vector3 pointB;

    void Start()
    {
        pointA = new Vector3(250, 125, 0);
        pointB = new Vector3(250, 150, 0);
    }

    void Update()
    {
        //PingPong between 0 and 1
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }*/

    void start()
    {

    }
    void Update()
    {
        transform.Translate(0.60f, 0f, 0f);
    }
}
