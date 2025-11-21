using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntity : MonoBehaviour,IRestoreEntity
{
    int life;

    Vector3 Position;

    Quaternion Rotations;

    public int RestoreEntityStates(object[] objeto)
    {
         life = (int)objeto[0];

         Position  = (Vector3)objeto[1];

        Rotations = (Quaternion)objeto[2];

        transform.position = Position;

        transform.rotation = Rotations;

        return life + 2; 
    }
}
