using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUEnlargePaddle : MonoBehaviour
{
    public PowerUpManager manager;
    public GameObject paddleKiri, paddleKanan;
    public Collider2D ball;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {   
            // paddle.GetComponent<PaddleController>().ActivePUEnlargePaddel();
            if (ball.GetComponent<BallController>().CollisionLeft())
            {
                paddleKiri.GetComponent<PaddleController>().ActivePUEnlargePaddle();
            }
            else
            {
                paddleKanan.GetComponent<PaddleController>().ActivePUEnlargePaddle();
            }
            manager.RemovePowerUp(gameObject);
        }
    }    
}
