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
            InitializeCommands();
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
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
        }

        private void SubscribeEvents()
        {
            
        }

        public void ChatCommandTrace(uint senderId, string message)
        {
            Log.Notify("should trace");
            var commandContainer = message.Split(' ');
            var invoke = commandContainer[0].Trim();
            var who = commandContainer[1].Trim();
            if (invoke.Equals("cmd"))
            {
                Log.Notify("its a cmd");
                SpawnManager.TryGetEntities<SpawnedPlayer>(out var spawnedPlayers);
                foreach (var player in spawnedPlayers)
                {
                    Log.Notify("looking for players");
                    if (player.Name.Equals(who))
                    {
                        Log.Notify("start tracing");
                        Game.Player.StartTrace(player.UniqueId);
                    }
                    else
                    {
                        Log.Notify("nth found");

                    }
                    
                }
            }
        }

        private void InitializeCommands()
        {
          Commands.Add("trace",new TraceCommand());
        }
        

        
        

    }
}