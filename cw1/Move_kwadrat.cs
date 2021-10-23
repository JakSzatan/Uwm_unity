using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;

    private float speedY;
    private float startX;
    private float startY;
    void Start()
    {
        startX = transform.position.x;
        startY = transform.position.y;
        speedY = 0;
    }

    void Update()
    {
        if (startX + 10 <= transform.position.x && speed > 0)
        {
            speedY = speed;
            speed = 0;
            transform.Rotate(0.0f, 0.0f, 90.0f);
        }
        if (startY + 10 <= transform.position.y && startX + 10 <= transform.position.x && speedY > 0)
        {
            speed = speedY;
            speedY = 0;
            speed *= -1;
            transform.Rotate(0.0f, 0.0f, 90.0f, Space.World);
        }
        if (transform.position.x <= startX && speed < 0)
        {
            speedY = speed;
            speed = 0;
            transform.Rotate(0.0f, 0.0f, 90.0f);
        }
        if (transform.position.x <= startX && transform.position.y <= startY && speed == 0)
        {
            speed = speedY;
            speedY = 0;
            speed *= -1;
            transform.Rotate(0.0f, 0.0f, 90.0f);
        }
        transform.Translate(speed, speedY, 0,Space.World);
    }
}
