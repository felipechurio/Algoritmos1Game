using UnityEngine;

namespace Patterns.Wrappers.Decorator
{
    public class VelocityPowerUp : PlayerStatsOriginal
    {
        public VelocityPowerUp (IPlayerStats previous) : base(previous)
        {

        }
        public override float GetVelocity()
        {
            return _Original.GetVelocity() +10f;
        }

    }
}