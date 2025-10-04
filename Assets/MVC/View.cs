using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : ILifeSubstractSound,IhitColor
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
       yield return new WaitForSeconds(1);
       _Renderer.material.color = Color.red;
       _Renderer.material.color = Color.white;
    }
}
