using SAPbobsCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBO.Domain.HanaDb
{
    public class Employe
    {
        private Company DbConnection;
       SAPbobsCOM.EmployeesInfo employes;
        SAPbobsCOM.Documents invoice;
       public Employe()
        {
            DbConnection = HanaDbConnection.DbConnection();
            employes = (EmployeesInfo)DbConnection.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oEmployeesInfo);
            invoice = (SAPbobsCOM.Documents)DbConnection.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInvoices);
        }

        public void AddEmploye()
        {
            employes.FirstName = "Nurullah";
            employes.LastName = "Mustafayev";
            employes.MiddleName = "Hokmuran";
            employes.Add();
            
        }
        public void RemoveEmploye()
        {
            employes.GetByKey(566);
            employes.Remove();

        }

        public void UpdateEmploye()
        {
            employes.GetByKey(568);
            employes.FirstName = "kljkj";
            employes.Update();
        }
    }
}
