using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_o_10 : MonoBehaviour
{
    public float speed;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 5.0f || transform.position.x < -5.0f)
        {
            speed *=-1;
        }
        transform.Translate(speed, 0, 0);
        
    }
}
