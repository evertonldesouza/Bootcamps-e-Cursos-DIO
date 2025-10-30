//Desafio 2  
function pertenceAFibonacci(numero) {
  let a = 0, b = 1;
  while (a < numero) {
      let temp = a;
      a = b;
      b = temp + b;
  }
  return a === numero;
}

// Solicitar ao usuário que informe um número
let numeroInformado = parseInt(prompt("Informe um número: "));

// Verificar se o número pertence à sequência de Fibonacci
if (pertenceAFibonacci(numeroInformado)) {
  alert(`O número ${numeroInformado} pertence à sequência de Fibonacci.`);
} else {
  alert(`O número ${numeroInformado} NÃO pertence à sequência de Fibonacci.`);
}