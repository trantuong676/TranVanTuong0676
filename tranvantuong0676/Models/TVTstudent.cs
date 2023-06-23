using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  TRANVANTUONG0676.Models
{
    public class TVTstudent
    {
        [Key]
        public string  TVTstudentID { get; set; }
        public string  TVTstudentName { get; set; }
        public string  TVTStudentSex { get; set; }
       
    }
}