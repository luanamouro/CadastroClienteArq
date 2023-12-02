using System;
class Cadastro
{
    double metragem = 0;
    int perfil;
    double valorproj = 0;
    int vmetragem = 0;
    double vexec = 0;
    bool exec = false;


    public Cadastro(double metragem,int perfil, bool exec)
    {
        this.metragem = metragem;
        this.perfil = perfil;
        this.exec = exec;

        if (this.metragem > 100)
        {
            Console.WriteLine("Aceite parcerias!");

        };

        switch (this.perfil)
        {
            case 1:
                //Console.WriteLine("Digite a metragem (m2) do imóvel.\n");
               // metragem = Convert.ToDouble(Console.ReadLine());
                valorproj = this.metragem * 100;
                Console.WriteLine("Perfil 1 - Alto Padrão: Projeto em R$ {0}", valorproj);
                break;

            case 2:
                //Console.WriteLine("Digite a metragem (m2) do imóvel.\n");
                //metragem = Convert.ToDouble(Console.ReadLine());
                valorproj = this.metragem * 50;
                Console.WriteLine("Perfil 2 - Classe Média: Projeto em R$ {0}", valorproj);
                break;

            case 3:
                //Console.WriteLine("Digite a metragem (m2) do imóvel.\n");
               // metragem = Convert.ToDouble(Console.ReadLine());
                valorproj = this.metragem * 40;
                Console.WriteLine("Perfil 3 - Projeto Social: Projeto em R$ {0}", valorproj);
                break;

            default:
                Console.WriteLine("Valor inválido. Tente de novo!");
                break;
        }

        
        if (valorproj > 3000 && this.metragem > 50)
        {
            vexec = 4000;
            Console.WriteLine("Valor sugerido para obra R${0}/mes", vexec);
        }
        else
        {
            vexec = 3000;
            Console.WriteLine("Valor sugerido para obra R${0}/mes", vexec);
        }

    }





    class Program
    {
        public static void Main(string[] args)
        { 
            Console.WriteLine(" Insira a metragem (m2):\n");
            double metragem = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Metragem:{metragem}");


            Console.WriteLine(" Escolha uma das opções de projeto:\n" +
            "1- Alto Padrão\n" +
            "2- Classe Média\n" +
            "3- Projeto Social");
            int perfil = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Foi aceito execução de obra? Responda 'true' ou 'false'");
            bool exec = Convert.ToBoolean(Console.ReadLine());


            Cadastro Cliente1 = new Cadastro(metragem, perfil, exec);
        }
    }
}

