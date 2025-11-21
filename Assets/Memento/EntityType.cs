using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityType : IEntity
{
    public SaveData _SaveData;
    public void EntityData(object[] Data)
    { 
      _SaveData.SaveMementoData(Data);
    }
}
