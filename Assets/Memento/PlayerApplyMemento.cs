using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerApplyMemento : MonoBehaviour
{
   public int PlayerLife = 2;

    Vector3 Position = new Vector3(20, 2, 17);

    Quaternion Rotation = Quaternion.identity;

    public IRestoreEntity restoreEntity;



    void Awake()
    {
        restoreEntity = GetComponent<IRestoreEntity>();
    }

    void Update()
    {
        object[] datos = new object[] { PlayerLife, Position,Rotation};
        
        if (PlayerLife <= 0)
        {            
         PlayerLife = restoreEntity.RestoreEntityStates(datos);
        }
    }
}
