using RSBot.Core.Plugins;
using System.Windows.Forms;
using RSBot.FortressWar.Views;

namespace RSBot.FortressWar
{
    public class Bootstrap: IPlugin
    {
        private Views.Main _control;

        public PluginInfo Information => new PluginInfo
        {
            DisplayAsTab = true,
            DisplayName = "Fortress War",
            InternalName = "RSBot.Fortress",
            LoadIndex = 0,
            TabDisplayIndex = 101,
            RequireIngame = false
        };
        
        public void Initialize()
        {
           _control = new Views.Main();

            Core.Log.Notify("Plugin [Fortress War] initialized!");
        }

        public Control GetView()
        {
            return _control;
        }
    }
}