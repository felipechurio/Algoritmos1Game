using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observadopaso : MonoBehaviour
{
    [SerializeField] ObservadoList pp;

    private void Update()
    {
        if (Input.GetKey(KeyCode.F)) pp.NotifyAll();

    }
}
