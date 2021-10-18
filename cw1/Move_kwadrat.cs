using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_kwadrat : MonoBehaviour
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
    // Update is called once per frame
    void Update()
    {
        if (startX + 10 <= transform.position.x && speed>0)
        {
            speedY = speed;
            speed = 0;
        }
        if (startY+10 <= transform.position.y && speedY>0)
        {
            speed = speedY;
            speedY = 0;
            speed *= -1;
        }
        if (transform.position.x <= startX && speed < 0) {
            speedY = speed;
            speed = 0;
        }
        if (transform.position.x <= startX && startY <= transform.position.y && speed == 0) {
            speed = speedY;
            speedY = 0;
            speed *= -1;
        }
        transform.Translate(speed, speedY, 0);
    }
}
