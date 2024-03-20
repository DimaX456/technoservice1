using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TecnoService.Context;
using TecnoService.Models;

namespace TecnoService
{
    public partial class EditADd : Form
    {
        private readonly Requests requests;
        public Requests request => requests;

        public EditADd()
        {
            InitializeComponent();
            Text = "Добавть продукт";
            button1.Text = "Добавить продукт";
            this.requests = new Requests();
            label1.Visible = false;
            comboBox4.Visible = false;
        }




        public EditADd(Requests requests) : this()
        {
            Text = "Изменить продукт";
            button1.Text = "Изменить";
            this.requests = requests;
            label1.Visible = true;
            comboBox4.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new TechnoserviceContext())
            {
                Requests requests = new Requests()
                {
                    Date = Convert.ToDateTime(maskedTextBox1.Text),
                    Description = textBox5.Text,
                    Status = textBox7.Text,
                    MalfunctionId = ((Malfunctions)comboBox2.SelectedItem).Id,
                    EqupmentTypeId = ((EquipmentTypes)comboBox3.SelectedItem).Id,
                    ClientId = ((Users)comboBox1.SelectedItem).Id,

                };

                db.Requests.Add(requests);
                db.SaveChanges();


                this.Close();









            }


        }

        private void EditADd_Load(object sender, EventArgs e)
        {
            using (var db = new TechnoserviceContext())
            {
                var types = db.Malfunctions.OrderBy(x => x.Name);

                comboBox2.DisplayMember = nameof(Malfunctions.Name);
                comboBox2.ValueMember = nameof(Malfunctions.Id);

                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(types.ToArray());

                comboBox2.SelectedIndex = 0;




                var users = db.Users.OrderBy(x => x.Name);

                comboBox1.DisplayMember = nameof(Users.Name);
                comboBox1.ValueMember = nameof(Users.Id);

                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(users.ToArray());
                comboBox1.SelectedIndex = 0;


                var ET = db.EquipmentTypes.OrderBy(x => x.Name);

                comboBox3.DisplayMember = nameof(EquipmentTypes.Name);
                comboBox3.ValueMember = nameof(EquipmentTypes.Id);

                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(ET.ToArray());
                comboBox3.SelectedIndex = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
