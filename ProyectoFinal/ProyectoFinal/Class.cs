namespace ProyectoFinal
{
    public class User                                // Clase para los usuarios
    {
        private uint _id;                            // Id de usaurio
        private string _username;                    // Nombre de usuario del usuario
        private string _name;                        // Nombre de pila del usuario
        private string _surname;                     // Apellido del usuario
        private string _email;                       // Email del usuario
        private string _password;                    // Contraseña del usuario
    }

    public class Product                             // Clase para los productos
    {
        private uint _id;                            // Id del producto, En Uint para que no tolere una id negativa
        private string _productDescription;          // Descripcion del producto
        private double _buyingPrice;                 // Precio de compra del producto
        private double _sellingPrice;                // Precio de venta del producto
        private int _stock;                          // Stock del producto
        private uint _userId;                        // Id de Usuario
    }

    public class SoldProduct : Product               // Clase producto vendido, hereda de producto
    {
        private uint _id;                            // Id 
        private uint _productId;                     // Id del producto
        private int _stock;                          // Stock del producto
        private uint _sellingId;                     // Id de la venta
    }

    public class Selling                             // Clase venta
    {
        private uint _id;                            // Id de venta


    }
}
