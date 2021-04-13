# CONHECENDO OS MODIFICADORES E SEUS MEMBROS

## REFERÊNCIA DO CÓDIGO BASEADO NA [UDEMY](https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/learn/lecture/12682973#overview)

UDSC 5 - Construtores, palavra this, sobrecarga, encapsulamento

- [ ] Visão geral do capítulo
- [ ] Material de apoio do capítulo
- [ ] Construtores
- [ ] Sobrecarga
- [ ] Sintaxe alternativa para inicializar valores
- [ ] Palavra this
- [ ] Encapsulamento
- [ ] Properties
- [ ] Auto Properties
- [ ] Ordem sugerida para implementação de membros de classe
- [x] Modificadores de acesso
- [ ] Exercício de fixação
- [ ] Correção do exercício - PARTE 1
- [ ] Correção do exercício - PARTE 2

![MODIFICADOR_MEMBROS](https://user-images.githubusercontent.com/52930033/113527484-0bc39e80-9594-11eb-8921-92cfe0209eb2.jpg)

Todos os tipos e membros de tipo têm um nível de acessibilidade. O nível de acessibilidade controla se eles podem ser usados de outro código em seu assembly ou outros assemblies. Use os seguintes modificadores de acesso para especificar a acessibilidade de um tipo ou membro ao declará-lo:

Classes e estruturas têm membros que representam seus dados e comportamento. Os membros de uma classe incluem todos os membros declarados na classe, junto com todos os membros (exceto construtores e finalizadores) declarados em todas as classes em sua hierarquia de herança. Membros privados em classes base são herdados, mas não são acessíveis a partir de classes derivadas.

> PUBLIC
>> O tipo ou membro pode ser acessado por qualquer outro código no mesmo assembly ou outro assembly que faz referência a ele.

- PRÓPRIA CLASSE
- SUBCLASSES NO ASSEMBLY
- CLASSES DO ASSEMBLY
- SUBCLASSES FORA DO ASSEMBLY
- CLASSES FORA DO ASSEMBLY

![csharp_public](https://user-images.githubusercontent.com/52793184/114537681-e1738000-9c28-11eb-996a-2f3955867432.png)


> PROCTECTED INTERNAL
>> O tipo ou membro pode ser acessado por qualquer código no assembly em que está declarado ou de dentro de uma classe derivada em outro

- PRÓPRIA CLASSE
- SUBCLASSES NO ASSEMBLY
- CLASSES DO ASSEMBLY
- SUBCLASSES FORA DO ASSEMBLY

![csharp_protectedinternal](https://user-images.githubusercontent.com/52793184/114537757-f2bc8c80-9c28-11eb-886d-8076950b7eac.png)


> INTERNAL
>>O tipo ou membro pode ser acessado por qualquer código no mesmo assembly, mas não de outro assembly.

- PRÓPRIA CLASSE
- SUBCLASSES NO ASSEMBLY
- CLASSES DO ASSEMBLY

![csharp_internal](https://user-images.githubusercontent.com/52793184/114537784-fb14c780-9c28-11eb-9621-cc0de82e082c.png)


> PROTECTED
>>O tipo ou membro pode ser acessado apenas por código na mesma classe ou em uma classe derivada dessa classe.

- PRÓPRIA CLASSE
- SUBCLASSES NO ASSEMBLY
- SUBCLASSES FORA DO ASSEMBLY

![csharp_protected](https://user-images.githubusercontent.com/52793184/114538026-47f89e00-9c29-11eb-93f4-33f8f469d2a0.png)


> PRIVATE PROTECTED
>>O tipo ou membro pode ser acessado somente em seu assembly declarante, por código na mesma classe ou em um tipo derivado dessa classe.

- PRÓPRIA CLASSE
- SUBCLASSES NO ASSEMBLY

![csharp_classprivateprotected](https://user-images.githubusercontent.com/52793184/114538772-1a602480-9c2a-11eb-978b-afb233010170.png)


![csharp_privateprotected](https://user-images.githubusercontent.com/52793184/114538065-50e96f80-9c29-11eb-81c8-14db882c937f.png)


> PRIVATE
>>O tipo ou membro pode ser acessado apenas por código na mesma classe ou estrutura.

- PRÓPRIA CLASSE

![csharp_private](https://user-images.githubusercontent.com/52793184/114538212-7eceb400-9c29-11eb-9864-2d823ee5c5aa.png)
