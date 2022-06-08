using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public bool player1Start = true;
    
    public Vector2 speed;
    
    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        
        rig.velocity = speed;
    }

    void Update()
    {

    }

    private void RestartBall()
    {
        rig.velocity = new Vector2(0, 0);
        transform.position = new Vector2(0, 0);
    }
}
