using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace admRegistro2.Models
{
    public class Course
    {
        [Display(Name ="ID")]
        public int CourseID { get; set; }


        [StringLength(40, MinimumLength =3)]
        public string Title { get; set; }

        [Range(0,10)]
        public  int Credits { get; set; }
        public int DepartmentID { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}