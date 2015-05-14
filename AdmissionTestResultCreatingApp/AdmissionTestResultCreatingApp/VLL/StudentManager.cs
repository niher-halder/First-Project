using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdmissionTestResultCreatingApp.DAL;
using AdmissionTestResultCreatingApp.Model;

namespace AdmissionTestResultCreatingApp.VLL
{
    
    public class StudentManager
    {
        StudentGateWay aStudentGateway = new StudentGateWay();
        public void Save(Student aStudent)
        {
            aStudentGateway.Save(aStudent);

        }
    }
}
