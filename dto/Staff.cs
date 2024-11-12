using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXeMay.dto
{
    public class Staff
    {
        private int staffId;
        private string fullName;
        private string gender;
        private DateTime dob;
        public Staff() { }

        public Staff(int staffId, string fullName, string gender, DateTime dob)
        {
            this.staffId = staffId;
            this.fullName = fullName;
            this.gender = gender;
            this.dob = dob;
        }

        public int StaffId { get => staffId; set => staffId = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime Dob { get => dob; set => dob = value; }
    }
}
