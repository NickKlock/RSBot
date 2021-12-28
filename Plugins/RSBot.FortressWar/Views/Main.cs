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
        private SpawnedPlayer _selectedPlayer;
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
            EventManager.SubscribeEvent("OnDespawnEntity", new Action<SpawnedEntity>(DeSpawnEntity));
            EventManager.SubscribeEvent("OnSpawnPlayer",SelectNewTarget);
        }



        private void DeSpawnEntity(SpawnedEntity despawEntity)
        {
            if (aiTargetingCheckbox.Checked && !targetSupportCheckBox.Checked)
            {
                if (despawEntity.UniqueId == _selectedPlayer.UniqueId)
                {
                    Game.Player.DeselectEntity();
                }
            }
            
        }


        private void SelectNewTarget()
        {
            if (Kernel.Bot.Running)
                return;
            
            
            if (Game.Player.State.LifeState == LifeState.Dead)
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
            var stateActiveBuffs = Game.SelectedEntity.Entity.State.ActiveBuffs;
            foreach (var stateActiveBuff in stateActiveBuffs)
            {
                Log.Notify(stateActiveBuff.Record.GetRealName());
            }
        }

        private void AiSelectingTarget()
        {
            if (_selectedPlayer != null)
            {
                if (_selectedPlayer.UniqueId == Game.Player.UniqueId)
                {
                    Reset();
                }
                if (HasDefBuff(_selectedPlayer) || HasScreenOrskin(_selectedPlayer)) 
                {
                    Reset();
                }
                if (_selectedPlayer.State.LifeState == LifeState.Dead)
                {
                    Reset();
                } 
                if (_selectedPlayer.Tracker.Position.DistanceTo(Game.Player.Tracker.Position) >= 40)
                {
                    Reset();
                }

                if (_selectedPlayer.State.BodyState == BodyState.Berzerk 
                    || _selectedPlayer.State.BodyState == BodyState.Hwan 
                    && radioZerkers.Checked)
                {
                    Game.Player.SelectEntity(_selectedPlayer.UniqueId);

                }
                
                if (radioGuildlist.Checked && 
                    listFriendlyGuilds.Items.Cast<ListViewItem>()
                        .Select(item => item.Text).ToList().Contains(_selectedPlayer.Guild.Name))
                {
                    Reset();
                }
                else
                {
                    Game.Player.SelectEntity(_selectedPlayer.UniqueId);
                    return;
                }
            }
            List<SpawnedPlayer> noBuffPlayers = new List<SpawnedPlayer>();
            
            SpawnManager.TryGetEntities<SpawnedPlayer>(out var spawnedPlayers);
            foreach (var player in spawnedPlayers)
            {
                /*if (player.Guild.IsFriendly)
                {                
                    Log.Notify("Is Friendly : "+player.Name);
                    continue;
                }*/

                if (radioGuildlist.Checked && listFriendlyGuilds.Items.Cast<ListViewItem>()
                    .Select(item => item.Text).ToList().Contains(player.Guild.Name))
                    continue;
                

                if (radioZerkers.Checked 
                     && player.State.BodyState == BodyState.Berzerk 
                     || player.State.BodyState == BodyState.Hwan)
                 {
                     Game.Player.SelectEntity(player.UniqueId);
                     _selectedPlayer = player;
                     Log.Notify("[AI-Targeting] selected "+player.Name + "[Zerking]");
                     return;
                 }
                
                
                if (HasDefBuff(player)|| HasScreenOrskin(player))
                    continue;
                

                switch (Game.Player.JobInformation.Type)
                {
                    case JobType.Hunter:
                    case JobType.Trade:
                        if (player.Job == JobType.Hunter || player.Job == JobType.Trade)
                            continue;
                        
                        break;
                    case JobType.Thief:
                        if (player.Job == JobType.Thief)
                            continue;
                        
                        break;
                }
                noBuffPlayers.Add(player);
                
                
            }

            var orderedEnumerable = noBuffPlayers
                .OrderBy(p => p.Tracker.Position.DistanceTo(Game.Player.Tracker.Position));

            _selectedPlayer = orderedEnumerable.First();
            Game.Player.SelectEntity(orderedEnumerable.First().UniqueId);
            Log.Notify("[AI-Targeting] selected "+orderedEnumerable.First().Name + "[no buffs]");
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
            if (targetSupportCheckBox.Checked)
            {
                targetSupportCheckBox.Checked = !aiTargetingCheckbox.Checked;
            }

            if (Game.SelectedEntity != null)
            {
                Game.Player.DeselectEntity();
                _selectedPlayer = null;
            }
            PlayerConfig.Set("RSBot.FortressWar.AiTargeting",aiTargetingCheckbox.Checked);
            PlayerConfig.Set("RSBot.FortressWar.UseTargetSupport",targetSupportCheckBox.Checked);

        }

        private void chatCommandChatBox_CheckedChanged(object sender, EventArgs e)
        {
            PlayerConfig.Set("RSBot.FortressWar.UseChatCommands",chatCommandChatBox.Checked);
            PlayerConfig.Save();

        }

        private void targetSupportCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (aiTargetingCheckbox.Checked)
            {
                aiTargetingCheckbox.Checked = !targetSupportCheckBox.Checked;
            }
            PlayerConfig.Set("RSBot.FortressWar.UseTargetSupport",targetSupportCheckBox.Checked);
            PlayerConfig.Set("RSBot.FortressWar.AiTargeting",aiTargetingCheckbox.Checked);

        }

        private void LoadConfig()
        {
            aiTargetingCheckbox.Checked = PlayerConfig.Get("RSBot.FortressWar.AiTargeting",true);
            chatCommandChatBox.Checked = PlayerConfig.Get<bool>("RSBot.FortressWar.UseChatCommands");
            targetSupportCheckBox.Checked = PlayerConfig.Get<bool>("RSBot.FortressWar.UseTargetSupport");
            radioGuildlist.Checked = PlayerConfig.Get<bool>("RSBot.FortressWar.IgnoreFriendlyGuilds");
            radioZerkers.Checked = PlayerConfig.Get<bool>("RSBot.FortressWar.TargetZerkersFirst");
            
            foreach (var str in  PlayerConfig.GetArray<string>("RSBot.FortressWar.commandList"))
            {
                tracePlayerList.Items.Add(str);
            }
            foreach (var str in  PlayerConfig.GetArray<string>("RSBot.FortressWar.TargetLeaderList"))
            {
                targetLeaderList.Items.Add(str);
            }
            foreach (var str in  PlayerConfig.GetArray<string>("RSBot.FortressWar.FriendlyGuilds"))
            {
                listFriendlyGuilds.Items.Add(str);
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

        private void Reset()
        {
            if (Game.SelectedEntity != null)
            {
                Game.Player.DeselectEntity();
            }
            _selectedPlayer = null;
        }

        private void btnAddFriendlyGuild_Click(object sender, EventArgs e)
        {
            string row = txtFriendlyGuild.Text;
            var listViewItem = new ListViewItem(row);
            listFriendlyGuilds.Items.Add(listViewItem);
            var list = listFriendlyGuilds.Items.Cast<ListViewItem>().Select(item => item.Text).ToArray();
            PlayerConfig.SetArray("RSBot.FortressWar.FriendlyGuilds",list);
            PlayerConfig.Save();   
        }

        private void radioZerkers_CheckedChanged(object sender, EventArgs e)
        {
            PlayerConfig.Set("RSBot.FortressWar.TargetZerkersFirst",radioZerkers.Checked);

        }

        private void radioGuildlist_CheckedChanged(object sender, EventArgs e)
        {
            PlayerConfig.Set("RSBot.FortressWar.IgnoreFriendlyGuilds",radioGuildlist.Checked);
        }
    }
}