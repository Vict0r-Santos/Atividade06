using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int mes;
        int dia;
        string periodo;
        
        Console.WriteLine ("\nSeja bem-vindo a agencia de viagens Submundo!");
        Console.WriteLine ("Selecione o mes de sua preferencia:");
        Console.WriteLine ("08 - Agosto");
        Console.WriteLine ("09 - Setembro");
        Console.WriteLine ("10 - Outubro");
        mes = int.Parse(Console.ReadLine());
        
        if(mes<8 || mes>10){
            
            Console.WriteLine ("Mes Invalido!");
            Console.ReadLine();
            Console.Clear();
            Main(null);
            
            return;
        }
        Console.WriteLine ("\nSelecione o dia de sua preferencia:");
        Console.WriteLine ("Disponiveis - dia 6 a 21");
        dia = int.Parse(Console.ReadLine());
        
        if(dia<6 || dia>21){
            
            Console.WriteLine ("Dia Invalido!");
            Console.ReadLine();
            Console.Clear();
            Main(null);
            
            return;
        }
        Console.WriteLine ("\nAgora digite o periodo de sua preferencia");
        Console.WriteLine ("Manhã");
        Console.WriteLine ("Tarde");
        Console.WriteLine ("Noite");
        periodo = Console.ReadLine();
        
        if(periodo!="Manhã" && periodo!="Tarde" && periodo!="Noite"){
            
            Console.WriteLine ("Periodo Invalido!");
            Console.ReadLine();
            Console.Clear();
            Main(null);
            
            return;
        }
        Console.WriteLine($"Passagem comprada para o mes {mes}, dia {dia}, no período {periodo}");
        
        
        
        
        Console.ReadLine();
    }
}
