
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

List<Product> products = new List<Product>()
{

    new Product {
        Name = "Trumpet",
        Price = 150.99M,
        ProductTypeId = 1

    },

    new Product()
    {
        Name = "The Odyssey",
        Price = 20.00M,
        ProductTypeId = 1

    },

    new Product()
    {
        Name = "The Divine Comedy",
        Price = 25.00M,
        ProductTypeId = 1
    },

    new Product()
    {
        Name = "Tuba",
        Price = 300.00M,
        ProductTypeId = 2

    },

    new Product {
        Name = "Trombone",
        Price = 150.00M,
        ProductTypeId = 2
    },


    
};
    
//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
List<ProductType> productTypes = new List<ProductType>() 
{
    new ProductType {
        Title = "Poetry Book",
        Id = 1
    },
    new ProductType {
        Title = "Brass Musical Instrument",
        Id = 2
    }
};

//put your greeting here
 string greeting = @"Welcome to Brass and Poem!
  We sell both poetry books and brass instuments here!";
 Console.WriteLine(greeting);
//implement your loop here
string choice = null;
while (choice != "5")
{ 
DisplayMenu();
    choice = Console.ReadLine();
    if (choice == "1")
    {
        DisplayAllProducts(products, productTypes);
    }
    else if (choice == "2")
    {
      DeleteProduct(products, productTypes);  
    }
    else if (choice == "3")
    {
        AddProduct(products, productTypes);
    }
    // else if (choice == "4") {
    //     UpdateProduct();
    // }
    // }
    // else if (choice == "5") {
    //     
}


void DisplayMenu()
{
    Console.WriteLine(@"1. Display all products
2. Delete a product
3. Add a new product
4. Update product properties
5. Exit".Trim());
    
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{   
    
    for (int i = 0; i < products.Count; i++)
    {
        Product currentProduct = products[i];
        List<ProductType> selectedType = productTypes.Where(item => item.Id == currentProduct.ProductTypeId).ToList();
        foreach(ProductType type in selectedType)
        Console.WriteLine($"{i + 1}. Name:-{currentProduct.Name}-Price:{currentProduct.Price}-Product Type:{type.Title}-");
    }
    
    
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    DisplayAllProducts(products, productTypes);
    Console.WriteLine($"Enter The Number of the product you want to delete");
   int index = int.Parse(Console.ReadLine());
   products.RemoveAt(index - 1);

}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Enter the name of the new product");
    string Name = Console.ReadLine();
   
    Console.WriteLine("Enter the name of the new price (with decimal)");
    string Price = Console.ReadLine();
    decimal priceInput = 0;
    priceInput = decimal.Parse(Price);

    foreach( ProductType product in productTypes)
    {
        Console.WriteLine(product.Id + ". " + product.Title);
    }
    Console.WriteLine("Enter a Type:");
    int ProductTypeId = int.Parse(Console.ReadLine());

    Product newProduct = new Product()
    {
        Name = Name,
        Price = priceInput,
        ProductTypeId = ProductTypeId,
    };
    products.Add(newProduct);

}

// void UpdateProduct(List<Product> products, List<ProductType> productTypes)
// {
//     throw new NotImplementedException();
// }

// don't move or change this!
public partial class Program { }