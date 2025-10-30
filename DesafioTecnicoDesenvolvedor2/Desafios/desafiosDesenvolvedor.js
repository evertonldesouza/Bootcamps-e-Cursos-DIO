// Desafio 1
/*
int INDICE = 13, SOMA = 0, K = 0;
Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; }
Imprimir(SOMA);

Resultado:
SOMA = 91
*/

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
let numero = parseInt(prompt("Informe um número: "));

// Verificar se o número pertence à sequência de Fibonacci
if (pertenceAFibonacci(numero)) {
    alert(`O número ${numero} pertence à sequência de Fibonacci.`);
} else {
    alert(`O número ${numero} NÃO pertence à sequência de Fibonacci.`);
}


//Desafio 3

const faturamentoMensal = [
	{
		"dia": 1,
		"valor": 22174.1664
	},
	{
		"dia": 2,
		"valor": 24537.6698
	},
	{
		"dia": 3,
		"valor": 26139.6134
	},
	{
		"dia": 4,
		"valor": 0.0
	},
	{
		"dia": 5,
		"valor": 0.0
	},
	{
		"dia": 6,
		"valor": 26742.6612
	},
	{
		"dia": 7,
		"valor": 0.0
	},
	{
		"dia": 8,
		"valor": 42889.2258
	},
	{
		"dia": 9,
		"valor": 46251.174
	},
	{
		"dia": 10,
		"valor": 11191.4722
	},
	{
		"dia": 11,
		"valor": 0.0
	},
	{
		"dia": 12,
		"valor": 0.0
	},
	{
		"dia": 13,
		"valor": 3847.4823
	},
	{
		"dia": 14,
		"valor": 373.7838
	},
	{
		"dia": 15,
		"valor": 2659.7563
	},
	{
		"dia": 16,
		"valor": 48924.2448
	},
	{
		"dia": 17,
		"valor": 18419.2614
	},
	{
		"dia": 18,
		"valor": 0.0
	},
	{
		"dia": 19,
		"valor": 0.0
	},
	{
		"dia": 20,
		"valor": 35240.1826
	},
	{
		"dia": 21,
		"valor": 43829.1667
	},
	{
		"dia": 22,
		"valor": 18235.6852
	},
	{
		"dia": 23,
		"valor": 4355.0662
	},
	{
		"dia": 24,
		"valor": 13327.1025
	},
	{
		"dia": 25,
		"valor": 0.0
	},
	{
		"dia": 26,
		"valor": 0.0
	},
	{
		"dia": 27,
		"valor": 25681.8318
	},
	{
		"dia": 28,
		"valor": 1718.1221
	},
	{
		"dia": 29,
		"valor": 13220.495
	},
	{
		"dia": 30,
		"valor": 8414.61
	}
]

function analisarFaturamento(dados) {
    const diasComFaturamento = dados.filter(d => d.valor > 0);
    const valores = diasComFaturamento.map(d => d.valor);

    const menor = Math.min(...valores);
    const maior = Math.max(...valores);

    const soma = valores.reduce((acc, val) => acc + val, 0);
    const media = soma / valores.length;

    const diasAcimaDaMedia = valores.filter(v => v > media).length;

    console.log(`Menor faturamento: R$ ${menor.toFixed(2)}`);
    console.log(`Maior faturamento: R$ ${maior.toFixed(2)}`);
    console.log(`Dias com faturamento acima da média: ${diasAcimaDaMedia}`);
}

analisarFaturamento(faturamentoMensal);

//Desafio 4

const faturamentoEstado = {
	SP: 67836.43,
	RJ: 36678.66,
	MG: 29229.88,
	ES: 27165.48,
	Outros: 19849.53
  };
  
  // Calcula o total
  const total = Object.values(faturamentoEstado).reduce((acc, val) => acc + val, 0);
  
  // Calcula o percentual de cada estado
  for (const estado in faturamentoEstado) {
	const valor = faturamentoEstado[estado];
	const percentual = (valor / total) * 100;
	console.log(`${estado}: ${percentual.toFixed(2)}%`);
  }
  

//Desafio 5

function inverterString(str) {
	let invertida = "";
  
	// Percorre a string de trás para frente
	for (let i = str.length - 1; i >= 0; i--) {
	  invertida += str[i];
	}
  
	return invertida;
  }
  
  // Exemplo
  const texto = "TesteDesafio";
  const resultado = inverterString(texto);
  console.log(`Original: ${texto}`);
  console.log(`Invertida: ${resultado}`);
  