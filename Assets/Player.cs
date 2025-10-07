using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(Rigidbody))]

public class Player : MonoBehaviour
{

    private AudioSource _Audios;
    private MeshRenderer _MeshRenderer;
    private Rigidbody _rb;




    View _view;

    Model model;

    Controller controller;



    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
            model.Grounded = true; 

        if (collision.gameObject.CompareTag("Bullet"))
        {
            controller.CheckDamage();
            StartCoroutine(_view.ChangeColorDamage());
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

        _view = new View(_Audios, _MeshRenderer);

         model = new Model();

         controller = new Controller(model, _view);
    }
    // Update is called once per frame
    void Update()
    {
        controller.ProcessInputs();
        model.JumpPlayer(_rb);
        model.MovePlayer(_rb);
       
    }
}
