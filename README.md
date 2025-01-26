# **Login_Cadastro_windows-forms**

### **Descrição**
Este projeto é uma aplicação desktop em **Windows Forms** para autenticação e gerenciamento de usuários. Ele inclui funcionalidades de **login** e **cadastro**, com proteção contra **SQL Injection** e arquitetura baseada no padrão **MVC (Model-View-Controller)**. O banco de dados utilizado é **SQLite**.

O foco do projeto está em demonstrar boas práticas de desenvolvimento de aplicações desktop em C#, incluindo a separação de responsabilidades e segurança básica na manipulação de dados.

---

### **Funcionalidades**
- **Login de usuários**: Valida credenciais no banco de dados SQLite.
- **Cadastro de novos usuários**: Permite adicionar novos usuários ao banco de dados.
- **Proteção contra SQL Injection**: Todas as consultas utilizam parâmetros para evitar ataques.
- **Padrão MVC**: Implementa uma separação clara entre as camadas de Modelo, Controle e Visão.
- **Validações de entrada**: Verificação de campos obrigatórios no cadastro e login.

---

### **Estrutura do Projeto**
O projeto segue o padrão **MVC**, organizado da seguinte maneira:

```bash
Login_Cadastro_windows-forms/
├── Controllers/
│   └── UserController.cs       # Lógica de controle para operações de usuários.
├── Models/
│   ├── DataBaseHelper.cs       # Métodos para interação com o banco de dados SQLite.
│   └── User.cs                 # Representação da entidade 'Usuário'.
├── Views/
│   ├── Login.cs                # Interface de login do usuário.
│   ├── MainApplication.cs      # Tela principal após login bem-sucedido.
│   └── SingUp.cs               # Interface de cadastro de novos usuários.
└── Program.cs                  # Ponto de entrada da aplicação.
```

---

### **Componentes do Código**

#### **`Controllers/UserController.cs`**
Define a lógica principal para operações de usuários:
- **SingUp**: Cria um novo usuário no banco de dados.
- **Login**: Verifica as credenciais do usuário para autenticação.

---

#### **`Models/DataBaseHelper.cs`**
Centraliza as operações com o banco de dados SQLite:
- **Inicialização do banco**: Cria a tabela `Users` (caso não exista).
- **CreateUser**: Adiciona um novo usuário ao banco de dados.
- **VerifyLogin**: Verifica as credenciais fornecidas no banco.

---

#### **`Models/User.cs`**
Modelo para a entidade `User`:
- Propriedades: `Id`, `Name`, `Email` e `Password`.

---

#### **`Views/Login.cs`**
- Exibe a tela de login.
- Faz validação das credenciais no banco.
- Redireciona para a tela principal em caso de sucesso ou exibe mensagens de erro.

---

#### **`Views/SingUp.cs`**
- Exibe a tela de cadastro.
- Faz validação de campos obrigatórios.
- Cadastra novos usuários no banco e redireciona para a tela de login em caso de sucesso.

---

### **Configuração e Execução**

#### **Pré-requisitos**
- **.NET Framework ou .NET Core** (versão compatível com Windows Forms).
- **SQLite** (integrado no projeto via `Microsoft.Data.Sqlite`).

#### **Passos para execução**
1. **Clone o repositório**:
   ```bash
   git clone https://github.com/luiz0ph/Login_Cadastro_windows-forms.git
   cd Login_Cadastro_windows-forms
   ```
2. **Configure o banco de dados:** Certifique-se de que o arquivo `users.db` está acessível. Ele será criado automaticamente ao iniciar a aplicação.
3. **Abra o projeto no Visual Studio:** 
- **Compile o projeto.**
- **Pressione `F5` para executar.**
4. **Inicialização do banco:** O banco será automaticamente inicializado pela classe `DataBaseHelper` ao executar o programa pela primeira vez.

---

### **Banco de Dados**
O banco de dados é gerenciado com SQLite e contém uma tabela para armazenar os usuários:

```sql
CREATE TABLE Users (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Email TEXT NOT NULL UNIQUE,
    Password TEXT NOT NULL
);
```

---

### **Segurança**
- O projeto utiliza parâmetros em consultas SQL para prevenir ataques de SQL Injection.
- As credenciais são validadas diretamente no banco de dados.

---

### **Exemplo de Fluxo**
1. **Tela de Login:**
- Usuário insere e-mail e senha.
- Em caso de sucesso, a tela principal é exibida.
- Caso contrário, uma mensagem de erro é exibida.

2. **Tela de Cadastro:**
- Usuário insere nome, e-mail e senha.
- Em caso de sucesso, é redirecionado para a tela de login.

---

### **Possíveis Melhorias**
- **Hash de senhas:** Implementar o armazenamento de senhas com hashing (ex.: BCrypt).
- **Validação mais robusta:** Adicionar validação de e-mails e regras de senhas.
- **Teste unitário:** Criar testes para validar funcionalidades críticas (ex.: cadastro e login).

---

### **Licença**
Este projeto está licenciado sob a [MIT License.](https://opensource.org/license/mit)