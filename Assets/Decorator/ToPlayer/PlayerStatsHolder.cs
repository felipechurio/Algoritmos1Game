using UnityEngine;

public class PlayerStatsHolder : MonoBehaviour
{
    public IPlayerStats stats;

    void Start()
    {
        stats = new Model();
    }
}
