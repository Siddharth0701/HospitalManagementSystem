using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class NewUserRegister
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Emailid { get; set; }
        [MaxLength(20)]
        public string Username  { get; set; }

        [MaxLength(20)]
        public string Mobilenumber { get; set; }
        [MaxLength(20)]
        public string Dateofbirth { get; set; }
        [MaxLength(20)]
        public string Address { get; set; }
        [MaxLength(20)]
        public string Password { get; set; }
        [MaxLength(20)]
        public string Confirmpassword { get; set; }



    }
}
