using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerStatsOriginal : IPlayerStats
{
    
        protected IPlayerStats _Original;

        public PlayerStatsOriginal(IPlayerStats previous)
        {
           _Original = previous;
        }

    public virtual float GetVelocity() => _Original.GetVelocity();
    public virtual float GetJumpForce() => _Original.GetJumpForce();

}
