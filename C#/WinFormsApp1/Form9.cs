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
    public partial class Form9 : Form
    {
        context context;
        public Form9()
        {
            InitializeComponent();
            context = new context();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public void AddKart()
        {
            listView1.Items.Clear();
            foreach (var kart in context.karts)
            {
                ListViewItem item = new ListViewItem(kart.id.ToString());
                item.SubItems.Add(kart.type);
                listView1.Items.Add(item);
            }
            context.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kart Kart = new kart();
            Kart.type = textBox1.Text;
            context.karts.Add(Kart);
            context.SaveChanges();
            AddKart();
            context.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                string W = listView1.Items[(listView1.SelectedItems[0].Index)].SubItems[0].Text;
                kart Kart = context.karts.FromSqlRaw("SELECT * FROM karts WHERE id = {0}", int.Parse(W)).ToList()[0];
                context.karts.Remove(Kart);
                context.SaveChanges();
                MessageBox.Show("Удалено");
                AddKart();
                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Не выбран элемент!");
            }
            context.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddKart();
            context.SaveChanges();
        }
        public void AddEquipment()
        {
            listView2.Items.Clear();
            foreach (var equipment in context.equipment)
            {
                ListViewItem item = new ListViewItem(equipment.id.ToString());
                item.SubItems.Add(equipment.type);
                listView2.Items.Add(item);
            }
            context.SaveChanges();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            equipment Equipment = new equipment();
            Equipment.type = textBox5.Text;
            context.equipment.Add(Equipment);
            context.SaveChanges();
            AddEquipment();
            context.SaveChanges();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count != 0)
            {
                string W = listView2.Items[(listView2.SelectedItems[0].Index)].SubItems[0].Text;
                equipment Equipment = context.equipment.FromSqlRaw("SELECT * FROM equipment WHERE id = {0}", int.Parse(W)).ToList()[0];
                context.equipment.Remove(Equipment);
                context.SaveChanges();
                MessageBox.Show("Удалено");
                AddEquipment();
                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Не выбран элемент!");
            }
            context.SaveChanges();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddEquipment();
            context.SaveChanges();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
