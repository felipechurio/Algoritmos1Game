using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSubstracter : MonoBehaviour,InterfaceLifeSubstract
{  /// reemplazar por la logica del juego.

 public int life = 4;
     void Update()
     {

         LifeSubstracters();

         

     }
        

    public void LifeSubstracters()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            life= life -1;

        }
       

    }
}
