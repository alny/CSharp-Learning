﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();

            peopleFoundListBox.DataSource = people;
            peopleFoundListBox.DisplayMember = "FullInfo";
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

            DataAccess db = new DataAccess();

            people = db.GetPeople(lastNameText.Text);
            peopleFoundListBox.DataSource = people;
            peopleFoundListBox.DisplayMember = "FullInfo";

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void insertRecord_Click(object sender, EventArgs e) {

            DataAccess db = new DataAccess();

            db.InsertRecord(firstNameInsText.Text, lastNameInsText.Text, emailInsText.Text, phoneInsText.Text);

        }
    }
}
