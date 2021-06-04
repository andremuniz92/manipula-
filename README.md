# manipulae

Não conseguir finalizar o projeto de consumir a API do Youtube mas mando essa WebAPI, com as requisições de criar, ler, listar, atualizar e deletar vídeos. Onde os dados são armazenados no banco de dados SQLite. 


Para rodar o projeto:

## 1. Entrar na pasta WebAPI e dar o comando
```
dotnet run
```

## 2. Para as requisições utilizar os caminhos de acordo com a porta selecionada.
Por exemplo, se a porta for a 44370, utilizar um software para as requisições como o Postman ou o Insomnia com as seguintes requisições:

### Listar todos os vídeos
GET https://localhost:44370/api/videos

### Criar vídeo
POST https://localhost:44370/api/videos
Com um body em JSON do tipo:
{
    "id": 0,
    "title": "Pulp Fiction",
    "author": "Quentin Tarantino",
    "description": "Some histories"
}

### Atualizar vídeo
https://localhost:44370/api/videos?id=2
Com um body em JSON do tipo:
{
    "id": 2,
    "title": "Pulp Fiction",
    "author": "Quentin Tarantino",
    "description": "Some histories"
}
Passando o "param" do id 

### Ver vídeo específico
GET https://localhost:44370/api/videos/2
Passando o id do vídeo na requisição

### Deletar vídeo
DELETE https://localhost:44370/api/videos/3
Passando o id do vídeo na requisição
