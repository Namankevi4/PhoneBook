namespace PhoneBookv2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Phone
    {
        public int Id { get; set; }

        public long Number { get; set; }

        public string DescriptionNumber { get; set; }

        public int PersonId { get; set; }

        public virtual Person Person { get; set; }
    }
}
