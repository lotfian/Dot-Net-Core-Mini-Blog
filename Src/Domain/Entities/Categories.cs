using System;

namespace Domain.Entities
{
    public class Categories
    {
         public int id { get; set; }
        public int ParentId { get; set; }
        public Int64 CreateDate { get; set; }
        public string? CategoryName { get; set; }
        public string? Brief { get; set; }
        public bool Status { get; set; }
        public int DepthInTree { get; set; }
        public int OrderNo { get; set; }
    }
}