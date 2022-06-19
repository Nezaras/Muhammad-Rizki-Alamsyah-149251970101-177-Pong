using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddlePUController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public float panjang;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            manager.paddle.GetComponent<PaddleController>().ActivateScale(manager.paddle);
            manager.RemovePowerUp(gameObject);
        }
    }

}
