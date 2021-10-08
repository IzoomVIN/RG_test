using Gameplay.Weapons;

namespace Gameplay.Bonuses.CustomBonuses.HealthBonus
{
    public interface IHealDealer
    {
        UnitBattleIdentity AnchorIdentity { get; }

        float Health { get; }
    }
}