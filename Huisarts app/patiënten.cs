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
    public partial class patiënten : UserControl
    {
        public int id {  get; set; }
        private string _FirstName;
        public string FirstName 
        {
            get { return _FirstName; }
            set
            {
                LblNaam.Text = $"naam: {value}";
                _FirstName = value ;
            }
        }
        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set
            {
                LblNaam.Text += $" {value}";
                _LastName = value;
            }
        }
        //public string Adres { get; set; } //street
        //public string HouseNum { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        //public string PhoneNum {  get; set; }
        private int _NotesCount;
        public int NotesCount
        {
            get { return _NotesCount; }
            set 
            {
                LblNotesCount.Text = $"Aantal notities: {value}";
                _NotesCount = value;
            }
        }
        public patiënten()
        {
            InitializeComponent();
        }


    }
}
