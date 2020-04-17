using System;
using System.Collections.Generic;

namespace LinqPadDemo.DomainModels
{
    public class SinjulMSBH
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public byte Age { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset BirthDate { get; set; }


        public virtual ICollection<JackSlater> JackSlater { get; set; }
    }

    public class JackSlater
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public byte Age { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset BirthDate { get; set; }

        public long? SinjulMSBHId { get; set; }
        public virtual SinjulMSBH SinjulMSBH { get; set; }
    }
}
