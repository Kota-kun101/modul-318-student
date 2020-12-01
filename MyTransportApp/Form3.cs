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

namespace MyTransportApp
{
    public partial class Form3 : Form
    {
        string txt_body;
        public Form3(string body)
        {
            InitializeComponent();
            txt_body = body;
        }

        private void btn_teilen_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(
                    "mailto:" + inputEmail.Text +
                    "?subject=" + "Verbindung Teilen" +
                    "&body=" + txt_body
                    );
                Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
