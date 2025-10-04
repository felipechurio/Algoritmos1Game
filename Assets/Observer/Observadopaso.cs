using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObservadoNotify : MonoBehaviour
{
    [SerializeField] ObservadoList ObserversList;

    private void Update()
    {
        if (Input.GetKey(KeyCode.F)) ObserversList.NotifyAll();

    }
}
