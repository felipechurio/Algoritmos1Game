using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayJumpSound : MonoBehaviour,IJumpSound
{
    void Start()
    {

        EventsTypes.EventSubscribe(EventStrings.JumpSound, JumpSound);


    }

    public void JumpSound()
    {
        print ("Reproduciendo sonido de muerte");
        // Reproducir sonido de muerte
    }
}
