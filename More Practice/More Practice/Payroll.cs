using System;
using System.Collections.Generic;
using System.Text;

namespace More_Practice
{
    interface IPayee
    {
        public void Pay();
       
    }
    class Payroll
    {
        Teacher teacher1 = new Teacher();
        Teacher teacher2 = new Teacher();
        Principal principal = new Principal();

        List<IPayee> payees = new List<IPayee>();

        public Payroll()
        {
            payees.Add(new Teacher());
            payees.Add(new Teacher());
            payees.Add(new Principal());
        }

        public void PayAll()
        {
            foreach (var payee in payees)
            {
                payee.Pay();
            }
        }
    }
}
