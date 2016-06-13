namespace EFBasicTutorials
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("schooldb.course")]
    public partial class course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public course()
        {
            student = new HashSet<student>();
        }

        public int CourseId { get; set; }

        [StringLength(50)]
        public string CourseName { get; set; }

        public int? TeacherId { get; set; }

        public virtual teacher teacher { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<student> student { get; set; }
    }
}
