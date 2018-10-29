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
            UpdateList();
            lblTitleIn.Text = "";
            lblAuthorIn.Text = "";
            lblTitleOut.Text = "";
            lblAuthorOut.Text = "";
            lblDate.Text = "";
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            LoadSave.UpdateLibraryFile();
            DialogResult dialog = MessageBox.Show("Library file updated! Press ok to close.");
            Close();
        }


        private void lstLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Book b in Program.Library)
            {
                if (b.Title == lstLibrary.SelectedItem.ToString())
                {
                    lblTitleIn.Text = b.Title;
                    lblAuthorIn.Text = b.Author;
                    break;
                }
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string newTitle = txtTitle.Text;
            string newAuthor = txtAuthor.Text;
            if (newTitle != "" && newAuthor != "")
            {
                Book newBook = new Book(newTitle, newAuthor);
                Program.Library.Add(newBook);
                DialogResult result = MessageBox.Show("Added!");
                UpdateList();
            }
            else
            {
                DialogResult result = MessageBox.Show("Please input valid Title and Author!");
            }
            
        }
        private void UpdateList()
        {
            lstLibrary.Items.Clear();
            lstCheckedOut.Items.Clear();
            foreach (Book b in Program.Library)
            {
                if (!b.Status)
                {
                    lstLibrary.Items.Add(b.Title);
                }
                else
                {
                    lstCheckedOut.Items.Add(b.Title);
                }
                
            }
        }

        private void UpdateListTitle(string userInput)
        {
            lstLibrary.Items.Clear();
            lstCheckedOut.Items.Clear();
            foreach (Book b in Program.Library)
            {
                if (b.Title.ToLower().Contains(userInput.ToLower()))
                {
                    if (!b.Status)
                    {
                        lstLibrary.Items.Add(b.Title);
                    }
                    else
                    {
                        lstCheckedOut.Items.Add(b.Title);
                    }
                }
            }
        }
        private void UpdateListAuthor(string userInput)
        {
            lstLibrary.Items.Clear();
            lstCheckedOut.Items.Clear();
            foreach (Book b in Program.Library)
            {
                if (b.Author.ToLower().Contains(userInput.ToLower()))
                {
                    if (!b.Status)
                    {
                        lstLibrary.Items.Add(b.Title);
                    }
                    else
                    {
                        lstCheckedOut.Items.Add(b.Title);
                    }
                }
            }
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchTitle_Click(object sender, EventArgs e)
        {
            string userInput = txtSearch.Text;
            if (userInput == "")
            {
                DialogResult result = MessageBox.Show("Please input text");
            }
            else
            {
                UpdateListTitle(userInput);
            }
        }

        private void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            string userInput = txtSearch.Text;
            if (userInput == "")
            {
                DialogResult result = MessageBox.Show("Please input text");
            }
            else
            {
                UpdateListAuthor(userInput);
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Book b in Program.Library)
                {
                    if (b.Title == lstLibrary.SelectedItem.ToString())
                    {
                        b.Status = true;
                        b.DueDate = DateTime.Now;
                        b.DueDate = b.DueDate.AddDays(14);
                        DialogResult dialog = MessageBox.Show(b.Title + " has been checked out. Due date is " + b.DueDate);
                        break;
                    }
                }
                UpdateList();
            }
            catch
            {
                DialogResult dialog = MessageBox.Show("Please select a book from the correct list");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Book b in Program.Library)
                {
                    if (b.Title == lstCheckedOut.SelectedItem.ToString())
                    {
                        b.Status = false;
                        DateTime defaultDate = new DateTime(2099, 12, 31);
                        b.DueDate = defaultDate;
                        DialogResult dialog = MessageBox.Show(b.Title + " has been checked in!");
                        break;
                    }
                }
                UpdateList();
            }
            catch
            {
                DialogResult dialog = MessageBox.Show("Please select a book from the correct list");
            }
        }

        private void lstCheckedOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (Book b in Program.Library)
                {
                    if (b.Title == lstCheckedOut.SelectedItem.ToString())
                    {
                        lblTitleOut.Text = b.Title;
                        lblAuthorOut.Text = b.Author;
                        lblDate.Text = b.DueDate.ToShortDateString();
                        break;
                    }
                }
            }
            catch
            {
                DialogResult dialog = MessageBox.Show("Andrea broke it");
            }
        }
    }
}
