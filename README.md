# 📘 Conhecendo os Modificadores e Seus Membros

Este repositório contém estudos baseados no curso da [Udemy](https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/learn/lecture/12682973#overview), focados nos conceitos fundamentais da Programação Orientada a Objetos com **C#**, incluindo:

> UDSC 5 - Construtores, palavra `this`, sobrecarga, encapsulamento e modificadores de acesso.

---

## 📚 Conteúdo Abordado

* [ ] Visão geral do capítulo
* [ ] Material de apoio do capítulo
* [ ] Construtores
* [ ] Sobrecarga de Construtores
* [ ] Inicialização Alternativa
* [ ] Palavra-chave `this`
* [ ] Encapsulamento
* [ ] Properties
* [ ] Auto Properties
* [ ] Ordem sugerida de membros
* [x] **Modificadores de Acesso**
* [ ] Exercício de fixação
* [ ] Correção do exercício - Parte 1
* [ ] Correção do exercício - Parte 2

---

## 🔐 Modificadores de Acesso em C\#

Todos os tipos e membros em C# possuem um **nível de acessibilidade** que define seu escopo de visibilidade. Os principais modificadores são:

---

### ✅ `public`

> Acessível de qualquer lugar — dentro ou fora do assembly.

```csharp
public class Pessoa
{
    public string Nome;
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}");
    }
}
```

---

### 🛡️ `protected internal`

> Acessível no mesmo assembly **ou** por classes derivadas em outros assemblies.

```csharp
public class Funcionario
{
    protected internal decimal Salario;
}
```

---

### 🏠 `internal`

> Acessível **apenas dentro do mesmo assembly**.

```csharp
internal class Relatorio
{
    public void Gerar() => Console.WriteLine("Relatório gerado.");
}
```

---

### 🔒 `protected`

> Acessível apenas na própria classe e em classes derivadas, mesmo em outros assemblies.

```csharp
public class Animal
{
    protected void Respirar()
    {
        Console.WriteLine("Animal respirando...");
    }
}

public class Cachorro : Animal
{
    public void Executar()
    {
        Respirar();
    }
}
```

---

### 🧿 `private protected`

> Acessível **somente no mesmo assembly**, por meio da classe ou subclasse.

```csharp
public class Documento
{
    private protected void Imprimir()
    {
        Console.WriteLine("Imprimindo documento...");
    }
}
```

---

### 🔐 `private`

> Acessível **somente na própria classe** ou estrutura.

```csharp
public class Conta
{
    private decimal saldo;

    private void AtualizarSaldo()
    {
        saldo += 100;
    }
}
```

---

## 📸 Visão Geral dos Modificadores

![modificadores-csharp](https://user-images.githubusercontent.com/52930033/113527484-0bc39e80-9594-11eb-8921-92cfe0209eb2.jpg)

---

## 📬 Entre em Contato

Entre em contato para **colaborações, dúvidas ou consultorias**:

* ✉️ **Email Pessoal**: [daniloopro@gmail.com](mailto:daniloopro@gmail.com)
* 🏢 **Email Empresarial (DevsFree)**: [devsfree@devsfree.com.br](mailto:devsfree@devsfree.com.br)
* 📊 **Consultoria (dopme.io)**: [contato@dopme.io](mailto:contato@dopme.io)
* 💼 **LinkedIn**: [Danilo O. Pinheiro](https://www.linkedin.com/in/daniloopinheiro)
* 💻 **Artigos e Blogs**:

  * [Dev.to](https://dev.to/daniloopinheiro)
  * [Medium](https://medium.com/@daniloopinheiro)
  * [shifters.dev](https://shifters.dev/daniloopinheiro)
