using TecnoService.Context;

namespace TecnoService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new TechnoserviceContext())
            {
               var Access = db.Users.FirstOrDefault(x => x.Login == textBox1.Text && x.Password == textBox2.Text);
                
                if(Access != null)
                {
                    Main main = new Main(); 
                    main.Show();    
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                    return;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
        }
    }
}
