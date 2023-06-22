using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.classes;
namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        context context;
        public Form2()
        {
            InitializeComponent();
            context = new context();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
                if (context.workers.FromSqlRaw("SELECT * FROM workers WHERE telephone = {0} AND role ='admin' ", textBoxLogin.Text).ToList().Count != 0)
                {
                    worker Admin = context.workers.FromSqlRaw("SELECT * FROM workers WHERE telephone = {0} AND role ='admin' ", textBoxLogin.Text).ToList()[0];
                    if (Admin.password == textBox2.Text)
                    {
                        Hide();
                        new Form5().ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль");
                    }
                }
                else
                {
                    
                  MessageBox.Show("Администратор не найден");
                    
                }
        }
        
    }
}
