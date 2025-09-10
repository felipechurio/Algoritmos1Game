using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObservadoList : MonoBehaviour,AddRemove,NotifyAllObservers
{
   private List <Iobservers> Observers = new List <Iobservers> ();


    public void Observer()
    { }

    public void Adds(Iobservers Observer)
    { 
    
        Observers.Add (Observer);
    
    }

    public void Remove(Iobservers Observer)
    { 
    
       Observers.Remove (Observer);
    
    }

    public void NotifyAll()
    {

        foreach (Iobservers Observer in Observers)
        {

            Observer.Notified();
        
        }
    
    }
}
