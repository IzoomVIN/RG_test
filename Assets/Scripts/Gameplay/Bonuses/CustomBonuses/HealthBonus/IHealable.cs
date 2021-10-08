using Gameplay.Weapons;

namespace Gameplay.Bonuses.CustomBonuses.HealthBonus
{
    public interface IHealable
    {
        UnitBattleIdentity BattleIdentity { get; }

        void ApplyHealth(IHealDealer healDealer);
    }
}