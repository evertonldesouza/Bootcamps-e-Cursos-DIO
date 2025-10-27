<h1 align="center">Bootcamp LocalizaLabs .NET Developer - Docker</h1>

<p align="center">Implementação do exercício final da etapa <strong>Introdução à orquestração de conteiners com Docker</strong></p>

---

### :dart: Objetivo

Tenho como objetivo implementar o último exercício proposto na etapa **Introdução à orquestração de conteiners com Docker** do Bootcamp LocalizaLabs .NET Developer. Documentando o passo a passo da atividade, servido como um repositório para consultas e estudos.

### Clone

**Este projeto foi clonado do repositório abaixo, clone você também em sua máquina local usando**

```
git clone https://github.com/luistkd4/docker101.git
```

Ou então clone este próprio repositório com pequenas modificações em sua máquina local usando:  

```
git clone https://github.com/YuriSiman/bootcamp-localizalabs-docker.git
```

---

## :rocket: Vamos Começar 

## Docker - Implementando o Projeto

Teremos nossa aplicação rodando dentro do **docker-compose**, com ele fazendo a orquestração dos nossos containers.  

Clone o repositório:

```
git clone https://github.com/YuriSiman/bootcamp-localizalabs-docker.git
```

Dentro da pasta `bootcamp-localizalabs-docker\docker101\express-mongo-docker` utilize o comando abaixo para ler e interpretar o arquivo **docker-compose.yaml**.  

```
docker-compose up -d
```

**Obs: o docker-compose não é nativo, então é necessário instalar o docker-compose em sua máquina.**   
Instalar **docker-compose**: https://docs.docker.com/compose/install/

**Obs: O Docker Desktop para Windows inclui o Compose junto com outros aplicativos Docker, portanto, a maioria dos usuários do Windows não precisa instalar o Compose separadamente.**  

Vamos agora utilizar o [Postman](https://www.postman.com/) para criar um novo usuário:

- Informamos a **url** como **POST** para http://localhost:8080/create
- Deixamos o **Body** como **JSON**
- Em **Headers** criamos a **key** `Content-Type` e o **value** `application/json`
- Informamos o corpo **JSON** dentro de **Body** com o nome do usuário que queremos criar:

```
{
    "name": "Yuri"
}	
```

- E então, clicamos em **SEND**.
- No response você verá o **status code 200 OK** e a mensagem **New User Created**
- Vá no seu `localhost:8080/users` e você verá o novo usuário criado

Agora, vamos editar nosso **"Hello World!"** que aparece em `localhost:8080` e alterar para **"Olá Mundo!"**. Para isso, vamos editar o arquivo **app.js**

De:

```
// routes
app = express();
app.use(express.json());
app.use(bodyParser.urlencoded({extended: false}));

app.get('/', function (req, res) {
  res.send('Hello World!\n');
});
```

Para:

```
// routes
app = express();
app.use(express.json());
app.use(bodyParser.urlencoded({extended: false}));

app.get('/', function (req, res) {
  res.send('Olá Mundo!\n');
});
```

Vamos rodar o camando abaixo para fazer o build da aplicação novamente, ele fará a buil somente das modificações.  

```
docker-compose up --build -d
```

Vá no seu `localhost:8080` e você verá a nova mensagem na tela **"Olá Mundo!**"  

Naturalmente quando subimos nossa aplicação, ela cria um novo usuário, então agora nós teremos dois **Lulas Moluscos** aparecendo.

Agora podemos apagar nossos containers.  

```
docker-compose down
```

Vamos verificar os containers, deverá estar vazio, sem o container que criamos.  

```
docker ps

ou

docker ps -a
```

Vamos agora subir novamente a nossa aplicação.  

```
docker-compose up --build -d
```

Agora nossa aplicação subiu pela terceira vez, devemos ter três **Lulas Moluscos**.

Vá no seu `localhost:8080/users` e você verá três **Lulas Moluscos** como usuários, e também o seu que já tínhamos criado anteriormente.  


* [Voltar ao Início](https://github.com/YuriSiman/bootcamp-localizalabs-docker/tree/master#bootcamp-localizalabs-net-developer---docker)  

---

## :thinking: Contribuindo

> Para começar...

### Passo 1

* :fork_and_knife: Fork este repositório!

### Passo 2

* :dancers: Clone este repositório para sua máquina local usando `git clone https://github.com/YuriSiman/bootcamp-localizalabs-docker.git`

### Passo 3

* :trident: Crie sua feature branch usando `git checkout -b minha-feature`

### Passo 4

* :white_check_mark: Commit suas mudanças usando `git commit -m "feat: Minha nova feature"`

### Passo 5

* :pushpin: Dê um push usando `git push -u origin minha-feature`

### Passo 6

* :arrows_clockwise: Crie um novo pull request

Depois que seu pull request for mesclado, você pode excluir sua feature branch  

> Caso tenha dúvidas, confira este guia de como [contribuir no GitHub](https://github.com/firstcontributions/first-contributions)  

---

## :speech_balloon: Suporte

> Entre em contato comigo...  

* Me chame pelo [Linkedin](https://www.linkedin.com/in/yurisiman/)  
* Me mande um e-mail [contato@yurisiman.com.br](mailto:contato@yurisiman.com.br)  

[![Github](https://img.shields.io/badge/github-profile-%237159c1?style=for-the-badge&logo=github)](https://github.com/YuriSiman)  
[![Curriculum](https://img.shields.io/badge/site-curriculum-%23563D7C?style=for-the-badge&logo=bootstrap)](https://yurisiman.com.br)  

---

## :pencil: Licença

[![License](https://img.shields.io/badge/license-mit-%23A6CE39?style=for-the-badge&logo=github)](https://github.com/YuriSiman/bootcamp-localizalabs-docker/blob/master/LICENSE)   

---

Code your life...
