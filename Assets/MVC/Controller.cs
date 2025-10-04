using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller 
{
    private Model model;
    private View _view;

    public Controller(Model model, View view)
    {
        model = model;
        _view = view;
    }


    public void ProcessInputs()
    {
        // Movimiento horizontal/vertical
       model.Xaxi = Input.GetAxis("Horizontal");
        model.Yaxi = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space) && model.Grounded)
        {
            model.Jump = true; // intención de salto
        }






    }


    //  if (Input.GetKeyDown(KeyCode.Space))
    //  {
    //   _lifeSubstract.SubtractLife();
    //  StartCoroutine(_hitColor.ChangeColorDamage());
    // _lifeSubstractSound.LifeDamageSound();
    // }



}
