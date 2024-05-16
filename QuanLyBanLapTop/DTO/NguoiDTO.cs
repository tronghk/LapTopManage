using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDTO
    {
        private string id;
        private string name;
        private string phone;
        public string Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Phone { get { return phone; } set { phone = value; } }

        public NguoiDTO(string id, string name, string phone)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
        }
    }
}
