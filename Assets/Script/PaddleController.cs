using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    private float speedAwal;
    public float speed;

    public KeyCode upKey;
    public KeyCode downKey;

    private Rigidbody2D rig;

    private void Start()
    {
        speedAwal = speed;
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector2 movement = GetInput();
        MoveObject(movement);

    }

    private Vector2 GetInput()
    {
        if(Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        else if(Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        rig.velocity = movement;
    }

    public void ActivePUEnlargePaddle()
    {
        gameObject.transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y * 2);
        StartCoroutine(EnlargePaddleTimer());
    }

    public void DeactivePUEnlargePaddle()
    {
        gameObject.transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y / 2);
    }

    private IEnumerator EnlargePaddleTimer()
    {
        yield return new WaitForSeconds(5f);
        DeactivePUEnlargePaddle();
    }

    public void ActivePUSpeedUpPaddle(float magnitude)
    {
        speed *= magnitude;
        StartCoroutine(SpeedUpTimer(magnitude));
    }

    public void DeactivePUSpeedUpPaddle(float magnitude)
    {
        speed /= magnitude;
    }

    private IEnumerator SpeedUpTimer(float magnitude)
    {
        yield return new WaitForSeconds(5f);
        DeactivePUSpeedUpPaddle(magnitude);
    }
}    
