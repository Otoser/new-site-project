using System.Collections.Generic;
namespace AlcogolDomain
{
    public class ListTheUserEntity:BaseEntity
    {
        public string FullName { get; set; }
        public bool Vip { get; set; }
        public string Mail { get; set; }

        public string Phone { get; set; }
        public bool BlackList { get; set; }
    }
}
