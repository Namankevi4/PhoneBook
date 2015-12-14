using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBookv2
{
    public partial class Add_change_Form : Form
    {
        public Person Person = new Person();
        public Add_change_Form()
        {
            InitializeComponent();
        }
        public Add_change_Form(Person person)
        {
            InitializeComponent();
            this.Text = "Change";
            Add_button.Text = "Change";
            textBox1.Text = person.Name;
            textBox2.Text = person.Surname;
            textBox3.Text = person.Email;
            textBox4.Text = person.Skype;
            foreach (var variable in person.Phones)
            {
                dataGridView1.Rows.Add(variable.Number, variable.DescriptionNumber);
            }
            Person = person;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            
            Person.Name = textBox1.Text;
            Person.Surname = textBox2.Text;
            Person.Email = textBox3.Text;
            Person.Skype = textBox4.Text;
            dataGridView1.AllowUserToAddRows = false;
            
            foreach (DataGridViewRow variable in dataGridView1.Rows)
            {
                Person.Phones.Add(new Phone() { Number = Convert.ToInt32(variable.Cells[0].Value), DescriptionNumber = variable.Cells[1].Value.ToString(), PersonId = Person.Id});
            }
            this.Close();
        }
    }
}
