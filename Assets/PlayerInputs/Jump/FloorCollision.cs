using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCollision : MonoBehaviour
{
    [SerializeField] PlayerInputs _PlayerInputs;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            _PlayerInputs.Jump = true;
            _PlayerInputs.JumpForce = 170;

            print("Colisiono con el piso");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            _PlayerInputs.Jump = false;
            _PlayerInputs.JumpForce = 0;

            print("Dejo de colisionar con el piso");
        }
    }
}
