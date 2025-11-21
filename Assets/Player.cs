using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(Rigidbody))]

public class Player : MonoBehaviour
{
    public Model GetModel() => model;
    private AudioSource _Audios;
    private MeshRenderer _MeshRenderer;
    private Rigidbody _rb;




    View _view;

   public Model model;

    Controller controller;



    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
            model.Grounded = true; 

        if (collision.gameObject.CompareTag("Bullet"))
        {
            controller.CheckDamage();
        }

    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
            model.Grounded = false;
    }




    // Start is called before the first frame update
    void Start()
    {
        _Audios = GetComponent<AudioSource>();
        _MeshRenderer = GetComponent<MeshRenderer>();
        _rb = GetComponent<Rigidbody>();

        _view = new View(_Audios, _MeshRenderer, this);

        // Primero CREAR el model
        model = new Model();

        // Ahora sí podés usarlo
        model.CurrentStats = model;

        controller = new Controller(model, _view);
    }

    // Update is called once per frame
    void Update()
    {
        controller.ProcessInputs();
        model.JumpPlayer(_rb);
        model.MovePlayer(_rb);

        Debug.Log("Velocidad actual: " + model.CurrentStats.GetVelocity());
        Debug.Log("Salto actual: " + model.CurrentStats.GetJumpForce());

    }
}
