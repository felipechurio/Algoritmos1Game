using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : ILifeSubstract
{

    public float Xaxi = 5f;

    public float Yaxi = 5;

    public float Velocity = 5f;

    public float JumpForce = 4f;

    public bool Jump;

    public bool Grounded;


    public int life = 4;

    public void SubtractLife()
    {
        life--;
        EventsTypes.InvokeEvent(EventStrings.PlayerDamage);
    }

    public void JumpPlayer(Rigidbody _rb)
    {
        if (Grounded && Jump)
        {
            _rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            Jump = false;
        }
    }

    public void MovePlayer(Rigidbody _rb)
    {
        _rb.velocity = new Vector3(Xaxi * Velocity, _rb.velocity.y, Yaxi * Velocity);

    }
}
