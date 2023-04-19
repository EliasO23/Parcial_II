// See https://aka.ms/new-console-template for more information

//Codigo con error

//int datol = 16;
//String dato2 = "25g";
//int resultado = datol + Convert.ToInt32(dato2);

//Codigo reparado con la sintaxis “try{} catch{}”

try
{
    int dato1 = 16;
    string dato2 = "25g";
    int resultado = dato1 + Convert.ToInt32(dato2);
}
catch
{
    Console.WriteLine("Lo sentimos no se pudo realizar la operación solicitada");
}



