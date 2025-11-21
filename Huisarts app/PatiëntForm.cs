using ClassLibrarydB;
using ClassLibrarydB.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huisarts_app
{
    public partial class PatiëntForm : Form
    {
        
        private int _NoteIndex;
        private int NoteIndex
        {
            get { return _NoteIndex; }
            set
            {
                _NoteIndex = value;
                if (_NoteIndex > 0)
                {
                    BtnNoteMin.Enabled = true;
                }
                else
                {
                    BtnNoteMin.Enabled = false;
                }

                if(_NoteIndex == notes.Count -1)
                {
                    BtnNotePlus.Enabled = false;
                }
                else
                {
                    BtnNotePlus.Enabled = true;
                }

                if (notes.Count == 0)
                {
                    BtnNoteMin.Enabled = false;
                    BtnNotePlus.Enabled = false;
                }
            }
        }
        public int? id { get; set; }
        public string _connectionString { private get; set; }

        List<note> notes = new List<note>();
        public PatiëntForm()
        {
            InitializeComponent();
        }

        private void PatiëntForm_Load(object sender, EventArgs e)
        {
            loadPaiënts();
            notitieDisplay.ButtonClicked += MyUC_ButtonClicked;
            NoteAdd.ButtonClicked += MyUC_ButtonClicked;
        }

        public void loadPaiënts()
        {
            //this.Text = id.ToString();

            if (id != null)
            {
                NoteAdd.PatiëntId = (int)id;
                FullPatiënt patiënt = new FullPatiënt();

                data db = new data(_connectionString);
                patiënt = db.GetPatiënt((int)id)[0];
                Text = $"Patiënt | {patiënt.FirstName} {patiënt.LastName}";
                //MessageBox.Show(patiënt.id.ToString());

                if (id != null)
                {
                    TbVoornaam.Text = patiënt.FirstName;
                    TbAchternaam.Text = patiënt.LastName;
                    TbAdres.Text = patiënt.Adres;
                    TbHuisnummer.Text = patiënt.HouseNum;
                    TbPostcode.Text = patiënt.PostalCode;
                    TbPlaats.Text = patiënt.City;
                    TbTelefoonnummer.Text = patiënt.PhoneNum;
                }

                notes = db.GetNotes((int)id);
                NoteIndex = 0;
                if (notes.Count > 0)
                {
                    SetNote(NoteIndex);
                }
                else
                {
                    notitieDisplay.Visible = false;
                    BtnNoteMin.Visible = false;
                    BtnNotePlus.Visible = false;
                    LblAdd.Location = new Point(
                        LblAdd.Location.X,
                        LblAdd.Location.Y - 230);
                    NoteAdd.Location = new Point(
                        NoteAdd.Location.X,
                        NoteAdd.Location.Y - 230);
                    Size = new Size(Size.Width, Size.Height - 230);
                }

            }
            else
            {
                NoteAdd.Enabled = false;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            FullPatiënt patiënt = new FullPatiënt()
            {
                id = id,
                FirstName = TbVoornaam.Text,
                LastName = TbAchternaam.Text,
                Adres = TbAdres.Text,
                HouseNum = TbHuisnummer.Text,
                PostalCode = TbPostcode.Text,
                City = TbPlaats.Text,
                PhoneNum = TbTelefoonnummer.Text
            };
            data db = new data(_connectionString);
            if (id != null)
            {

                db.UpdatePatiënt(patiënt);
            }
            else
            {
                db.AddPatiënt(patiënt);
            }
            DialogResult = DialogResult.OK;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("weet je zeker dat je deze patiënt wilt verwijderen? dit is niet definitief.", "waarschuwing verwijderen", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                data db = new data(_connectionString);
                db.DeletePatiënt((int)id);
                DialogResult = DialogResult.OK;
            }
        }

        private void SetNote(int index)
        {
            notitieDisplay.id = notes[index].id;
            notitieDisplay.title = notes[index].title;
            notitieDisplay.text = notes[index].text;
            notitieDisplay.updateDate = notes[index].updateDate;
        }

        private void BtnNote_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Tag == "min")
            {
                NoteIndex--;
            }
            else if (btn.Tag == "plus")
            {
                NoteIndex++;
            }
            else
            {
                Console.WriteLine("verkeerde button");
            }

            SetNote(NoteIndex);
        }

        

        private void MyUC_ButtonClicked(object sender, EventArgs e)
        {
            Notitie note = sender as Notitie;
            string UpdateType;
            loadPaiënts();
            if (note.id != null)
            {
                UpdateType = "gewijzigd";
            }
            else
            {
                UpdateType = "toegevoegd";
            }
            MessageBox.Show($"Notitie {UpdateType}");
        }
    }
}
