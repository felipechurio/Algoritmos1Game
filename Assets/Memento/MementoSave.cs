using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MementoDataContainer :SaveData
{
   private List<object> Datas = new List<object>();

    public void SaveMementoData(params object [] Data)
    {
      Datas.AddRange(Data);
    }
}
