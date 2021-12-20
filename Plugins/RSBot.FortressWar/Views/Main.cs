using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RSBot.Core;
using RSBot.Core.Components;
using RSBot.Core.Objects.Spawn;

using RSBot.Core.Event;
using RSBot.FortressWar.Bundle.CommandCore;
using RSBot.FortressWar.Bundle.Commands;

namespace FortressWar.Views
{
    public partial class Main : UserControl
    {
        public Dictionary<string, ICommand> Commands = new Dictionary<string, ICommand>();
        
        public Main()
        {            
            InitializeComponent();
            InitializeCommands();
            CheckForIllegalCrossThreadCalls = false;
            SubscribeEvents();
           
        }

        private void startTrace_Click(object sender, EventArgs e)
        {
            SpawnManager.TryGetEntities<SpawnedPlayer>(out var spawnedPlayers);
            foreach (var player in spawnedPlayers)
            {
                List<string> list = tracePlayerList.Items.Cast<ListViewItem>().Select(item => item.Text).ToList();
                foreach (var playerName in list)
                {   
                    if (playerName.Equals(player.Name))
                    {
                        Game.Player.StartTrace(player.UniqueId);
                    }
                }
            }
        }

        private void addToListBtn_Click(object sender, EventArgs e)
        {
            string row = playnameTextBox.Text;
            var listViewItem = new ListViewItem(row);
            tracePlayerList.Items.Add(listViewItem);
            var list = tracePlayerList.Items.Cast<ListViewItem>().Select(item => item.Text).ToArray();
            PlayerConfig.SetArray("RSBot.FortressWar.commandList",list);
        }

        private void SubscribeEvents()
        {
            EventManager.SubscribeEvent("OnEnterGame", OnEnterGame);
        }

        private void OnEnterGame()
        {
            foreach (var str in  PlayerConfig.GetArray<string>("RSBot.FortressWar.commandList"))
            {
                tracePlayerList.Items.Add(str);
            }
        }

        private void InitializeCommands()
        {
          Commands.Add("trace",new TraceCommand());
        }
        

        
        

    }
}