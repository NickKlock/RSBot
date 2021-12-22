using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RSBot.Core;
using RSBot.Core.Components;
using RSBot.Core.Event;
using RSBot.Core.Objects;
using RSBot.Core.Objects.Spawn;
using RSBot.FortressWar.Bundle.Commands;

namespace FortressWar.Views
{
    public partial class Main : UserControl
    {
        //
        //Command Dictionary for chat commands
        //
        public Dictionary<string, ICommand> Commands = new Dictionary<string, ICommand>();
        private SpawnedPlayer _selectedPlayer = null;
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
            EventManager.SubscribeEvent("OnTick", SelectNewTarget);
        }
        

        private void SelectNewTarget()
        {

            if (Game.Player.State.LifeState == LifeState.Dead)
                return;

            if (Kernel.Bot.Running)
                return;
            if (aiTargetingCheckbox.Checked && !targetSupportCheckBox.Checked)
            {
                AiSelectingTarget();
                return;
            }
            
            if (!aiTargetingCheckbox.Checked && targetSupportCheckBox.Checked)
            {
                TargetSupport();
            }
        }

        private void OnEnterGame()
        {
            LoadConfig();
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
            if (Game.SelectedEntity == null)
                return;
            
            Game.Player.TargetSupport(Game.SelectedEntity.UniqueId);
        }

        private void AiSelectingTarget()
        {
            if (_selectedPlayer != null)
            {
                if (_selectedPlayer.UniqueId == Game.Player.UniqueId)
                {
                    _selectedPlayer = null;
                }
                if (HasDefBuff(_selectedPlayer) || HasScreenOrskin(_selectedPlayer))
                {
                    _selectedPlayer = null;
                }
                else
                {
                    Game.Player.SelectEntity(_selectedPlayer.UniqueId);
                    return;
                }
            }
            
            SpawnManager.TryGetEntities<SpawnedPlayer>(out var spawnedPlayers);
            var players = spawnedPlayers.ToList();
            foreach (var player in players)
            {
                if (player.Guild.IsFriendly)
                {
                    continue;
                }

                if (HasDefBuff(player)|| HasScreenOrskin(player))
                {
                    continue;
                }

                _selectedPlayer = player;
                Game.Player.SelectEntity(player.UniqueId);
                Log.Notify("[AI-Targeting] selected "+player.Name + "[no buffs]");
                
                /*
                if (player.State.BodyState == BodyState.Berzerk || player.State.BodyState == BodyState.Hwan && !hasScreenOrSkin.Any() )
                {
                    Game.Player.SelectEntity(player.UniqueId);
                    Log.Notify("[AI-Targeting] selected "+player.Name + "[Zerking]"); 
                }*/

                
            }
        }


        private void TargetSupport()
        {
            SpawnManager.TryGetEntities<SpawnedPlayer>(out var spawnedPlayers);
            foreach (var spawnedPlayer in spawnedPlayers)
            {
                if (spawnedPlayer.Name.Equals(targetLeaderList.Items[0].Text))
                {
                    Game.Player.TargetSupport(spawnedPlayer.UniqueId);
                }
            }
        }

        private void aiTargetingCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            targetSupportCheckBox.Checked = !aiTargetingCheckbox.Checked;
            PlayerConfig.Set("RSBot.FortressWar.AiTargeting",aiTargetingCheckbox.Checked);
            
        }

        private void chatCommandChatBox_CheckedChanged(object sender, EventArgs e)
        {
            PlayerConfig.Set("RSBot.FortressWar.UseChatCommands",chatCommandChatBox.Checked);
            PlayerConfig.Save();

        }

        private void targetSupportCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            aiTargetingCheckbox.Checked = !targetSupportCheckBox.Checked;
            PlayerConfig.Set("RSBot.FortressWar.UseTargetSupport",targetSupportCheckBox.Checked);
        }

        private void LoadConfig()
        {
            aiTargetingCheckbox.Checked = PlayerConfig.Get("RSBot.FortressWar.AiTargeting",true);
            chatCommandChatBox.Checked = PlayerConfig.Get<bool>("RSBot.FortressWar.UseChatCommands");
            targetSupportCheckBox.Checked = PlayerConfig.Get<bool>("RSBot.FortressWar.UseTargetSupport");
            
            foreach (var str in  PlayerConfig.GetArray<string>("RSBot.FortressWar.commandList"))
            {
                tracePlayerList.Items.Add(str);
            }
            foreach (var str in  PlayerConfig.GetArray<string>("RSBot.FortressWar.TargetLeaderList"))
            {
                targetLeaderList.Items.Add(str);
            }

        }

        private bool HasDefBuff(SpawnedPlayer player)
        {
            var hasDefensiveBuff = player.State.ActiveBuffs.Where(info =>
                info.Record.GetRealName().ToLower().Contains("fence")
                || info.Record.GetRealName().ToLower().Contains("pain")
                || info.Record.GetRealName().ToLower().Contains("bless")
                || info.Record.GetRealName().ToLower().Contains("snow shield")
                || info.Record.GetRealName().ToLower().Contains("bloody"));

            return hasDefensiveBuff.Any();
        }
        
        private bool HasScreenOrskin(SpawnedPlayer player)
        {
            var hasScreenOrSkin = player.State.ActiveBuffs.Where(info =>
                info.Record.GetRealName().ToLower().Contains("screen") || 
                info.Record.GetRealName().ToLower().Contains("skin"));

            return hasScreenOrSkin.Any();
        }
    }
}