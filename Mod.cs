using Colossal.Logging;
using Game;
using Game.Modding;
using Game.Tools;

namespace ToolDemo
{
    public class Mod : IMod
    {
        public static ILog log = LogManager.GetLogger($"{nameof(ToolDemo)}.{nameof(Mod)}").SetShowsErrorsInUI(true);

        public void OnLoad(UpdateSystem updateSystem)
        {
            updateSystem.World.GetOrCreateSystemManaged<DemoToolSystem>();
            updateSystem.UpdateAt<DemoToolSystem>(SystemUpdatePhase.ToolUpdate);

            var netToolSystem = updateSystem.World.GetOrCreateSystemManaged<NetToolSystem>();
            if (netToolSystem.toolID == "Net Tool")
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
            {
                log.Error($"netToolSystem: {netToolSystem}");
                log.Error($"netToolSystem.toolID: {netToolSystem.toolID}");
            }
        }

        public void OnDispose()
        {
        }
    }
}
