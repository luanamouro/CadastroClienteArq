﻿using System;
class Cadastro
{
    double metragem = 0;
    int perfil;
    double valorproj = 0;
    int vmetragem = 0;
    double vexec = 0;
    bool exec = false;
   

    public Cadastro()
    {
        if (metragem > 100)
        {
            Console.WriteLine("Aceite parcerias!");

        };

        switch (perfil)
        {
            case 1:
                Console.WriteLine("Digite a metragem (m2) do imóvel.\n");
                metragem = Convert.ToDouble(Console.ReadLine());
                valorproj = metragem * 100;
                Console.WriteLine("Perfil 1 - Alto Padrão: Projeto em R$ {0}", valorproj);
                break;

            case 2:
                Console.WriteLine("Digite a metragem (m2) do imóvel.\n");
                metragem = Convert.ToDouble(Console.ReadLine());
                valorproj = metragem * 50;
                Console.WriteLine("Perfil 2 - Classe Média: Projeto em R$ {0}", valorproj);
                break;

            case 3:
                Console.WriteLine("Digite a metragem (m2) do imóvel.\n");
                metragem = Convert.ToDouble(Console.ReadLine());
                valorproj = metragem * 40;
                Console.WriteLine("Perfil 3 - Projeto Social: Projeto em R$ {0}", valorproj);
                break;

            default:
                Console.WriteLine("Valor inválido. Tente de novo!");
                break;
        }

        bool exec1() { 


        if (exec == false)
        {
            exec = true;


        } }

        if (valorproj > 3000 && vmetragem > 50)
        {
            vexec = 4000;
            Console.WriteLine("Valor sugerido R${0}/mes", vexec);
        }
        else
            {
                vexec = 3000;
                Console.WriteLine("Valor sugerido R${0}/mes", vexec);
            }

        }





class Program
{
    public static void Main(string[] args)
    {
            Cadastro Cliente1 = new Cadastro();
        
            Console.WriteLine(" Insira a metragem (m2):\n");


        Console.WriteLine(" Escolha uma das opções de projeto:\n" +
        "1- Alto Padrão\n" +
        "2- Classe Média\n" +
        "3- Projeto Social");
        int perfil = Convert.ToInt32(Console.ReadLine());

        
    }
}


