using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UsersDTO
    {

        public int userId { get; set; }
        public string userName { get; set; }
        public string userMail { get; set; }
        public string userPassword { get; set; }
        public bool isAdmin { get; set; }
        public bool receiveingUpdates { get; set; }

        //From DAL to DTO
        public UsersDTO(User u)
        {
            this.userId = u.userId;
            this.userName = u.userName;
            this.userMail = u.userMail;
            this.userPassword = u.userPassword;
            this.isAdmin = u.isAdmin;
            this.receiveingUpdates = u.receiveingUpdates;
        }

        ////From DTO to DAL
        public User Parse(UsersDTO user)
        {
            return new User(

             userId = this.userId,
            userName = this.userName,
            userMail = this.userMail,
            userPassword = this.userPassword,
            isAdmin = this.isAdmin,
            receiveingUpdates = this.receiveingUpdates);



        }
    }
}


