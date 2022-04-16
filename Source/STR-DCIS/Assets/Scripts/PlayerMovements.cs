using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerMovements
{
    public static float moveSpeed = 5f;
    public static int x_axis = 0;
    public static int y_axis = 0;

    public static Rigidbody2D rb;
    public static Animator animator;

    // Update is called once per frame
    public static int Updates(char input)
    {
        if (input == 'w')
        {
            return y_axis + 1;
        }
        else if (input == 'a')
        {
            return y_axis - 1;
        }
        else if (input == 'd')
        {
            return x_axis + 1;
        }
        else if (input == 's')
        {
            return x_axis - 1;
        }
        return 0;
    }

    public static void FixedUpdate()
    {
        // movement
        rb.MovePosition(rb.position * moveSpeed * Time.fixedDeltaTime);
    }
}
