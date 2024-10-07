# Sistema de Hospedagem
Sistema de gerenciamento de hospedagem desenvolvido em C#

# Proposta
![image](https://github.com/user-attachments/assets/07dbb6e5-f0dc-4c29-ab27-ffe2ea5089d9)


A classe contém 2 variáveis, sendo: 


**precoPorDiaria**: Tipo decimal. É o preço cobrado por dia de permanência do hospede. 


**pessoas**: É uma lista de string, representando uma coleção de pessoas hospedadas. Contém apenas o nome dos hospedes.

A classe contém três métodos, sendo:

**AdicionarReserva**: Método responsavél por receber o nome completo do hospede.

**RemoverReserva**: Método responsável por verificar se um determinado hospede se encontra no hotel, e caso positivo, irá pedir a quantidade de dias que ele permaneceu no hotel. Após isso, realiza o seguinte cálculo: **decimal valorTotal = precoPorDiaria * dias**, exebindo para o usuário.

**ListarReserva**: Lista todos os hospedes presentes atualmente no hotel. Caso não haja nenhum, exibir a mensagem "Não há clientes hospedados".


Menu interativo com as seguintes ações implementadas:
1. Cadastrar Hospede
2. Remover Hospede
3. Listar Hospedagens
4. Encerrar


