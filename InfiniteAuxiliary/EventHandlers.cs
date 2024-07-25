using Exiled.API.Features.Roles;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;

namespace InfiniteAuxiliary
{
    public class EventHandlers
    {
        private readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;

        internal void OnSpawning(SpawningEventArgs ev)
        {
            if (ev.Player.Role != RoleTypeId.Scp079) return;
            
            Scp079Role scp079 = ev.Player.Role.As<Scp079Role>();
            scp079.AuxManager.CurrentAux = float.MaxValue;
        }
    }
}