using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : ILifeSubstract
{

    public float Xaxi = 5f;

    public float Yaxi = 5;

    public float Velocity = 5f;

    public float JumpForce;

    public bool Jump;

    public bool Grounded;


    public int life = 4;

    public void SubtractLife()
    {
        life = life - 1;
    }


}
