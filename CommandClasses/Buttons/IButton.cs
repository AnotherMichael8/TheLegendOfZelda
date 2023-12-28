

using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.CommandClasses.Buttons
{
    public interface IButton
    {
        public bool Pressed(Vector2 mousePosition);
        public void Invoke();
    }
}
