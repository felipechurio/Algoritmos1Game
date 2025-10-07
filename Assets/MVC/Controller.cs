using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : Iinputs
{
    private Model _model;
    //private View _view;
    public Controller(Model model, View view)
    {
        _model = model;
    }


    public void ProcessInputs()
    {
       
       _model.Xaxi = Input.GetAxis("Horizontal");
        _model.Yaxi = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space) && _model.Grounded)
        {
            _model.Jump = true;

        }
    }

    public void CheckDamage()
    {
            _model.SubtractLife();
           // _view.LifeDamageSound();        
    }



}
