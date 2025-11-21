using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrarydB;
using ClassLibrarydB.model;

namespace Huisarts_app
{
    public partial class FormPatiënten : Form
    {
        string connectionString = "server=localhost;database=huisarts; user=root; password=";
        public FormPatiënten()
        {
            InitializeComponent();
        }

        private void FormPatiënten_Load(object sender, EventArgs e)
        {
            loadPatiënts();
        }

        private void loadPatiënts()
        {
            FlpPatiënten.Controls.Clear();
            TbZoek.Text = string.Empty;
            List<SmallPatiënt> patiënten = new List<SmallPatiënt>();

            data db = new data(connectionString);
            patiënten = db.GetAllPatiënts();
            foreach (SmallPatiënt patiënt in patiënten)
            {
                patiënten _patiënt = new patiënten
                {
                    id = patiënt.id,
                    FirstName = patiënt.FirstName,
                    LastName = patiënt.LastName,
                    PostalCode = patiënt.PostalCode,
                    City = patiënt.City,
                    NotesCount = patiënt.NotesCount
                };
                _patiënt.Click += patiënt_Click;
                //_patiënt.Width = GroupPatiënten.Width - 100
                FlpPatiënten.Controls.Add(_patiënt);
            }
        }

        private void patiënt_Click(object sender, EventArgs e)
        {
            patiënten p = sender as patiënten;
            PatiëntForm patiëntForm = new PatiëntForm
            {
                id = p.id,
                _connectionString =  connectionString
            };
            if (patiëntForm.ShowDialog() == DialogResult.OK)
            {
                loadPatiënts();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            PatiëntForm patiëntForm = new PatiëntForm
            {
                id = null,
                _connectionString = connectionString
            };
            if (patiëntForm.ShowDialog() == DialogResult.OK)
            { 
                loadPatiënts();
            }
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            BtnReload.Enabled = false;
            loadPatiënts();
            BtnReload.Enabled = true;
        }

        private void TbZoek_TextChanged(object sender, EventArgs e)
        {
            if (TbZoek.Text.Length >= 3)
            {
                FlpPatiënten.Controls.Clear();
                List<SmallPatiënt> patiënten = new List<SmallPatiënt>();

                data db = new data(connectionString);
                patiënten = db.SearchPatiënt(TbZoek.Text);
                foreach (SmallPatiënt patiënt in patiënten)
                {
                    patiënten _patiënt = new patiënten
                    {
                        id = patiënt.id,
                        FirstName = patiënt.FirstName,
                        LastName = patiënt.LastName,
                        PostalCode = patiënt.PostalCode,
                        City = patiënt.City,
                        NotesCount = patiënt.NotesCount
                    };
                    _patiënt.Click += patiënt_Click;
                    //_patiënt.Width = GroupPatiënten.Width - 100
                    FlpPatiënten.Controls.Add(_patiënt);

                }
            }
        }
    }
}
