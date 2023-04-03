using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Med
{
    internal class GetSet
    {
        int id= 0;
        bool update = false;
        int idworker = 0;
        public int Id { get { return id;  } set { id = value;} }
        public bool Update { get { return update; } set { update = value; } }
        public int Idworker { get { return idworker; } set { idworker = value; MessageBox.Show("111"); } }

    }
}
