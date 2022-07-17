using System.ComponentModel.DataAnnotations;

namespace StudentsWeb.Models
{
    public class MinimunAgeAttribute : ValidationAttribute
    {
        int _minimunAge;


        public MinimunAgeAttribute(int minimunAge)
        {
            _minimunAge = minimunAge;
        }

        public override bool IsValid(object? value)
        {
            DateTime date;
            if (DateTime.TryParse(value.ToString(), out date))
            {
                return date.AddYears(_minimunAge) < DateTime.Now;
            }
            

            return false;
        }
    }
}
