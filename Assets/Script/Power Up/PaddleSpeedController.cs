using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleSpeedController : MonoBehaviour
{
    public Collider2D ball;
    public float speed;
    public PowerUpManager manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            manager.paddle.GetComponent<PaddleController>().ActivateSpeed();
            manager.RemovePowerUp(gameObject);
        }
    }
}
