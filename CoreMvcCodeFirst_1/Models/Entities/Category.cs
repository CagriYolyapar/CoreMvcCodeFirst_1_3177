namespace CoreMvcCodeFirst_1.Models.Entities
{
    //todo : Is a ve has a durumları

    //Category has Products => Category sıfınının Products property'si var...

    //Category is a  Product =>  Category : Product


    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Relational Properties
        public virtual List<Product> Products { get; set; }
    }
}
