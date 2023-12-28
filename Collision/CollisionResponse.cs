using Sprint2_Attempt3.CommandClasses;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.CommandClasses.LinkCommands;


namespace Sprint2_Attempt3.Collision
{
    public class CollisionResponse
    {
        private static Game1 game;
        public CollisionResponse(Game1 gameClass)
        {
            game = gameClass;
        }

        public static void HandlePlayerEnemyCollision(ILink link, IEnemy enemy, ICollision side)
        {
            Link newLink = (Link)link;
            side.LinkEnemyKnockback(newLink);
            ICommand damage = new SetDamageLinkCommand(link);
            damage.Execute();
        }
    }
}
