using System.ComponentModel.DataAnnotations;

namespace StudentsWeb.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        
        [Required(ErrorMessage = "The name is obligatory")]
        [StringLength(30, ErrorMessage ="The name lenght can't be more than 30")]
        public string Name { get; set; }

        
        [DisplayFormat(DataFormatString ="{0:dd MM yyyy}")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "The birthday is obligatory")]
        [MinimunAge(16, ErrorMessage ="The student must be 16")]
        public DateTime Birthday { get; set; }

        internal static Task<string?> ToListAsync()
        {
            throw new NotImplementedException();
        }

        [Required(ErrorMessage = "The grade is obligatory")]
        public string Grade { get; set; }

        [Required(ErrorMessage = "The state is obligatory")]
        public string State { get; set; }   




    }
}
