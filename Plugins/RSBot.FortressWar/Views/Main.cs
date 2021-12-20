using System;
using System.Windows.Forms;
using RSBot.Core;
using RSBot.Core.Event;




namespace RSBot.FortressWar.Views
{
    public partial class Main : UserControl
    {
        public Main()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

            
        }

        private void button1_click(object sender, EventArgs e)
        {
            Bundles.Attack.Invoke();
        }
    }
}