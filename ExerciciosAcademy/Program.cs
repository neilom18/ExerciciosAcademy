using System;
using System.Linq;

namespace ExerciciosAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            /*if (DigitInput())
            {
                Console.WriteLine($"Esse valor é um digito");
            }
            // Exercicio 2
            Console.WriteLine(ConvertStringToAscii());
            // Exercicio 3
            //Console.WriteLine(ConvertIntToCharAsci);
            // Exercicio 4
            if (IsUperrCase())
            {
                    Console.WriteLine($"O valor é um caracter maiúsculo");
            }
            else
            {
                Console.WriteLine($"O valor não é um caracter maiúsculo ou ocorreu um erro na verificação");
            }
            // Exercicio 5
            if (IsLowerCase())
            {
                Console.WriteLine($"O valor é um caracter minúsculo");
            }
            else
            {
                Console.WriteLine($"O valor não é um caracter minúsculo ou ocorreu um erro na verificação");
            }
            // Exercicio 6
            var upperCase = LowerToUpper();
            if(upperCase != null) 
            { 
                Console.WriteLine($"O caracter em maiúsculo é -> {upperCase}"); 
            }
            // Exercicio 7
            var lowerCase = UpperToLower();
            if(lowerCase != null || lowerCase != ' ')
            { 
                Console.WriteLine($"O caracter em minúsculo é -> {lowerCase}"); 
            }
            // Exercicio 8
            var input = Console.ReadFile();
            Console.WriteLine(input);
            // Exercicio 9
            Console.WriteLine(StringToUpper());
            // Exercicio 10
            Console.WriteLine(StringToLower());
            // Exercicio 11
            Console.WriteLine(ConcatDoisInput());
            // Exercicio 12
            Console.WriteLine(StringInvertida());
            // Exercicio 13
            var stringReduzida = RemoverUltimosCarac();
            Console.WriteLine($@"Essa palavra/frase sem os 4 ultimos caracteres ficou: {stringReduzida}");
            // Exercicio 14
            Console.WriteLine($"Ao trocar A por B fica -> {ReplaceAforB()}");
            // Exercicio 15
            Console.WriteLine($"A primeira palavra era {DividirPalavras()}");
            // Exercicio 16
            Console.WriteLine($"Oque você digitou sem espaços desnecessários ->{RemoverEspacos()}");
            // Exercicio 17
            Console.WriteLine($"Retirando os caracteres repetidos fica -> {RemoverCaracRepetido()}");
            // Exercicio 18
            Console.WriteLine($"A palavra que digitou sem as vogais fica -> {RemoverVogal()}");
            // Exercicio 19
            Console.WriteLine($"Foi digitado {CountPalavras()} palavras");
            // Exercicio 20
            if (Q20()) {
                Console.WriteLine("Voce digitou C# na frase, você foi avisado");
            }
            else
            {
                Console.WriteLine("Nenhuma palavra começa com C#");
            }
            // Exercicio 21
            Console.WriteLine("Escreva uma palavra");
            var input1 = Console.ReadLine();
            Console.WriteLine($"Essa palavra contem {CountVogal(input1)} vogais e {CountConsoantes(input1)} consoantes");
            // Exercicio 22
            Console.WriteLine($"A letra que mais aparece é {Q22()}");
            // Exercicio 23
            int[] numeroCarac = Q23();
            Console.WriteLine($@"Caracteres do: alfabeto -> {numeroCarac[0]}
                                                especiais -> {numeroCarac[1]}
                                                digitos -> {numeroCarac[2]}");
            // Exercicio 24
            Console.WriteLine(Q24());
            // Exercicio 26
            Console.WriteLine(Q26());
            // Exercicio 27
            Console.WriteLine(Q27());
            // Exercicio 28
            Console.WriteLine($"O resto é: {Q28():0.00}");
            // Exercicio 29
            Console.WriteLine($"O resto é: {Q29():C}");
            // Exercicio 30
            if(Q30())
            {
                Console.WriteLine("Os dois valores são iguais");
            }else{
                Console.WriteLine("Os dois valores não são iguais");
            }
            // Exercicio 31
            Console.WriteLine(ParOuImpar(1));
            // Exercicio 32
            Console.WriteLine("Digite um número:");
            string valor1 = Console.ReadLine();
            Console.WriteLine("Digite mais um número:");
            string valor2 = Console.ReadLine();
            if(int.TryParse(valor1, out int v1)){
                if (Q32(v1))
                {
                    Console.WriteLine($"O {valor1} está entre 100 e 200");
                }
            }
            if (int.TryParse(valor2, out int v2))
            {
                if (Q32(v2))
                {
                    Console.WriteLine($"O {valor2} está entre 100 e 200");
                }
            }
            // Exercicio 33
            Console.WriteLine($"Você digitou um valor {Q33()}");
            // Exercicio 34
            if (Q34())
            {
                Console.WriteLine("Esse ano é bissexto");
            }
            else { Console.WriteLine("Esse ano não é bissexto"); }
            // Exercicio 35
            if (Q35()) 
            { 
                Console.WriteLine("Você pode votar"); 
            } 
            else { Console.WriteLine("Você não pode votar"); }
            // Exercicio 36
            Console.WriteLine($"Você é {Q36()}");
            // Exercicio 37
            Console.WriteLine($"O maior valor é {Q37()}");
            // Exercicio 38
            Console.WriteLine(Q38());
            // Exercicio 39
            Console.WriteLine(Q39()[0]);
            // Exercicio 40
            Console.WriteLine(Q40());
            // Exercicio 41
            string[] meuArray = { "abc", "ola", "falmengo" };
            string[] meuArray2 = Q41(meuArray);
            Console.WriteLine(meuArray2[0]);
            // Exercicio 42
            Console.WriteLine(Q42());
            // Exercicio 43
            // Exercicio 44
            // Exercicio 45
            Q45();
            // Exercicio 46
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            // Exercicio 47
            Console.WriteLine(Q47());*/
            // Exercicio 48
            Q48();
            // Exercicio 49
            // Exercicio 50
            // Exercicio 51
            // Exercicio 52
            // Exercicio 53
            // Exercicio 54
            // Exercicio 55
            // Exercicio 56
            // Exercicio 57
            // Exercicio 58
        }
        static bool DigitInput() 
        {
            Console.WriteLine("Digite um digito");
            var input = Console.ReadLine();
            if (char.TryParse(input, out char c))
            {
                if (char.IsDigit(c)) { return true; }
                else { return false; }
            }
            else
            {
                return false;
            }
        }
        static int? ConvertStringToAscii()
        {
            Console.WriteLine("Digite um digito para saber seu valor na tabela ASCII");
            var input = Console.ReadLine();
            if (char.TryParse(input, out char c))
            {
                int? AsciCOde = (int?)c;
                return AsciCOde;
            }
            else
            {
                return null;
            }
        }
        static char? ConvertIntToCharAsci()
        {
            Console.WriteLine("Digite um valor para saber o digito correspondente na tabea ASCII");
            var input = Console.ReadLine();
            try
            {
                var c = Convert.ToInt32(input);
                char ascii = Convert.ToChar(c);
                return ascii;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu o erro {e.GetType().FullName} durante a execução");
                return null;
            }
        }
        static bool IsUperrCase()
        {
            Console.WriteLine("Digite um digito");
            var input = Console.ReadLine();
            try
            {
                var c = Convert.ToChar(input);
                return char.IsUpper(c);
            }
            catch
            {
                Console.WriteLine("Ocorreu um erro para verificar se é um caracter maiúsculo");
                return false;
            }
        }
        static bool IsLowerCase()
        {
            Console.WriteLine("Digite um digito");
            var input = Console.ReadLine();
            try
            {
                var c = Convert.ToChar(input);
                return char.IsLower(c);
            }
            catch
            {
                Console.WriteLine("Ocorreu um erro para verificar se é um caracter minúsculo");
                return false;
            }
        }
        static char? LowerToUpper()
        {
            Console.WriteLine("Digite um caracter para transforma de minúsculo para maiúsculo");
            var input = Console.ReadLine();
            try
            {
                var c = Convert.ToChar(input);
                if (char.IsUpper(c))
                {
                    return null;
                }
                else {
                    c = char.ToUpper(c);
                }
                return c;
            }
            catch
            {
                Console.WriteLine($"Não foi possivel transformar o caracter em maiúsculo");
                return null;
            }
        }
        static char? UpperToLower()
        {
            Console.WriteLine("Digite um caracter para transformar de maiúsculo para minúsculo");
            var input = Console.ReadLine();
            try
            {
                var c = Convert.ToChar(input);
                if (char.IsLower(c))
                {
                    return null;
                }
                else
                {
                    c = char.ToLower(c);
                }
                return c;
            }
            catch
            {
                Console.WriteLine($"Não foi possivel transformar o caracter em minúsculo");
                return null;
            }
        }
        static string StringToUpper()
        {
            Console.WriteLine("Digite uma string para transformala em maiúscula");
            var input = Console.ReadLine();
            return input.ToUpper();
        }
        static string StringToLower()
        {
            Console.WriteLine("Digite uma string para transformala em minúscula");
            var input = Console.ReadLine();
            return input.ToLower();
        }
        static string ConcatDoisInput()
        {
            Console.WriteLine("Digite duas strings para concatená-las");
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();
            return input1 + " " + input2;
        }
        static string StringInvertida()
        {
            Console.WriteLine("Digite uma frase para inverte-la");
            var input = Console.ReadLine();
            string textoInvertido = new string(input.Reverse().ToArray());
            return textoInvertido;
        }
        static string RemoverUltimosCarac() 
        {
            Console.WriteLine(@"Digite uma palavra/frase com mais de 4 caracteres");
            var input = Console.ReadLine();
            input = input.Remove(input.Length - 5);
            return input;
        }
        static string ReplaceAforB()
        {
            Console.WriteLine("Digite uma palavra");
            var input = Console.ReadLine();
            input = input.Replace('a', 'b');
            return input;
        }
        static string DividirPalavras()
        {
            Console.WriteLine("Digite mais de uma palavra");
            var input = Console.ReadLine();
            string[] dividido = input.Split(' ');
            string divididoPorVirgula = string.Join(',',dividido);
            return dividido[0];
        }
        static string RemoverEspacos()
        {
            Console.WriteLine("Digite uma frase com espaço antes e depois");
            var input = Console.ReadLine();
            input = input.Trim();
            return input;
        }
        static string RemoverCaracRepetido()
        {
            Console.WriteLine("Digite uma palavra");
            var input = Console.ReadLine();
            foreach(var letra in input)
            {
                if(input.IndexOf(letra) != input.LastIndexOf(letra))
                {
                    input = input.Remove(input.LastIndexOf(letra), 1);
                }
            }
            return input;
        }
        static string RemoverVogal()
        {
            Console.WriteLine($"Digite uma palavra");
            var input = Console.ReadLine();
            char[] vogais = { 'a','e','i','o','u' };
            foreach (var letra in input)
            {
                int index = input.IndexOfAny(vogais);
                if(index != -1)
                {
                    input = input.Remove(index, 1);
                }
            }
            return input;
        }
        static int CountPalavras()
        {
            Console.WriteLine("Escreva uma frase:");
            var input = Console.ReadLine().Trim();
            string[] palavras = input.Split(' ');
            return palavras.Length;
        }
        static bool Q20()
        {
            Console.WriteLine("Escreva uma frase que não contenha a palavra C#");
            var input = Console.ReadLine().Trim();
            string[] dividido = input.Split(' ');
            foreach(var palavra in dividido)
            {
                if(palavra.Substring(0, 2) == "C#")
                {
                    return true;
                }
            }
            return false;
        }
        static int CountVogal(string frase)
        {
            char[] vogais = { 'a', 'e', 'i', 'o', 'u' };
            var count = 0;
            foreach (var letra in frase)
            {
                int index = frase.IndexOfAny(vogais);
                if (index != -1)
                {
                    frase = frase.Remove(index, 1);
                    count++;
                }

            }
            return count;
        }
        static int CountConsoantes(string frase)
        {
            char[] consoante = { 'b','c','d','f','g','h','j','k','l','m','n','p','q','r','s','t','v','w','y','z' };
            int index = 0;
            var count =0;
            foreach (var letra in frase)
            {
                index = frase.IndexOfAny(consoante);
                if (index != -1)
                {
                    frase = frase.Remove(index, 1);
                    count++;
                }
            }
            return count;
        }
        static char Q22() 
        {
            Console.WriteLine("Escreva uma frase");
            var input = Console.ReadLine().Trim();
            var count = 0;
            var maior = 0;
            char maisrep = '\0';
            for(int i = 0; i < input.Length; i++) 
            {
                foreach (var letra in input)
                {
                    if(input[i] == letra)
                    {
                        count++;
                    }
                }
                if (count > maior)
                {
                    maior = count;
                    maisrep = input[i];
                }
                count = 0;
            }
            return maisrep;
        }
        static int[] Q23()
        {
            Console.WriteLine("Escreva uma frase:");
            var input = Console.ReadLine().Trim().ToLower();
            var alfabeto = CountConsoantes(input) + CountVogal(input);
            int[] result = new int[3];
            result[0] = alfabeto;
            string especiais = @"! ? # @ $ % ¨¨ & * ã á é â ê ç";
            string[] arrayEspecial = especiais.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            char[] charArray = new char[arrayEspecial.Length];
            var countEspeciais = 0;
            var i = 0;
            var digit = 0;
            foreach(var letra in arrayEspecial)
            {
                if(Char.TryParse(letra, out char c))
                {
                    charArray[i] = c;
                }
                i++;
            }
            foreach (var letra in input)
            {
                int index = input.IndexOfAny(charArray);
                if (index != -1)
                {
                    input = input.Remove(index, 1);
                    countEspeciais++;
                }
                if (char.IsDigit(letra))
                {
                    digit++;
                }
                
            }
            result[1] = countEspeciais;
            result[2] = digit;
            return result;
        }
        static string Q24()
        {
            Console.WriteLine("Escreva uma frase");
            var input = Console.ReadLine().Trim();
            char[] charInput = new char[input.Length];
            for (int i = 0; i < charInput.Length; i++)
            {
                charInput[i] = input[i];
            }
            string inputComEspaco = string.Join(" ", charInput);
            return inputComEspaco;
        }
        static int? Q26() 
        {
            Console.WriteLine("Digite o primeiro valor:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo valor:");
            string input2 = Console.ReadLine();
            int result;
            try
            {
                if (int.TryParse(input1, out int valor1) && int.TryParse(input2, out int valor2))
                {
                    result = valor1 + valor2;
                    return result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu o erro {ex.GetType().FullName}");
            }
            return null;
        }
        static int? Q27()
        {
            Console.WriteLine("Digite o primeiro valor:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo valor:");
            string input2 = Console.ReadLine();
            int result;
            try
            {
                if (int.TryParse(input1, out int valor1) && int.TryParse(input2, out int valor2))
                {
                    result = valor1 % valor2;
                    return result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu o erro {ex.GetType().FullName}");
            }
            return null;
        }
        static double? Q28()
        {
            Console.WriteLine("Digite o primeiro valor:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo valor:");
            string input2 = Console.ReadLine();
            double result;
            try
            {
                if (double.TryParse(input1, out double valor1) && double.TryParse(input2, out double valor2))
                {
                    result = valor1 % valor2;
                    return result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu o erro {ex.GetType().FullName}");
            }
            return null;
        }
        static double? Q29()
        {
            Console.WriteLine("Digite o primeiro valor:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo valor:");
            string input2 = Console.ReadLine();
            double result;
            try
            {
                if (double.TryParse(input1, out double valor1) && double.TryParse(input2, out double valor2))
                {
                    result = valor1 % valor2;
                    return result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu o erro {ex.GetType().FullName}");
            }
            return null;
        }
        static bool Q30()
        {
            Console.WriteLine("Digite o primeiro valor:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo valor:");
            string input2 = Console.ReadLine();
            try
            {
                if (int.TryParse(input1, out int valor1) && int.TryParse(input2, out int valor2))
                {
                    if(valor1 == valor2)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu o erro {ex.GetType().FullName}");
            }
            return false;
        }
        static string ParOuImpar(int valor)
        {
            if(valor % 2 == 0)
            {
                return "par";
            }
            else { return "impar"; }
        }
        static bool Q32(int valor)
        {
            if(valor >= 100 && valor <= 200)
            {
                return true;
            }
            else { return false; }
        }
        static string Q33()
        {
            Console.WriteLine("Digite um valor positivo ou negativo");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int valor))
            {
                bool positivo = valor > 0;
                bool negativo = valor < 0;
                if (positivo)
                {
                    return "positivo";
                }
                else if (negativo)
                {
                    return "negativo";
                }
                else
                {
                    return "neutro";
                }
            }
            else
            {
                return "Ocorreu um erro na conversão";
            }
        }
        static bool Q34()
        {
            Console.WriteLine("Digite um ano:");
            int ano = int.Parse(Console.ReadLine());
            if (DateTime.IsLeapYear(ano))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool Q35()
        {
            Console.WriteLine("Digite a sua idade");
            int idade = int.Parse(Console.ReadLine());
            if(idade >= 16)
            {
                return true;
            }
            else { return false; }
        }
        static string Q36()
        {
            Console.WriteLine("Digite sua altura");
            double altura = double.Parse(Console.ReadLine());
            if (altura <= 1.40)
            {
                return "Anão";
            }else if(altura <= 1.60)
            {
                return "baixo";
            }else if(altura <= 1.80)
            {
                return "alto";
            }
            else
            {
                return "gigante";
            }
        }
        static int Q37()
        {
            var maior = 0;
            int[] valores = { 1, 3, 2 };
            foreach(int valor in valores)
            {
                if(valor > maior) { maior = valor; }
            }
            return maior;
        }
        static string Q38()
        {
            /*string[] array = new string[5];
            
            array = array.Append("Eae galera").ToArray();
            array = array.Append("990889890").ToArray();
            array = array.Append("rqwer1#4$wqk!@").ToArray();
            array = array.Append("wer#$$99qe2qrk").ToArray();
            array = array.Append("wer#$$99qe3423423425rk").ToArray();
            array = array.Append("rqwer1#4$w424245k!@").ToArray();
            array = array.Append("rqw34234242wewaqwer5k!@").ToArray();
            string newstring = string.Join(',', array).Trim();
            return newstring;*/
            var array = new[] { "Fred", "Freddy" };
            array = array.Concat(new[] { "Frederick" }).ToArray();
            string stringArray = string.Join(',', array);
            return stringArray;
        }
        static int[] Q39() 
        {
            var n = 10;
            int[] valores = new int[n];
            for(int i = 0; i < n; i++)
            {
                valores[i] = i;
            }
            Array.Reverse(valores);
            return valores;
        }
        static int Q40()
        {
            int[] valores = {1,9,18,22};
            int soma = 0;
            foreach(var valor in valores)
            {
                soma += valor;
            }
            return soma;
        }
        static string[] Q41(string[] array)
        {
            var copyarray = new string[array.Length];
            array.CopyTo(copyarray, 0);
            return copyarray;
        }
        static int Q42()
        {
            char[] array = { 'a', 'b', 'c', 'd', 'a', 'b', 'c', 'd', 'a' };
            int count = 0;
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                foreach(char c in array)
                {
                    if (c.Equals(array[i]))
                    {
                        count += array.Count(c => c.Equals(array[i]));
                        for(j = i; j < array.Length; j++)
                        {
                            if (array[j].Equals(array[i]))
                            {
                                array[j] = ' ';
                            }
                        }
                    }                   
                }
            }
            foreach(char c in array)
            {
                Console.WriteLine(c);
            }
            return count;
        }
        static void Q45() 
        { 
            int[] array1 = new int[100];
            int[] array2 = new int[100];
            int index1 = 0;
            int index2 = 0;
            for (int i = 1;i <= 100; i++)
            {
                if(i % 2 == 0)
                {
                    array1[index1] = i;
                    index1++;
                }
                else 
                { 
                    array2[index2] = i;
                    index2++;
                }
            }
            foreach(int i in array1)
            {
                Console.WriteLine(i);
            }
            foreach (int i in array2)
            {
                Console.WriteLine(i);
            }
        }
        static string Q47()
        {
            DateTime date1 = new DateTime(2009, 8, 1, 0, 0, 0);
            DateTime date2 = new DateTime(2009, 8, 1, 12, 0, 0);
            int result = DateTime.Compare(date1, date2);
            string relacao;

            if (result < 0)
                relacao = "ocorreu antes de";
            else if (result == 0)
                relacao = "ocorreu ao mesmo tempo que";
            else
                relacao = "ocorreu depois de";
            return date1 + " " + relacao + " " + date2;
        }
        static void Q48()
        {
            DateTime date1 = new DateTime(2021, 11,1);
            DateTime date2 = date1.AddMonths(1);
            int dias = DateTime.Compare(date2, date1);
            Console.WriteLine(dias);
        }
    }
}
