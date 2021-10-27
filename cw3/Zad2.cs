using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_o_10 : MonoBehaviour
{
    public float speed;
    private float startX;
    
    void Start(){
        startX = transform.position.x;
    
    }
    // Update is called once per frame
    void Update(){
        if (speed>0&&startX+ 10 < transform.position.x)
        {
            speed *= -1;
        }
        if (speed < 0 && startX > transform.position.x)
        {
            speed *= -1;
        }
        transform.Translate(speed, 0, 0);
    }
}
