using Exiled.API.Features.Roles;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.EventArgs.Scp079;
using PlayerRoles;

namespace InfiniteAuxiliary
{
    public class EventHandlers
    {
        private readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;

        internal void OnSpawning(SpawningEventArgs ev)
        {
            if (ev.Player.Role.Type != RoleTypeId.Scp079) return;
            
            Scp079Role scp079 = ev.Player.Role.As<Scp079Role>();
            scp079.AuxManager.CurrentAux = float.MaxValue;
        }
        
        internal void OnChangingRole(ChangingRoleEventArgs ev)
        {
            if (ev.Player.Role.Type != RoleTypeId.Scp079) return;
            
            Scp079Role scp079 = ev.Player.Role.As<Scp079Role>();
            scp079.AuxManager.CurrentAux = float.MaxValue;
        }
        
        internal void OnPinging(PingingEventArgs ev) { ev.AuxiliaryPowerCost = 0; ev.Scp079.AuxManager.CurrentAux = float.MaxValue; }
        internal void OnChangingCamera(ChangingCameraEventArgs ev) { ev.AuxiliaryPowerCost = 0; ev.Scp079.AuxManager.CurrentAux = float.MaxValue; }
        internal void OnElevatorTeleporting(ElevatorTeleportingEventArgs ev) { ev.AuxiliaryPowerCost = 0; ev.Scp079.AuxManager.CurrentAux = float.MaxValue; }
        internal void OnGainingExperience(GainingExperienceEventArgs ev) { ev.Scp079.AuxManager.CurrentAux = float.MaxValue; }
        internal void OnGainingLevel(GainingLevelEventArgs ev) { ev.Scp079.AuxManager.CurrentAux = float.MaxValue; }
        internal void OnInteractingTesla(InteractingTeslaEventArgs ev) { ev.AuxiliaryPowerCost = 0; ev.Scp079.AuxManager.CurrentAux = float.MaxValue; }
        internal void OnLockingDown(LockingDownEventArgs ev) { ev.AuxiliaryPowerCost = 0; ev.Scp079.AuxManager.CurrentAux = float.MaxValue; }
        internal void OnRoomBlackout(RoomBlackoutEventArgs ev) { ev.AuxiliaryPowerCost = 0; ev.Scp079.AuxManager.CurrentAux = float.MaxValue; }
        internal void OnTriggeringDoor(TriggeringDoorEventArgs ev) { ev.AuxiliaryPowerCost = 0; ev.Scp079.AuxManager.CurrentAux = float.MaxValue; }
        internal void OnZoneBlackout(ZoneBlackoutEventArgs ev) { ev.AuxiliaryPowerCost = 0; ev.Scp079.AuxManager.CurrentAux = float.MaxValue; }
        internal void OnChangingSpeakerStatus(ChangingSpeakerStatusEventArgs ev) { ev.Scp079.AuxManager.CurrentAux = float.MaxValue; }
    }
}