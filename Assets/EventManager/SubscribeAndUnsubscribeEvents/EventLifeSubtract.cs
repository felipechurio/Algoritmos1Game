using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

       

       [SerializeField] private MonoBehaviour _lifeSubstracter;
         private InterfaceLifeSubstract lifeSubstact;
    

    void Start()
    {
        lifeSubstact = (InterfaceLifeSubstract)_lifeSubstracter;

        EventsTypes.LifeSubtract += lifeSubstact.LifeSubstracters;
    }

    private void OnDestroy()
    {
        EventsTypes.LifeSubtract -= lifeSubstact.LifeSubstracters;
    }

}
