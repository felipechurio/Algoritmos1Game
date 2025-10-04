using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Observer : MonoBehaviour,Iobservers
{
     
    public void Notified()
    {
        

        EventsTypes.InvokeEvent(EventStrings.ShootSound);

        print("Se Invoco");
    
    }
}
