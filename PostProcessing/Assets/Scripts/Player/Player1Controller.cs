using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : PlayerController
{

    public override void Update()
    {
        base.Update();
        if (pOne)
        {
            Move();
            RotatePlayer();
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("  habilidad player 1 ");
            }
        }


        
       
    }
}
    

  