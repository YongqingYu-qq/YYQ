using System;

namespace WebApplication_Core_mvc.Models
{
    public class ConsignmentLine
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Volume { get; set; }
        public int? Pieces { get; set; }
        public decimal? Weigth { get; set; }
        public bool? DangerousGoods { get; set; }
        public string DgClass { get; set; }
        public string UnNumber { get; set; }
        public Guid? ConsignmentId { get; set; }
        public Guid? ItemId { get; set; }
        public Guid? CommodityId { get; set; }
        public bool? Deleted { get; set; }
    }
}