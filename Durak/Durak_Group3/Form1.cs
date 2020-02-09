using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Durak_Group3
{
    public partial class frmInGame : Form
    {
        public List<PictureBox> ourDeck = new List<PictureBox>(); 

        public frmInGame()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmInGame_Load(object sender, EventArgs e)
        {
            Deck theDeck = new Deck(52, this);
            Player thePlayer = new Player();
            Player ai = new Player();
            theDeck.Deal(thePlayer, ai);
        }
    }
}
