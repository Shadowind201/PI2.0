using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using static System.Net.Mime.MediaTypeNames;

namespace PI2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Drawing.Image[] imagens = new System.Drawing.Image[]
{
                System.Drawing.Image.FromFile("c:\\jogos\\1jc13gwmn0n.jpg"),
                System.Drawing.Image.FromFile("c:\\jogos\\apex.jpg"),
                System.Drawing.Image.FromFile("c:\\jogos\\death_stranding.jpg"),
                System.Drawing.Image.FromFile("c:\\jogos\\fort.jpg"),
                System.Drawing.Image.FromFile("c:\\jogos\\hollow knghit.jpg"),
                System.Drawing.Image.FromFile("c:\\jogos\\the_isle.jpg"),
};
            Random geradorAleatorio = new Random();
            int indiceAleatorio = geradorAleatorio.Next(0, imagens.Length);

            picBanner.Image = imagens[indiceAleatorio];
        }
      private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
