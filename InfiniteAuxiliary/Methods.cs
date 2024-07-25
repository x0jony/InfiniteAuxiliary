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
            }
            else
            {
                Exiled.Events.Handlers.Player.Spawning -= plugin.EventHandlers.OnSpawning;
            }
        }
    }
}