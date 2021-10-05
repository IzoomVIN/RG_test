namespace Gameplay.Helpers.CustomHelpers
{
    public class OutOfBorderRegulator: OutOfBorderInspector
    {
        protected override void CheckBorders()
        {
            if(!GameAreaHelper.IsInGameplayArea(transform, _representation.bounds))
            {
                transform.position = GameAreaHelper.GetPositionInGameplayArea(transform, _representation.bounds);
            }
        }
    }
}