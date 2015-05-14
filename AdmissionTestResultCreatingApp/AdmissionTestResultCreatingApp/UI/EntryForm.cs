using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdmissionTestResultCreatingApp.Model;
using AdmissionTestResultCreatingApp.VLL;

namespace AdmissionTestResultCreatingApp
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        StudentManager aStudentManager = new StudentManager();
        Student aStudent = new Student();
        private void saveButton_Click(object sender, EventArgs e)
        {
            int rollNo = Convert.ToInt32(rollNoTextBox.Text);
            string fullName = fullNameTextBox.Text;

            aStudentManager.Save(aStudent);
        }
    }
}
