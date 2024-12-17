namespace SystemManegementStoreOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Product List
            List<Product> products = new List<Product>();

            // Add Electronic Products
            Electronic laptop = new Electronic("Laptop", 1500, 24);
            Electronic smartphone = new Electronic("MobilePhone", 800, 12);
            products.Add(laptop);
            products.Add(smartphone);

            // Add Clothing Products
            Clothing tshirt = new Clothing("T-Shirt", 20, "Cotton", "Medium");
            Clothing jeans = new Clothing("Jeans", 50, "Denim", "Large");
            products.Add(tshirt);
            products.Add(jeans);

            // Apply ِiscounts On Electronic Products
            Console.WriteLine("Applying discount to electronics...");
            foreach (var product in products)
            {
                if (product is Idiscountable discountable)
                {
                    discountable.ApplyDiscount(10); // 10% Discount
                }
            }

            // Show Details Of All Products
            Console.WriteLine("\nProduct Details:");
            foreach (var product in products)
            {
                Console.WriteLine(product.GetProductDetails());
            }
        }
    }
}
