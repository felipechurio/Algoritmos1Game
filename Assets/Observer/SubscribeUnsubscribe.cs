using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubscribeUnsubscribe : MonoBehaviour
{

    public Iobservers observers;

    public AddRemove remove;

    void Start()
    { 
     
        observers = GetComponent<Iobservers>();

        remove = GetComponent<AddRemove>();

        SubscribeObserver();
    
    }

    
    public void SubscribeObserver()
    { 
    
      remove.Adds(this.observers);
    
    
    }

    public void UnSubscribeObserver()
    { 
    
    
      remove.Remove(this.observers);
    
    
    }
}
