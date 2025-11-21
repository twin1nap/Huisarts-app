using ClassLibrarydB;
using ClassLibrarydB.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huisarts_app
{
    public partial class Notitie : UserControl
    {
        public event EventHandler ButtonClicked;

        string connectionString = "server=localhost;database=huisarts; user=root; password=";

        private int? _id;
        public int? id
        {
            get { return _id; }
            set
            {
                if (value == null)
                {
                    BtnSave.Text = "toevoegen";
                }
                else
                {
                    BtnSave.Text = "opslaan";
                }
                _id = value;
            }
        }
        public string title
        {
            get { return TbTitle.Text; }
            set { TbTitle.Text = value; }
        }
        public string text
        {
            get { return TbNote.Text; }
            set { TbNote.Text = value; }
        }
        private DateTime _updateDate;
        public DateTime updateDate
        {
            get {return _updateDate; }
            set
            {
                LblUpdate.Text = $"laatste update: {value.ToString("dd/MM/yyyy HH:mm")}";
                _updateDate = value;
            }
        }

        public int PatiëntId { get; set; }
        public Notitie()
        {
            InitializeComponent();
        }

        private void Notitie_Load(object sender, EventArgs e)
        {
            updateDate = DateTime.Now;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            note Note = new note()
            {
                id = id,
                title = TbTitle.Text,
                text = TbNote.Text,
                updateDate = DateTime.Now
            };
            data db = new data(connectionString);
            if (id != null)
            {

                db.UpdatewNote(Note);
            }
            else
            {
                db.AddNote(Note, PatiëntId);
            }
            ButtonClicked?.Invoke(this, EventArgs.Empty);

            if (BtnSave.Text == "toevoegen")
            {
                TbTitle.Text = null;
                TbNote.Text = null;
            }
        }
    }
}
