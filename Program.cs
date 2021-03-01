using System;

namespace operaciones_basicas_c_
{
    class Program
    {
        // Declaración de variables
        static double sumando1=0, sumando2=0, resultado;
        //suma 
        static void suma(){

            Console.WriteLine("OPERACIÓN DE LA SUMA"+"\n");
            Console.WriteLine("Ingrese Primer número");
            sumando1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Segundo Número");
            sumando2 = double.Parse(Console.ReadLine());
            resultado = sumando1 + sumando2;
            Console.WriteLine("El resultado es:  " + resultado);
            

        }
        //resta
         static void resta(){

            Console.WriteLine("OPERACIÓN DE LA RESTA"+"\n");
            Console.WriteLine("Ingrese el Minuendo");
            sumando1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Sustraendo");
            sumando2 = double.Parse(Console.ReadLine());
            resultado = sumando1 - sumando2;
            Console.WriteLine("La diferencia es:  " + resultado);
            

        }
        //multiplicación
         static void multi(){

            Console.WriteLine("OPERACIÓN DE LA MULTIPLICACIÓN"+"\n");
            Console.WriteLine("Ingrese el Multiplicando");
            sumando1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Multiplicador");
            sumando2 = double.Parse(Console.ReadLine());
            resultado = sumando1 * sumando2;
            Console.WriteLine("El producto es:  " + resultado);
            

        }
        //división
         static void divi(){

            Console.WriteLine("OPERACIÓN DE LA DIVISIÓN"+"\n");
            Console.WriteLine("Ingrese el Dividendo");
            sumando1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Divisor");
            sumando2 = double.Parse(Console.ReadLine());
            //condicional para la división que no se puede dividir entre 0
            if(sumando2==0){
                Console.WriteLine("ERROR! El divisor no puede ser 0");
            }
            else{

                resultado = sumando1 / sumando2;
                Console.WriteLine("El cociente es:  " + resultado);
            }
           
            

        }
        //modulo de la división o el residuo (lo que sobra de la division)
         static void modul(){

            Console.WriteLine("MÓDULO DE LA DIVISIÓN"+"\n");
            Console.WriteLine("Ingrese el Dividendo");
            sumando1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Divisor");
            sumando2 = double.Parse(Console.ReadLine());
            //condicional que no se puede dividir entre 0
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
          
            //menu
            while(true){
                System.Console.Clear();
                Console.WriteLine("-----OPERACIONES MATEMÁTICAS BÁSICAS-----");
                Console.WriteLine("\n"+"Ingrese a la operación que desea realizar");
                Console.WriteLine("\n"+"1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Módulo (residuo de la división)");
                Console.WriteLine("0. salir");
                //variable para las opciones del menu
                int option= int.Parse(Console.ReadLine());
                //opciones 
                if(option==1){
                    System.Console.Clear();
                    suma();
                }
                else if(option==2){
                    System.Console.Clear();
                    resta();

                }
                else if(option==3){
                    System.Console.Clear();
                    multi();

                }
                else if(option==4){
                    System.Console.Clear();
                    divi();

                }
                else if(option==5){
                    System.Console.Clear();
                    modul();

                }
                else{
                    //salida
                System.Console.Clear();
                Console.WriteLine("Created"+"\n" + ":::...Lily...:::");
        
                break;
                    }
                Console.WriteLine("Presione enter para continuar. ");
                Console.ReadLine();

            }

        }
    }
}
