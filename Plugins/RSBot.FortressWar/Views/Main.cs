using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RSBot.Core;
using RSBot.Core.Components;
using RSBot.Core.Objects.Spawn;

using RSBot.Core.Event;
using RSBot.Core.Objects;
using RSBot.FortressWar.Bundle.CommandCore;
using RSBot.FortressWar.Bundle.Commands;

namespace FortressWar.Views
{
    public partial class Main : UserControl
    {
        //
        //Command Dictionary for chat commands
        //
        public Dictionary<string, ICommand> Commands = new Dictionary<string, ICommand>();
        
        public Main()
        {            
            InitializeComponent();
            InitializeCommands();
            CheckForIllegalCrossThreadCalls = false;
            SubscribeEvents();
           
        }

        //
        //Add a name to the List view
        //
        private void addToListBtn_Click(object sender, EventArgs e)
        {
            string row = playnameTextBox.Text;
            var listViewItem = new ListViewItem(row);
            tracePlayerList.Items.Add(listViewItem);
            var list = tracePlayerList.Items.Cast<ListViewItem>().Select(item => item.Text).ToArray();
            PlayerConfig.SetArray("RSBot.FortressWar.commandList",list);
            PlayerConfig.Save();
        }

        private void SubscribeEvents()
        {
            EventManager.SubscribeEvent("OnEnterGame", OnEnterGame);
            EventManager.SubscribeEvent("OnKillSelectedEnemy",SelectNewTarget);
            EventManager.SubscribeEvent("OnDespawnEntity",SelectNewTarget);
            EventManager.SubscribeEvent("OnSpawnPlayer",SelectNewTarget);
        }

        private void SelectNewTarget()
        {
            if (Game.Player.State.LifeState == LifeState.Dead)
                return;
            
            aiSelectingTarget();
        }

        private void OnEnterGame()
        {
            foreach (var str in  PlayerConfig.GetArray<string>("RSBot.FortressWar.commandList"))
            {
                tracePlayerList.Items.Add(str);
            }
            foreach (var str in  PlayerConfig.GetArray<string>("RSBot.FortressWar.TargetLeaderList"))
            {
                targetLeaderList.Items.Add(str);
            }
            
        }
        
        //
        //Initializing Commands 
        //
        private void InitializeCommands()
        {
          Commands.Add("trace",new TraceCommand());
          Commands.Add("move", new MoveCommand());
          Commands.Add("struc", new StructureCommand());
        }

        private void addToTargetListBtn_Click(object sender, EventArgs e)
        {
            string row = targetLeaderTextBox.Text;
            var listViewItem = new ListViewItem(row);
            targetLeaderList.Items.Add(listViewItem);
            var list = targetLeaderList.Items.Cast<ListViewItem>().Select(item => item.Text).ToArray();
            PlayerConfig.SetArray("RSBot.FortressWar.TargetLeaderList",list);
            PlayerConfig.Save();         
        }
        private void menuRemove_Remove(object sender, EventArgs e)
        {
            if (tracePlayerList.SelectedItems.Count ==1)
            {
                tracePlayerList.Items.Remove(tracePlayerList.SelectedItems[0]);
                var list = tracePlayerList.Items.Cast<ListViewItem>().Select(item => item.Text).ToArray();
                PlayerConfig.SetArray("RSBot.FortressWar.commandList",list);
                PlayerConfig.Save(); 
            }
            
        }
        private void menuRemoveTarget_Remove(object sender, EventArgs e)
        {
            if (targetLeaderList.SelectedItems.Count ==1)
            {
                targetLeaderList.Items.Remove(targetLeaderList.SelectedItems[0]);
                var list = targetLeaderList.Items.Cast<ListViewItem>().Select(item => item.Text).ToArray();
                PlayerConfig.SetArray("RSBot.FortressWar.TargetLeaderList",list);
                PlayerConfig.Save();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aiSelectingTarget();
        }

        private void aiSelectingTarget()
        {
            SpawnManager.TryGetEntities<SpawnedPlayer>(out var spawnedPlayers);
            var players = spawnedPlayers.ToList();
            foreach (var player in players)
            {
                if (player.Guild.IsFriendly)
                {
                    continue;
                }
                // change again
                var hasDefensiveBuff = player.State.ActiveBuffs.Where(info =>
                    info.Record.GetRealName().Contains("skin")
                    || info.Record.GetRealName().Contains("fence")
                    || info.Record.GetRealName().Contains("pain")
                    || info.Record.GetRealName().Contains("bless")
                    || info.Record.GetRealName().Contains("snow shield")
                    || info.Record.GetRealName().Contains("screen")
                    || info.Record.GetRealName().Contains("bloody"));
                
                if (hasDefensiveBuff.Any())
                {
                    continue;
                }
                Game.Player.SelectEntity(player.UniqueId);
                Log.Notify("[AI-Targeting] selected "+player.Name + "[no buffs]");
                if (player == players.Last())
                {
                    var attPlayer = players.Find(attackingPlayer => player.AttackingPlayer);
                    Log.Notify("[AI-Targeting] selected "+player.Name + "[attacking player]");
                    Game.Player.SelectEntity(attPlayer.UniqueId);
                }

            }
        }
    }
}