
# Exercício 2: Possui a letra 'a'? 

Este programa lê um arquivo de texto chamado `consulta.txt` e verifica quantas vezes a letra 'a' (maiúscula ou minúscula) aparece no conteúdo.

## Como executar o programa

### Pré-requisitos

1. Certifique-se de que o .NET SDK está instalado em sua máquina. Para verificar, use o comando:

    ```bash
    dotnet --version
    ```

    Se o comando não funcionar, você pode instalar o .NET SDK a partir do [site oficial](https://dotnet.microsoft.com/download).

### Passos para executar:

1. **Restaure as dependências e compile o projeto:**

    ```bash
    dotnet restore
    dotnet build
    ```

2. **Certifique-se de que o arquivo `consulta.txt` está presente:**

    - O arquivo `consulta.txt` deve estar no mesmo diretório do projeto (onde o arquivo `.csproj` está localizado).
    - Insira no `consulta.txt` o texto que você deseja analisar.

3. **Execute o projeto:**

    ```bash
    dotnet run
    ```

4. **Interação com o programa:**

    O programa irá contar e informar quantas vezes a letra 'a' (maiúscula ou minúscula) aparece no texto fornecido no `consulta.txt`.

### Observações

- Se ocorrerem erros durante a execução, verifique se o arquivo `consulta.txt` está no local correto e se o .NET SDK está configurado corretamente.
