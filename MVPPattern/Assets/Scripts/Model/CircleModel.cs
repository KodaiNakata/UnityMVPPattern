using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleModel
{
    public Vector2 position;

    public CircleModel()
    {
        position = new Vector2(-9, -4);
    }

    public void Control()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            position.x += 0.01f;
        }
    }
}
