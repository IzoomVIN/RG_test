using Gameplay.Bonuses.CustomBonuses.HealthBonus;
using Gameplay.Weapons;

namespace Gameplay.Bonuses.CustomBonuses.SpeedBonus
{
    public interface ISpeedable
    {
        UnitBattleIdentity BattleIdentity { get; }

        void ApplySpeed(ISpeedDealer speedDealer);
    }
}