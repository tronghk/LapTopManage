using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SupplierManager
    {
        public NhaCungCapDTO searchIdSupplier(string idSupplier)
        {
            
            return new NhaCungCapDAO().searchToId(idSupplier);
        }
        public static List<NhaCungCapDTO> listSupplier()
        {
            return new NhaCungCapDAO().listSupplier();
        }
    }
}
