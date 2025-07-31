# **Documentação do Projeto: Drako-Shooter com Pygame.**
---
## **1.Visão Geral**
**Tecnologias Utilizadas:** Unity 5;

**Descrição:** Desenvolvimento de um jogo no estilo space invaders, com mecânicas simples, o jogo se passa em um ambiente devastado e com temática pós apocalíptica, onde o jogador assume o papel de um piloto com o objetivo de vencer a tirania das máquinas que oprimem a humanidade, enfrentando inimigos e chefes poderosos até alcançar seu objetivo.

**Objetivo:** Apresentar um jogo com mecânicas simples(movimentação, inimigos, projéteis, batalhas de chefe, sistema de melhorias.) e com estética reconhecível.
## **2. Descrição Detalhada do Projeto**
- **O que é o gênero "Space Invaders"?**
  - Se trata basicamente de um gênero de jogos que consiste em uma forma de jogatina único, conhecido também popularmente como jogo de naves, pois os jogos englobados por esse gênero costumam ter como mecânica principal a batalha entre aeronaves, com mecânicas de upgrade características que geram um fator replay a mais para os jogos nesse estilo.
### **2.1 Funcionalidades Principais**
- **Motor do Jogo:**
  - Sistemas de Upgrades;
  - Movimentação para as direções primárias (direita, esquerda);
  - Projéteis (tanto inimigos quanto lançados pelo jogador);
  - Sistema de aumento de dificuldade por nível e sistema de pontuação;
  - Detecção de colisões e sistema de PV(pontos de vida) para jogadores e inimigos.
- **Interface Gráfica:**
  - Display de pontuação, PV e número da fase;
  - Renderização de telas: início, pausa e game over.
- **Extras:** 
  - Efeitos sonoros (disparos, dano causado e recebido, game over, inimigo destruído, vitória de fase, upgrade adquirido.);
  - Sprite responsivo (animações para a movimentação, para os inimigos e para o jogador, para o cenário, para a morte de inimigos e do jogador.);
  - Comandos de voz opcionais para dar início ao jogo, utilizando um comando pré-definido.

### **2.2 Arquitetura do Código**

    DrakoS/

      ├── Scripts/ # Armazenamento dos scripts do projeto

        ├── Player/ # Scripts do jogador

        ├── Enemies/ # Scripts dos inimigos

        ├── Misc/ # Scripts do jogo em si / Interface do usuário, cenário, etc
      
      ├── Assets/ # Armazenamento dos sprites
  
        ├── Player/ # Sprites do Jogador
                
        ├── Enemies/ # Sprites dos inimigos
                
        ├── Misc/ # Projéteis, cenário e etc.

        ├── Audio/ # Arquivos de áudio

---
## **3. Etapas de Entrega**
### **Etapa 1: Protótipo básico (mês 1-2)**
  - Menus simples;
  - Sistema de movimentação completo (todas as direções);
  - Sprites do player implementados.
### **Etapa 2: Funcionamento pleno (mês 3-4)**
  - Projéteis e sistema para o PV;
  - Hordas de inimigos (fases);
  - Sistema de pontuação;
  - Sistema de Power-Ups.
### **Etapa 3: Polimento (mês 5-6)**
  - Efeitos Sonoros;
  - Funções por comando de voz;
  - Resolução de bugs (caso ocorram);
  - Polimento dos menus.
 
## **4. Requisitos técnicos**
```
  
