using System;

Console.WriteLine(Product.CreateProduct().SerialNumber);
Console.WriteLine(Product.CreateProduct().SerialNumber);
Console.WriteLine(Product.CreateProduct().SerialNumber);
Console.WriteLine(Product.CreateProduct().SerialNumber);
Console.WriteLine(Product.CreateProduct().SerialNumber);
Console.WriteLine(Product.CreateProduct().SerialNumber);
Console.WriteLine(Product.CreateProduct().SerialNumber);



class Product
{
    private static int nextSerial = 1;

    private int _serialNumber;
    public int SerialNumber { get { return _serialNumber; } }

    private Product(int serial)
    {
        _serialNumber = serial;
    }
       
    public static Product CreateProduct()
    {
        return new Product(nextSerial++);
    }
}