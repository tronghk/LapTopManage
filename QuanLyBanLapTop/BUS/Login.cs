using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using NPOI.SS.Formula.Functions;
using static BUS.export;

namespace BUS
{
    public class Login
    {
        public static UserDTO currentAcc = null;
        


        public string login(string userName, string pass)
        {
            string image = "pr";
            for (int i = 1; i <= 50; i++)
            {
                string temp = image + i + ".png";
                string idProduct = "SP0" + i;

                new TaiKhoanDAO().addImage(idProduct,temp);

            }
           
            
            if (userName == "")
                return "requeid_user";
            if (pass == "")
                return "requeid_pass";
            TaiKhoanDAO us = new TaiKhoanDAO();
            UserDTO userDTO = new UserDTO(userName, pass);
            UserDTO user = us.searchUser(userDTO);

            if(user != null)
            {
                currentAcc = user;
                return "success";
            }
            else
            {
                return "notFound";
            }
        }
        public void addUser(string user, string pass, string service)
        {

           UserDTO userDTO = new UserDTO(user, pass);
            userDTO.Id = user;
            if (service == "Quản lý")
                userDTO.IdQuyen = 7001;
            else
                userDTO.IdQuyen = 7002;
            new TaiKhoanDAO().addUser(userDTO);
        }

        public static List<UserDTO> listUser()
        {

            return new TaiKhoanDAO().listUser();
        }
    }
}
