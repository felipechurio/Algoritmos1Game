using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DELETEPLAYERDAMAGE : MonoBehaviour
{
    public PlayerApplyMemento playerApplyMemento;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            playerApplyMemento.PlayerLife -= 1;
        }
    }


    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
       // {
           // playerApplyMemento.PlayerLife -= 1;
       // }
    }
}
