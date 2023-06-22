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
    public partial class Form1 : Form
    {
        context context;
        public Form1()
        {
            InitializeComponent();
            context = new context();
        }
        public void AddApplications()
        {
            listView1.Items.Clear();
            foreach (var application in context.application)
            {
                ListViewItem item = new ListViewItem(application.id.ToString());
                item.SubItems.Add(application.type);
                item.SubItems.Add(application.timestart.ToString());
                item.SubItems.Add(application.timeend.ToString());
                item.SubItems.Add(application.price.ToString());
                item.SubItems.Add(application.status);
                item.SubItems.Add(application.idworker.ToString());
                item.SubItems.Add(application.idkart.ToString());
                item.SubItems.Add(application.idequipment.ToString());
                item.SubItems.Add(application.idcenter.ToString());
                item.SubItems.Add(application.idclient.ToString());
                listView1.Items.Add(item);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddApplications();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                string W = listView1.Items[(listView1.SelectedItems[0].Index)].SubItems[0].Text;
                var application = context.application.Find(int.Parse(W));
                application.status = "Принята";
                application.idworker = Convert.ToInt32(numericUpDown1.Value);
                application.idkart = Convert.ToInt32(numericUpDown2.Value);
                application.idequipment = Convert.ToInt32(numericUpDown4.Value);
                context.SaveChanges();
                MessageBox.Show("Заявка принята");
                AddApplications();
            }
            else
            {
                MessageBox.Show("Не выбран элемент!");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (var application in context.application)
            {
                if (application.status == comboBox3.Text)
                {
                    ListViewItem item = new ListViewItem(application.id.ToString());
                    item.SubItems.Add(application.type);
                    item.SubItems.Add(application.timestart.ToString());
                    item.SubItems.Add(application.timeend.ToString());
                    item.SubItems.Add(application.price.ToString());
                    item.SubItems.Add(application.status);
                    item.SubItems.Add(application.idworker.ToString());
                    item.SubItems.Add(application.idkart.ToString());
                    item.SubItems.Add(application.idequipment.ToString());
                    item.SubItems.Add(application.idcenter.ToString());
                    item.SubItems.Add(application.idclient.ToString());
                    listView1.Items.Add(item);
                    context.SaveChanges();
                }
            }
            context.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                string W = listView1.Items[(listView1.SelectedItems[0].Index)].SubItems[0].Text;
                var application = context.application.Find(int.Parse(W));
                context.application.Remove(application);
                context.SaveChanges();
                MessageBox.Show("Удалено");
                AddApplications();
            }
            else
            {
                MessageBox.Show("Не выбран элемент!");
            }
        }
    }
}
