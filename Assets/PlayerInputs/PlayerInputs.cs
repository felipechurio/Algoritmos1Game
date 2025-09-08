using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    

   public float Xaxi;

   public float Yaxi;

   public float Velocity;

    public float JumpForce;

    public KeyCode Space;

    public bool Jump;
    

    private void Update()
    {
        Xaxi = Input.GetAxisRaw("Horizontal");

        Yaxi = Input.GetAxisRaw("Vertical");
    }
}
