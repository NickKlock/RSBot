using RSBot.Core.Plugins;
using System.Windows.Forms;
using FortressWar.Views;
using RSBot.FortressWar.Views;

namespace RSBot.FortressWar
{
    public class Bootstrap: IPlugin
    {

        public PluginInfo Information => new PluginInfo
        {
            DisplayAsTab = true,
            DisplayName = "War",
            InternalName = "RSBot.Fortress",
            LoadIndex = 2,
            TabDisplayIndex = 101,
            RequireIngame = true
        };
        
        public void Initialize()
        {
            Views.View.Instance = new Main();
            Core.Log.Notify("Plugin [Fortress War] initialized!");
        }

        public Control GetView()
        {
            return Views.View.Instance;
        }
    }
}