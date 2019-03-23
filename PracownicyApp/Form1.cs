using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracownicyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pracownicyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pracownicyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kurs_2_2019DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kurs_2_2019DataSet.Pracownicy' table. You can move, or remove it, as needed.
            this.pracownicyTableAdapter.Fill(this.kurs_2_2019DataSet.Pracownicy);

        }
    }
}
