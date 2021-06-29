using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleModel
{
    private const float MOVE_SPEED = 0.05f;

    public Vector2 position;

    public CircleModel()
    {
        position = new Vector2(-9, -4);
    }

    public void Control()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            position.x += MOVE_SPEED;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            position.x -= MOVE_SPEED;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            position.y += MOVE_SPEED;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            position.y -= MOVE_SPEED;
        }
    }
}
