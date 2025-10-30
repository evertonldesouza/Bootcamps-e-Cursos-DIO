1
function inverterString(str) {
	let invertida = "";
  
	// Percorre a string de trás para frente
	for (let i = str.length - 1; i >= 0; i--) {
	  invertida += str[i];
	}
  
	return invertida;
  }
  
  // Exemplo de uso
  const texto = "TesteDesafio";
  const resultado = inverterString(texto);
  console.log(`Original: ${texto}`);
  console.log(`Invertida: ${resultado}`);