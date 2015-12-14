using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
namespace PhoneBookv2
{
    public partial class Main_Form : Form
    {
        private IUnit_of_work Unit_of_work = new Unit_of_Work();
        public Main_Form()
        {
            InitializeComponent();
            Unit_of_work.Persons.Load();
            dataGridView1.DataSource = Unit_of_work.Persons.Binding();

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            
            Add_change_Form addChangeForm = new Add_change_Form();
            addChangeForm.ShowDialog();
            if(addChangeForm.Person != null)
            Unit_of_work.Persons.Create(addChangeForm.Person);
            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView) sender;
            if (e.RowIndex > -1)
            {
                dataGridView2.Rows.Clear();
                foreach (
                    var VARIABLE in
                        Unit_of_work.Persons.Get(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value)).Phones)
                {
                    dataGridView2.Rows.Add(VARIABLE.Number, VARIABLE.DescriptionNumber);
                }

                if (e.ColumnIndex > 0 && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn )
                {
                    Add_change_Form Change =
                        new Add_change_Form(
                            Unit_of_work.Persons.Get(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value)));
                    Change.ShowDialog();
                    Unit_of_work.Persons.Update(Unit_of_work.Persons.Get(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value)));
                    dataGridView1.Update();
                    dataGridView2.Update();
                }
            }
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            Unit_of_work.Save();
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {

        }
    }
}
