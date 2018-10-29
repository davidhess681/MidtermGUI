using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Midterm;

namespace MidtermGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Book b in Program.Library)
            {
                lstLibrary.Items.Add(b.Title);
            }
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            LoadSave.UpdateLibraryFile();
            DialogResult dialog = MessageBox.Show("Library file updated! Press ok to close.");
            Close();
        }


        private void lstLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
