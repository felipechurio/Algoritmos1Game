using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventKilledUi : MonoBehaviour
{       
        
    [SerializeField] private MonoBehaviour _ToUiLose;
     private LoseScreenInterface Lose;
    
        
    // Start is called before the first frame update
    void Start()
    {
        Lose = (LoseScreenInterface)_ToUiLose;
        EventsTypes.Killed += Lose.GoToLoseScreen;
    }

    private void OnDestroy()
    {
        EventsTypes.Killed -= Lose.GoToLoseScreen;
    }

}
