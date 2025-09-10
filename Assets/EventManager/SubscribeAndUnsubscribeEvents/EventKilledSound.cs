using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventKilledSound : MonoBehaviour
{
    [SerializeField] private PlayKilledSounds killedPlayer; // Clase concreta

    private InterfaceKillerSound KilledSound;

    void Start()
    {
        KilledSound = killedPlayer; // ya es InterfaceKillerSound
        EventsTypes.EventSubscribe("Killed", KilledSound.PlayKilledSound);
    }

    private void OnDestroy()
    {
        EventsTypes.EventUnSubscribe("Killed", KilledSound.PlayKilledSound);
    }

}

