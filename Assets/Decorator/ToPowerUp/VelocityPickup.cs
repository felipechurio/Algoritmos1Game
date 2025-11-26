using Patterns.Wrappers.Decorator;
using UnityEngine;

public class VelocityPickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                player.model.CurrentStats = new VelocityPowerUp(player);

                //player.model.CurrentStats = new VelocityPowerUp(player.model.CurrentStats);


                Debug.Log("VELOCIDAD AUMENTADA");
            }

            Destroy(gameObject);
        }
    }
}
