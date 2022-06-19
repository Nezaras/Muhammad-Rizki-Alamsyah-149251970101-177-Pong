using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // mencari input
        Vector3 movement = GetInput();

        // menggerakan object
        MoveObject(movement);
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        rig.velocity = movement;
        Debug.Log("Test: " + movement);
    }

    public void ActivateScale(GameObject paddle)
    {

        paddle.transform.localScale += new Vector3(0, paddle.transform.localScale.y, 0);
    }

    public void ScaleDown(GameObject paddle)
    {
        paddle.transform.localScale -= new Vector3(0, paddle.transform.localScale.y / 2, 0);
    }

    public void ActivateSpeed()
    {
        speed *= 3;
    }
}
