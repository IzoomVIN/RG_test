namespace Gameplay.Helpers.CustomHelpers
{
    public class OutOfBorderDestructor : OutOfBorderInspector
    {
        protected override void CheckBorders()
        {
            if(!GameAreaHelper.IsInGameplayArea(transform, _representation.bounds))
            {
                Destroy(gameObject);
            }
        }
    }
}
