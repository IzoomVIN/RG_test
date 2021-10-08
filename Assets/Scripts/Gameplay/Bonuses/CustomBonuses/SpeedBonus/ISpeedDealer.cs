using Gameplay.Weapons;

namespace Gameplay.Bonuses.CustomBonuses.SpeedBonus
{
    public interface ISpeedDealer
    {
        UnitBattleIdentity AnchorIdentity { get; }

        float Speed { get; }
    }
}