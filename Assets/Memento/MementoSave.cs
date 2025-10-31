using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MementoDataContainer : MonoBehaviour, SaveData
{
    public List<object> Datas = new List<object>();

    void Start()
    {
      Datas.Add(RestorationPostion);
      Datas.Add(PlayerLife);
    }

    public Vector3 RestorationPostion = new Vector3(20,1.19f,17);

    public int PlayerLife = 2;

    public void SaveMementoData(params object [] Data)
    {
      Datas.AddRange(Data);
    }
}
