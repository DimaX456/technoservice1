using TecnoService.Context;
using TecnoService.Models;

namespace TecnoService
{
    public partial class UserControl1 : UserControl
    {
        private readonly Requests requests;
        private readonly EquipmentTypes equipmentTypes;
        private readonly Malfunctions malfunctions;
        private readonly Users users1;
        private readonly Staff staff;
        public UserControl1(Requests requests, EquipmentTypes equipmentTypes,
            Malfunctions malfunctions, Users users, Staff staff)
        {
            InitializeComponent();
            this.requests = requests;
            this.equipmentTypes = equipmentTypes;
            this.malfunctions = malfunctions;
            this.users1 = users;

            initgrid(requests, equipmentTypes, malfunctions, users,staff);
            this.staff = staff;
        }

        private void initgrid(Requests requests, EquipmentTypes equipmentTypes,
            Malfunctions malfunctions, Users users, Staff staff)
        {
            using (var db = new TechnoserviceContext())
            {
                label1.Text = $"Номер закза: {requests.Id}";
                label2.Text = $"Дата добовление: {requests.Date}";
                label3.Text = $"Оборудование: {equipmentTypes.Name}";
                label4.Text = $"Тип неисправности: {malfunctions.Name}";
                label5.Text = $"Описание проблемы: {requests.Description}";
                label6.Text = $"Клиент который подал заявку: {users.Name}";
                label7.Text = $"Статус заявки: {requests.Status}";
                label8.Text = $"Мастер отвественный за работу:{staff.FullName}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new TechnoserviceContext())
            {
                var productdb = db.Requests.FirstOrDefault(x => x.Id == requests.Id);
                var productEdit = new EditADd(productdb);
                var result=productEdit.ShowDialog();
                if (result == DialogResult.OK)
                {
                    db.SaveChanges();
                   
                }
            }
        }
    }
}
