# Programa de Hospedagem em Hotéis.

Realização do projeto proposto no Bootcamp da Pottencial .NET Developer.

No desafio foi solicitado a construção de um sistema que será usado para realizar uma reserva em um hotel. Também foi requisitado algumas regras e validações, sendo essas:

1. Não deve ser possível realizar uma reserva quando a capacidade da suíte for menor do que a quantidade de hóspedes. Exemplo: Se é uma suíte capaz de hospedar 2 pessoas, ao tentar passar 3, deverá retornar uma exception.
2. O método ObterQuantidadeHospedes da classe Reserva deverá retornar a quantidade total de hóspedes, enquanto que o método CalcularValorDiaria deverá retornar o valor da diária (Dias reservados x valor da diária).