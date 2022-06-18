using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedUpPaddle : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public GameObject paddleKiri, paddleKanan;
    public float magnitude;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {   
            // paddle.GetComponent<PaddleController>().ActivePUEnlargePaddel();
            if (ball.GetComponent<BallController>().CollisionLeft())
            {
                paddleKiri.GetComponent<PaddleController>().ActivePUSpeedUpPaddle(magnitude);
            }
            else
            {
                paddleKanan.GetComponent<PaddleController>().ActivePUSpeedUpPaddle(magnitude);
            }
            manager.RemovePowerUp(gameObject);
        }
    }  
}
