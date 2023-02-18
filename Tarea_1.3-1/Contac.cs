using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_1._3_1;

namespace Tarea_1._3_1
{
    internal class Contac
    {
        private String telephone;
        private String gmail;
        
        public String Gmail
        {
            get { return gmail; }
            set { gmail = value; }
        }

        public string Telefono
        {
            get { return telephone; }
            set
            {
                telephone = value.Replace(" ", "").Replace("-", "");
            }
        }

        public Contac()
        {
            gmail = string.Empty;
            telephone = string.Empty;
        }

        public Contac(string telephone, string gmail)
        {
            this.gmail = gmail;
            this.telephone = telephone;
        }

        public override string ToString()
        {
            return telephone + gmail;
        }
    }
}