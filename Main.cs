using TecnoService.Context;

namespace TecnoService
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            INITGRID();
        }

        private void INITGRID()
        {
            using (var db = new TechnoserviceContext())
            {
                var requests = db.Requests.ToList();

                foreach (var reqests in requests)
                {
                    var equipTypes = db.EquipmentTypes.FirstOrDefault(x => x.Id == reqests.EqupmentTypeId);
                    var malfunction = db.Malfunctions.FirstOrDefault(x => x.Id == reqests.MalfunctionId);
                    var usersss = db.Users.FirstOrDefault(x => x.Id == reqests.ClientId);
                    var master = db.Staff.FirstOrDefault(x => x.Id == reqests.Id);

                    var userControl = new UserControl1(reqests, equipTypes, malfunction, usersss, master);
                    userControl.Parent = flowLayoutPanel1;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditADd editADd = new EditADd();
            editADd.ShowDialog();

            
        }
    }
}
