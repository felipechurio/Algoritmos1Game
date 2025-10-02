using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour,ILifeSubstractSound,IhitColor
{
    [SerializeField] AudioSource _AudioSource;
    [SerializeField] MeshRenderer _Renderer;
   
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
