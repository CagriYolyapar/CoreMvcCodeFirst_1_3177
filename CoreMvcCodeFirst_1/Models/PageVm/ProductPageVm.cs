using CoreMvcCodeFirst_1.Models.Entities;

namespace CoreMvcCodeFirst_1.Models.PageVm
{
    public class ProductPageVm
    {
        public List<Category> Categories { get; set; }
        public Product Product { get; set; }

    }
}
