using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : PlayerController
{
    public override void Update()
    {
        base.Update();
        if (!pOne)
        {
            Move();
            RotatePlayer();
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (FloorContact())
                {
                    Jump();
                }
            }
        }



     
    }
}
