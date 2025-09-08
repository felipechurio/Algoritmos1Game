using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventKilledSound : MonoBehaviour
{
       [SerializeField] private MonoBehaviour KilledPlayer;
         private InterfaceKillerSound KilledSound;

    void Start()
    {
        KilledSound = (InterfaceKillerSound)KilledPlayer;
        

        EventsTypes.Killed += KilledSound.PlayKilledSound;
    }

    private void OnDestroy()
    {
        EventsTypes.EventUnSubscribe("Killed", KilledSound.PlayKilledSound);
    }

}

