using Clients.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clients
{
    public partial class Form1 : Form
    {
        private List<AddMember> member = new List<AddMember>();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            FileAccess fa = new FileAccess();
            member = fa.OpenFile();
            this.ageMinText.Text = member.Min(m => m._Date).ToString();
            this.ageMaxText.Text = member.Max(m => m._Date).ToString();
            this.avgAgeText.Text = Math.Round(member.Average(a => a._Date), 2).ToString();
            clientsBS.DataSource = member;



            //             clientsGridView.AutoGenerateColumns = false;
            //            DataGridViewColumn fio = new DataGridViewColumn();
            //            fio.DataPropertyName = "_Fio";
            //            fio.HeaderText = "ФИО";
            //            fio.Name = "FIO";
            //clientsGridView.Columns.Add(fio);
        }
    }
}
