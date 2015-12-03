using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadTest
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Game1 game = new Game1(this.pictureBox_Left.Handle, this, this.pictureBox_Left);
            Task task = Task.Run(() => { game.Run(); });
        }
    }
}
