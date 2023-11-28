//digite um caractere para ser encontrado no texto.

string frase = "nao e a linguagem de programacao que define o programador, mas sim sua logica.";

void caracter(string frase) {

    int contador = 0;
    string msg = "";

    Console.WriteLine($"Digite um caracter para ser encontrado na frase: {frase}");
    char digitado = Convert.ToChar(Console.ReadLine());

    for (int i = 0; i < frase.Length; i++) {
        if (digitado == frase[i]) { contador += 1;}

    }
    msg = contador != 0 ? $"Total de caracteres encontrados: {contador} \nCaracter: {digitado}" : $"Caracter nao encontrado \nCaracter: {digitado
    }";
    Console.WriteLine(msg);

}
caracter(frase);

