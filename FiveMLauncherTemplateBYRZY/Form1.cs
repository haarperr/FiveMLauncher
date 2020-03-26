using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveMLauncherTemplateBYRZY
{
    public partial class Form1 : Form
    {

        /* Voila, pas plus compliqué. On 3 process.start et un petit design de fils de pute et certains font payer ça :^)
        Arretez d'éssayer de vendre des choses comme ça, ça va rien vous apporter et ne vous sentez pas dev en faisant ça, svp.
        Bon ça faisait un bon moment j'avais pas lancé VS et j'ai un un peu de mal en sah j'ai tous les automatisme du lua maintenant, et plus du C# rip..
        Faites vous plaisir, dédi au poto plot pour le framework du design.
        PS: Inutile de vendre, ça sert à rien.
             */ 
        public Form1()
        {
            InitializeComponent();
            // on rend les deux picture box transparente et ayant pour fond la picturebox1
            pictureBox1.Controls.Add(pictureBox2);
            pictureBox1.Controls.Add(pictureBox3);

            pictureBox2.Location = new Point(5, 337);
            pictureBox2.BackColor = Color.Transparent;

            pictureBox3.Location = new Point(113, 337);
            pictureBox3.BackColor = Color.Transparent;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://top-serveurs.net/");
        }

        private void connectbtn_Click(object sender, EventArgs e)
        {
            Process.Start("Explorer.exe", "fivem://connect/51.38.215.133:27035");
        }
    }
}
