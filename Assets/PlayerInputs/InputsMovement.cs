using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputsMovement : MonoBehaviour, InputsInterface
{
    [SerializeField] PlayerInputs _PlayerInputs;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    public void Inputs()
    {

        Vector3 Movement = (this.transform.right * _PlayerInputs.Yaxi + (-this.transform.forward * _PlayerInputs.Xaxi)) * _PlayerInputs.Velocity * Time.fixedDeltaTime;
        this.rb.MovePosition(this.rb.position + Movement);

    }

    void FixedUpdate()
    {

        Inputs();

        if (Input.GetKey(_PlayerInputs.Space)) this.rb.AddForce(this.transform.up * _PlayerInputs.JumpForce * Time.fixedDeltaTime, ForceMode.Impulse); 
    } 
}
