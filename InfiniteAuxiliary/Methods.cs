namespace InfiniteAuxiliary
{
    public class Methods
    {
        private readonly Plugin plugin;
        public Methods(Plugin plugin) => this.plugin = plugin;

        internal void EventRegistration(bool enabled = true)
        {
            if (enabled)
            {
                Exiled.Events.Handlers.Player.Spawning += plugin.EventHandlers.OnSpawning;
                Exiled.Events.Handlers.Player.ChangingRole += plugin.EventHandlers.OnChangingRole;
                
                Exiled.Events.Handlers.Scp079.Pinging += plugin.EventHandlers.OnPinging;
                Exiled.Events.Handlers.Scp079.ChangingCamera += plugin.EventHandlers.OnChangingCamera;
                Exiled.Events.Handlers.Scp079.ElevatorTeleporting += plugin.EventHandlers.OnElevatorTeleporting;
                Exiled.Events.Handlers.Scp079.GainingExperience += plugin.EventHandlers.OnGainingExperience;
                Exiled.Events.Handlers.Scp079.GainingLevel += plugin.EventHandlers.OnGainingLevel;
                Exiled.Events.Handlers.Scp079.InteractingTesla += plugin.EventHandlers.OnInteractingTesla;
                Exiled.Events.Handlers.Scp079.LockingDown += plugin.EventHandlers.OnLockingDown;
                Exiled.Events.Handlers.Scp079.RoomBlackout += plugin.EventHandlers.OnRoomBlackout;
                Exiled.Events.Handlers.Scp079.TriggeringDoor += plugin.EventHandlers.OnTriggeringDoor;
                Exiled.Events.Handlers.Scp079.ZoneBlackout += plugin.EventHandlers.OnZoneBlackout;
                Exiled.Events.Handlers.Scp079.ChangingSpeakerStatus += plugin.EventHandlers.OnChangingSpeakerStatus;
            }
            else
            {
                Exiled.Events.Handlers.Player.Spawning -= plugin.EventHandlers.OnSpawning;
                Exiled.Events.Handlers.Player.ChangingRole -= plugin.EventHandlers.OnChangingRole;
                
                Exiled.Events.Handlers.Scp079.Pinging -= plugin.EventHandlers.OnPinging;
                Exiled.Events.Handlers.Scp079.ChangingCamera -= plugin.EventHandlers.OnChangingCamera;
                Exiled.Events.Handlers.Scp079.ElevatorTeleporting -= plugin.EventHandlers.OnElevatorTeleporting;
                Exiled.Events.Handlers.Scp079.GainingExperience -= plugin.EventHandlers.OnGainingExperience;
                Exiled.Events.Handlers.Scp079.GainingLevel -= plugin.EventHandlers.OnGainingLevel;
                Exiled.Events.Handlers.Scp079.InteractingTesla -= plugin.EventHandlers.OnInteractingTesla;
                Exiled.Events.Handlers.Scp079.LockingDown -= plugin.EventHandlers.OnLockingDown;
                Exiled.Events.Handlers.Scp079.RoomBlackout -= plugin.EventHandlers.OnRoomBlackout;
                Exiled.Events.Handlers.Scp079.TriggeringDoor -= plugin.EventHandlers.OnTriggeringDoor;
                Exiled.Events.Handlers.Scp079.ZoneBlackout -= plugin.EventHandlers.OnZoneBlackout;
                Exiled.Events.Handlers.Scp079.ChangingSpeakerStatus -= plugin.EventHandlers.OnChangingSpeakerStatus;
            }
        }
    }
}