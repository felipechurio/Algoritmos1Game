using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : ILifeSubstractSound
{

    private AudioSource _AudioSource;
    private MeshRenderer _Renderer;

    public View(AudioSource Audio, MeshRenderer Renderer)
    {
        _AudioSource = Audio;
        _Renderer = Renderer;
    }



    public void LifeDamageSound()
    { 
       _AudioSource.Play();
    }



    public void ChangeColorDamage()
    { 
       _Renderer.material.color = Color.red;
        for (float t = 0; t < 1; t += Time.deltaTime)
        { 
        

        }
       //_Renderer.material.color = Color.white;
    }
}
