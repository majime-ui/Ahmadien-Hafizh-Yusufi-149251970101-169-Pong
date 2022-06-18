using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public bool player1Start = true;
    public Vector2 resetPosition;
    
    public Vector2 speed;
    
    private Rigidbody2D rig;

    private bool collisionLeft;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        
        rig.velocity = speed;
    }

    public void ResetBall()
    {
        transform.position = new Vector3 (resetPosition.x, resetPosition.y, 2);
    }

    private IEnumerator SpeedUpTimer(float magnitude)
    {
        yield return new WaitForSeconds(5f);
        DeactivePUSpeedUP(magnitude);
    }

    public void ActivePUSpeedUP(float magnitude)
    {
        rig.velocity *= magnitude;
        StartCoroutine(SpeedUpTimer(magnitude));
    }

    public void DeactivePUSpeedUP(float magnitude)
    {
        rig.velocity /= magnitude;
    }

    public bool CollisionLeft()
    {
        return collisionLeft;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Padel Kiri")
        {
            collisionLeft = true;
        }
        else if (collision.gameObject.name == "Padel Kanan")
        {
            collisionLeft = false;
        }
    }
}