namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {

        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public int Memoria { get; set; }


        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;


        }
        /*Protected Smartphone(string modelo, string imei, int memoria)
        {
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }
        */
        public void FichaTecnica()
        {
            Console.WriteLine($"Modelo: {Modelo}\nIMEI: {Imei}\nMemória: {Memoria}GB");
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando do ... {Numero}");  
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}