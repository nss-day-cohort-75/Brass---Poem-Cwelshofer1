
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

List<Product> products = new List<Product>()
{
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

    new Product {
        Name = "French Horn",
        Price = 500.00M,
        ProductTypeId = 2
    }
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
        
    }
    else if (choice == "3");
    {
        DeleteProduct(products, productTypes);
    }
    // else if (choice == "4") {
    //     AddProduct();
    // }
    // else if (choice == "5") {
    //     UpdateProduct();
    // }
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
        Console.WriteLine($"{i + 1}. {products[i].Name} {products[i].Price} {type.Title}");
    }
    
    
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    
}

// void AddProduct(List<Product> products, List<ProductType> productTypes)
// {
//     throw new NotImplementedException();
// }

// void UpdateProduct(List<Product> products, List<ProductType> productTypes)
// {
//     throw new NotImplementedException();
// }

// don't move or change this!
public partial class Program { }