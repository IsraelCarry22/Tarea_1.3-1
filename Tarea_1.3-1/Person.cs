using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1._3_1
{
    internal class Person : Contac
    {
        protected String name;
        protected String last_name_father;
        protected String last_name_mother;
        protected DateTime? birthdate;

        public String Nombre
        {
            get { return name; }
            set { name = value; }
        }
        public String Apellido_paterno
        {
            get { return last_name_father; }
            set { last_name_father = value; }
        }

        public String Apellido_materno
        {
            get { return last_name_mother; }
            set { last_name_mother = value; }
        }

        public DateTime? Fecha_cumpeaños
        {
            get { return birthdate; }
            set { birthdate = value; }
        }
        public int Edad
        {
            get
            {
                int age;
                age = (DateTime.Now.Year - birthdate.Value.Year);
                return age;
            }
        }

        public Person() : base()
        {
            name = String.Empty;
            last_name_father = String.Empty;
            last_name_mother = String.Empty;
            birthdate = null;
        }
        public Person(String name, String last_name_father, String last_name_mother, DateTime? birthdate, String gmail, String telefono) : base(gmail, telefono)
        {
            this.name = name;
            this.last_name_father = last_name_father;
            this.last_name_mother = last_name_mother;
            this.birthdate = birthdate;
        }

        public override string ToString()
        {
            return name.ToUpper() + Edad;
        }
    }
}