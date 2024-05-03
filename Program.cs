namespace dio_desafio_felipao;

class Program
{
    static void Main(string[] args)
    {
        // Cria um loop infinito
        while(true){

            // definindo um valor randomico
            Random numAleatorio = new Random();

            // Lendo a entrada do usuário
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            // Declarando as variaveis de xp e nivel, sendo a de xp um valor randomico
            int xp = numAleatorio.Next(1, 20000);
            string nivel = "";

            // Verificando a xp e definindo o nivel do usuário com base no valor randomico recebido anteriormente
            if(xp < 1000){
                nivel = "Ferro";
            }else if(xp <= 2000){
                nivel = "Bronze";
            }else if(xp <= 5000){
                nivel = "Prata";
            }else if(xp <= 7000){
                nivel = "Ouro";
            }else if(xp <= 8000){
                nivel = "Platina";
            }else if(xp <= 9000){
                nivel = "Ascendente";
            }else if(xp <= 10000){
                nivel = "Imortal";
            }else{
                nivel = "Radiante";
            }

            // imprimindo o resultado do desafio na tela
            Console.WriteLine($"O Herói de nome {nome} está no nível de {nivel}");

            Console.Write("Deseja continuar? [S/N]: ");
            string continuar = Console.ReadLine();
            if(continuar.ToUpper() != "S"){
                break;
            }
        }
    }
}
