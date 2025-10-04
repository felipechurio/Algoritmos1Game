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



    public IEnumerator ChangeColorDamage()
    {
        _Renderer.material.color = Color.red;
        yield return new WaitForSeconds(0.5f);
        _Renderer.material.color = Color.white;
    }
}
