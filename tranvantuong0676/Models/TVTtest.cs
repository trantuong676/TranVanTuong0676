using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  TRANVANTUONG0676.Models
{
    public class TVTtest
    {
        [Key]
        public string  TVTstudentID { get; set; }
          [foreignkey("TVTstudent")]
        public TVTstudent? TVTstudent {get ; set;}
        public string  TVTtest01 { get; set; }
        public string  TVTtest02{ get; set; }
       
    }
}