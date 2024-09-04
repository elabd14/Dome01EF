using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dome01EF.Entities
{
    internal class Employee
    {
        #region  pro
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int EmpId { get; set; }
        [Required]
        [Column(TypeName="varchar")]
        //[MaxLength(50)]
        [StringLength(50, MinimumLength = 10)]

        public string  Name { get; set; }

        [DataType(DataType.Currency)]
        public decimal salay {  get; set; }
        [Range(22, 50)] 
        public int? Age { get; set; }
          #endregion  
         


    }
}   
