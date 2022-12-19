using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float SpeedX { get; set; }
    public  float SpeedY { get; set; }
    public bool Ready { get; set; }

    void Start()
    {
        SpeedX = 0;
        SpeedY = 0;
        Ready = false;
        
    }

    private void Update()
    {
        if (Ready)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(SpeedX, SpeedY), ForceMode2D.Impulse);
            Ready = false;
        }
    }
}
