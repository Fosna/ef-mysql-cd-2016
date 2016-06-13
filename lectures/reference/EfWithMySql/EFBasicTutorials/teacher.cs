namespace EFBasicTutorials
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("schooldb.teacher")]
    public partial class teacher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public teacher()
        {
            course = new HashSet<course>();
        }

        public int TeacherId { get; set; }

        [StringLength(50)]
        public string TeacherName { get; set; }

        public int? StandardId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<course> course { get; set; }

        public virtual standard standard { get; set; }
    }
}
