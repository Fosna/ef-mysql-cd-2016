namespace EFBasicTutorials
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("schooldb.student")]
    public partial class student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public student()
        {
            course = new HashSet<course>();
        }

        public int StudentID { get; set; }

        [StringLength(50)]
        public string StudentName { get; set; }

        public int? StandardId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime RowVersion { get; set; }

        public virtual standard standard { get; set; }

        public virtual studentaddress studentaddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<course> course { get; set; }
    }
}
