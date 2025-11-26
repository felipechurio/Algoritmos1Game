using UnityEngine;

namespace Patterns.Wrappers.Decorator
{
    public class VelocityPowerUp : PlayerStatsOriginal
    {
        private Player _player;

        public VelocityPowerUp(Player player) : base(player.model.CurrentStats)
        {
            _player = player;
        }

        public override float GetVelocity()
        {
            return _Original.GetVelocity() + 10f;
        }
    }
}
