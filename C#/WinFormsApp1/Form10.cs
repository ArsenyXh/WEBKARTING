using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.classes;

namespace WinFormsApp1
{
    public partial class Form10 : Form
    {

        context context;
        public Form10()
        {
            InitializeComponent();
            context = new context();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (context.workers.FromSqlRaw("SELECT * FROM workers WHERE telephone = {0}", textBox3.Text).ToList().Count == 0)
            {
                worker Worker = new worker();
                Worker.name = textBox1.Text;
                Worker.role = "marshal";
                Worker.surname = textBox2.Text;
                Worker.telephone = textBox3.Text;
                Worker.password = textBox8.Text;
                context.workers.Add(Worker);
                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Пользователь с таким номером телефона уже существует");
            }
            AddWorker();
            context.SaveChanges();
        }

        public void AddWorker()
        {
            listView1.Items.Clear();
            foreach (var worker in context.workers)
            {
                if (worker.role == "marshal")
                {
                    ListViewItem item = new ListViewItem(worker.id.ToString());
                    item.SubItems.Add(worker.name);
                    item.SubItems.Add(worker.surname);
                    item.SubItems.Add(worker.telephone);
                    item.SubItems.Add(worker.password);
                    listView1.Items.Add(item);
                }
            }
            context.SaveChanges();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                string W = listView1.Items[(listView1.SelectedItems[0].Index)].SubItems[0].Text;
                worker Worker = context.workers.FromSqlRaw("SELECT * FROM workers WHERE Id = {0}", int.Parse(W)).ToList()[0];
                context.workers.Remove(Worker);
                context.SaveChanges();
                MessageBox.Show("Удалено");
                AddWorker();
            }
            else
            {
                MessageBox.Show("Не выбран элемент!");
            }
            context.SaveChanges();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddWorker();
            context.SaveChanges();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
