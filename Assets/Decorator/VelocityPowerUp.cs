using UnityEngine;

namespace Patterns.Wrappers.Decorator
{
    public class VelocityPowerUp : PlayerStatsOriginal, IPowerUpApply
    {
        public VelocityPowerUp (PlayerStatsOriginal previous) : base(previous)
        {


        }

        //public override string GetDescription()
       // {
           // return _sword.GetDescription() + ", with Ice";
       // }

        public float Apply()
        {
            AppliedEffect();
            return _Original.GetVelocity() +2;
        }

        public void AppliedEffect()
        {
            Debug.Log("Velocidad Aumentada");
        }
    }
}