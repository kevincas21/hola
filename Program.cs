using System;
using System.Collections.Generic;

namespace electrodomestico
{
    public abstract class electrodomestico {

        protected int precioBase;
        protected int peso; 
        protected string color ;
        protected char consumoEner ;
          
        public electrodomestico(){
            this.precioBase = 100;
            this.peso = 5;
            this.color = "blanco";
            this.consumoEner = 'f';
        }
        public electrodomestico(int peso,int precio){
            this.precioBase = precio;
            this.peso = peso;
            
            
        }
        public electrodomestico (int precio,int peso,string color,char consumoEner){
            this.color = comprobarColor(color);
            this.consumoEner = comprobarEner(consumoEner);
            this.peso = peso;
            this.precioBase = precio;
        }
        
        public int getpeso{get {return peso;} }
        public string getcolor{get{return color;} }
        public int getprecio {get{return precioBase; }}
        public char getconsumo {get{return consumoEner;}}

        private char comprobarEner(char consumoEner){
            List<char> energia = new List<char>{
                'a','b','c','d','e','f'

            };
            for (byte i = 0; i > 7;i++){
                if (consumoEner == energia[i]){
                    return consumoEner;
                }
            
            }
            return this.consumoEner;
            
        }
        private string comprobarColor (string color){

            List<string> colores = new List<string> {
                "blanco","negro","rojo","azul","gris"
            };
            for (byte i = 0; i >6; i++){
                if ( color == colores[i]){
                    return color;
                }
               
            }
            return this.color;
        }
        public int precioFinal(){
            int precio;
            precio = 0;
            if (this.consumoEner == 'a'){
                precio = precio + 100;
            }
            if (this.consumoEner == 'b'){
                precio = precio + 80;
            }
            if (this.consumoEner == 'c'){
                precio = precio + 60;
            }
            if (this.consumoEner == 'd'){
                precio = precio + 50;
            }
            if (this.consumoEner == 'e'){
                precio = precio + 30;
            }
            if (this.consumoEner == 'f'){
                precio = precio + 10;
            }
            if(this.peso >= 0 && this.peso <20){
                precio = precio + 10;
            }
            if (this.peso >= 20 && this.peso<=49){
                precio = precio + 50;
            }
            if (this.peso >= 50 && this.peso <=79){
                precio = precio + 80;
            }
            if(this.peso > 80){
                precio = precio + 100;
            }
            precioBase =  precioBase + precio;
            return precio;
        }
        

    }
    public class lavadora : electrodomestico{
        int carga = 5;
        protected int precioBase;
        protected string color ;
        protected char consumoEner;
        protected int peso;
        
        public lavadora(int carga,int precioBase,string color, char consumoEner,int peso):base(precioBase,peso,color,consumoEner){

            this.carga = carga;
        }
        
        public lavadora(){

        }
        public int getcarga {get{return carga; }}
        public int precioFinal (){
            if(carga> 30){
                precioBase = precioBase + 50;

            }
            return precioBase;
        }


        
        
    
        
        
        

    }
    public class television : electrodomestico{
        public int resolucion = 20;
        public bool sintonizadorTDT = false;
        protected int precioBase;
        protected string color ;
        protected char consumoEner;
        protected int peso;

        public television(){

        }
        
        public television (int precioBase,string color, char consumoEner,int peso):base(precioBase,peso,color,consumoEner){

        }
        public television (int resolucion, bool sintonizadorTDT){
            this.resolucion = resolucion;
            this.sintonizadorTDT = sintonizadorTDT;

        }

        public int getresolucion {get{return resolucion; }}
        public bool getsintonizadorTDT {get{return sintonizadorTDT; }}
        
        public int precioFinal(){
            int precio;

            if (resolucion>40 ){
                precio = precioBase / 3;
                precioBase = precioBase + precio;
            }
            if (sintonizadorTDT){
                precioBase = precioBase + 50;
            }
        return precioBase;
        }
        public class app{
            electrodomestico[] electrodomesticos = new electrodomestico[10];
            public void crear (){
                electrodomestico[] electrodomesticos = new electrodomestico[10];
                electrodomesticos[0] = new television(200,"azul",'f',500);
                electrodomesticos[1] = new lavadora(200,500,"azul",'f',500);
                electrodomesticos [2] = new  television(200,"azul",'f',500);
                electrodomesticos [3] = new lavadora(200,500,"azul",'f',500);
                electrodomesticos[4] = new television(200,"azul",'f',500);
                electrodomesticos[5] = new television(200,"azul",'f',500);
                electrodomesticos[6] = new lavadora(200,500,"azul",'f',500);
                electrodomesticos [7] = new  television(200,"azul",'f',500);
                electrodomesticos [8] = new lavadora(200,500,"azul",'f',500);
                electrodomesticos[9] = new television(200,"azul",'f',500);
                electrodomesticos[10] = new television(200,"azul",'f',500);

                for (byte i = 0; i >11; i ++){
                    Console.WriteLine(electrodomesticos[i].precioFinal());

                }
            }

        }

        
    }
    public class app{
            electrodomestico[] electrodomesticos = new electrodomestico[10];
            public void crear (){
                electrodomestico[] electrodomesticos = new electrodomestico[10];
                electrodomesticos[0] = new television(200,"azul",'f',500);
                electrodomesticos[1] = new lavadora(200,500,"azul",'f',500);
                electrodomesticos [2] = new  television(200,"azul",'f',500);
                electrodomesticos [3] = new lavadora(200,500,"azul",'f',500);
                electrodomesticos[4] = new television(200,"azul",'f',500);
                electrodomesticos[5] = new television(200,"azul",'f',500);
                electrodomesticos[6] = new lavadora(200,500,"azul",'f',500);
                electrodomesticos [7] = new  television(200,"azul",'f',500);
                electrodomesticos [8] = new lavadora(200,500,"azul",'f',500);
                electrodomesticos[9] = new television(200,"azul",'f',500);
                electrodomesticos[10] = new television(200,"azul",'f',500);

                for (byte i = 0; i >11; i ++){
                    Console.WriteLine(electrodomesticos[i].precioFinal());
                    }
            }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            app i = new app();
            i.crear();
            
        }
    }
}
}

