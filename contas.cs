using System;


public class conta: Iconta
{
     public conta( int numero)
    {
       this.numero=numero;
      conta.TotalContasCriadas++;
    }
public int numero{get;set;}
public int deposita{get;set;}
private double saldo {get; set;}
public double limite {get;private set;}
public double sacar { get;set;}
public static int TotalContasCriadas { get;set;}

   
    public static int ProximoTotalContasCriadas()
    {
        return TotalContasCriadas + 1;
    }
   
    public void Deposita(double valor)
    {
         this.saldo+= valor;
    } 
    
    public bool  Saque(double valor)
    {
        double saldo1 = this.ConsultaSaldoDisponivel();
        if(valor>saldo1)
        {
            Console.WriteLine("saldo Indisponivel");
          return  false;
        }
        else
        {
            sacar=   this.saldo -= valor;  
           return true;
        }
          
    }

         public void AdicionarLimite(double valor)
    {
        this.limite = valor;
    }

    public double ConsultaSaldoDisponivel()
    {
        // O limte foi pra mostrar o total, a soma do saldo e o limite.
    return this.saldo + this.limite;
    }
  

    public double RetomarSaque()
    {
        return this.sacar;
    }



}