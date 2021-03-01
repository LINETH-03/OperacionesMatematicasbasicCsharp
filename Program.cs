using System;

namespace operaciones_basicas_c_
{
    class Program
    {
        //variables
        static double sumando1=0, sumando2=0, resultado;
        //suma 
        static void suma(){

            Console.WriteLine("OPERACIÓN DE LA SUMA"+"\n");
            Console.WriteLine("Ingrese primer número");
            sumando1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Segundo Número");
            sumando2 = double.Parse(Console.ReadLine());
            resultado = sumando1 + sumando2;
            Console.WriteLine("el resultado es:  " + resultado);
            

        }
         static void resta(){

            Console.WriteLine("OPERACIÓN DE LA RESTA"+"\n");
            Console.WriteLine("Ingrese primer número");
            sumando1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Segundo Número");
            sumando2 = double.Parse(Console.ReadLine());
            resultado = sumando1 - sumando2;
            Console.WriteLine("el resultado es:  " + resultado);
            

        }
         static void multi(){

            Console.WriteLine("OPERACIÓN DE LA MULTIPLICACIÓN"+"\n");
            Console.WriteLine("Ingrese primer número");
            sumando1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Segundo Número");
            sumando2 = double.Parse(Console.ReadLine());
            resultado = sumando1 * sumando2;
            Console.WriteLine("el resultado es:  " + resultado);
            

        }
         static void divi(){

            Console.WriteLine("OPERACIÓN DE LA DIVISIÓN"+"\n");
            Console.WriteLine("Ingrese el Dividendo");
            sumando1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Divisor");
            sumando2 = double.Parse(Console.ReadLine());
            if(sumando2==0){
                Console.WriteLine("ERROR! El divisor no puede ser 0");
            }
            else{

                resultado = sumando1 / sumando2;
                Console.WriteLine("El cociente es:  " + resultado);
            }
           
            

        }
         static void modul(){

            Console.WriteLine("MODULO DE LA DIVISIÓN"+"\n");
            Console.WriteLine("Ingrese el Dividendo");
            sumando1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Divisor");
            sumando2 = double.Parse(Console.ReadLine());
            if(sumando2==0){
                Console.WriteLine("ERROR! El divisor no puede ser 0");
            }
            else{
                resultado = sumando1 % sumando2;
                Console.WriteLine("El residuo es:  " + resultado);
            }
            
            

        }
         

        //menu
        static void Main(string[] args)
        {
          

            while(true){
                Console.WriteLine("OPERACIONES MATEMÁTICAS BÁSICAS");
                System.Console.Clear();
                Console.WriteLine("Ingrese a la operación que desea realizar");
                Console.WriteLine("\n"+"1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4.División");
                Console.WriteLine("5. Modulo");
                Console.WriteLine("0. salir");
                int option= int.Parse(Console.ReadLine());

                if(option==1){
                    suma();
                }
                else if(option==2){
                    resta();

                }
                else if(option==3){
                    multi();

                }
                else if(option==4){
                    divi();

                }
                else if(option==5){
                    modul();

                }
                else{
                System.Console.Clear();
                Console.WriteLine("Fin");
                Console.WriteLine(":::...Lily...:::");
                break;
                    }
                Console.WriteLine("Presione enter para continuar. ");
                Console.ReadLine();

                


            }

        }
    }
}
