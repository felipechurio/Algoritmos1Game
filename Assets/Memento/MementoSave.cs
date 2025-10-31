using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MementoDataContainer : MonoBehaviour, SaveData
{
    public List<object> Datas = new List<object>();

    void Update()
    {
        //if (player.life == 0)
        {
           // SaveMementoData(PlayerLife, Player.transform.position);

        }
    
    }

  

    public int PlayerLife = 2;

    public void SaveMementoData(params object [] Data)
    {
      Datas.AddRange(Data);
    }
}
