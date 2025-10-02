using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour,ILifeSubstract
{
    public int life = 4;

    void Start()
    {
        
    }

    void Update()
    {
          
    }

    public void SubtractLife()
    {
        life = life - 1;
    }
}
