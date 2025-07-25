# **Documentação do Projeto: Drako-Shooter com Pygame.**
---
## **1.Visão Geral**
**Tecnologias Utilizadas:** Python + Pygame + Vosk(com chances de mudança);
**Descrição:** Desenvolvimento de um jogo no estilo space invaders, com mecânicas simples, o jogo se passa em um ambiente devastado e com temática pós apocalíptica, ond eo jogador assume o papel de um piloto com o objetivo de vencer a tirania das máquinas que oprimem a humanidade, enfrentando inimigos e chefes poderosos até alcançar seu objetivo.
**Objetivo:** Apresentar um jogo com mecânicas simples(movimentação, inimigos, projéteis, batalhas de chefe, sistema de melhorias.) e com estética reconhecível.
## **2. Descrição Detalhada do Projeto**
- **O que é o gênero "Space Invaders"?**
  - Se trata basicamente de um gênero de jogos que consiste em uma forma de jogatina único, conhecido também popularmente como jogo de naves, pois os jogos englobados por esse gênero costumam ter como mecânica principal a batalha entre aeronaves, com mecânicas de upgrade características que geram um fator replay a mais para os jogos nesse estilo.
### **2.1 Funcionalidades Principais**
- **Motor do Jogo:**
  - Sistemas de Upgrades;
  - Movimentação em todas as direções primárias (cima, baixo, direita, esquerda);
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
> DrakoS/
├── main.py # Ponto de entrada (inicialização do jogo)
├── game.py # Lógica principal (estado do jogo, loop principal)
├── player.py # Definição da classe Player e seus atributos
├── enemy.py # Definição de classe dos inimigos 
├── projectile.py # Definição da classe dos projéteis
├── ui/ # Interface do usuário
│   ├── render.py # Renderização gráfica (Pygame)
│   └── sounds.py # Gerenciamento de áudio
└── utils/ # Utilitários
    ├── config.py # Constantes (cores, tamanhos)
    └── scores.py # Manipulação da pontuação do player
├── assets/ # Armazenamento dos sprites
              ├── Player/ # Sprites do Jogador
              ├── Enemies/ # Sprites dos inimigos
              ├── Misc/ # Projéteis, cenário e etc.
---
## **3. Etapas de Entrega**
### **Etapa 1: Protótipo básico (mês 1-2)**
  - Sistema de movimentação completo (todas as direções);
  - implementação de inimigos e sistema de PV (sem placeholder ainda);
  - Sprites do player e dos inimigos implementados como placeholder.
### **Etapa 2: Funcionamento pleno (mês 3-4)**
  - Projéteis e placeholder para o PV;
  - Hordas de inimigos (fases);
  - Sistema de pontuação;
  - Menus simples;
  - Sistema de Power-Ups.
### **Etapa 3: Polimento (mês 5-6)**
  - Efeitos Sonoros;
  - Funções por comando de voz;
  - Resolução de bugs (caso ocorram);
  - Polimento dos menus.
 
## **4. Requisitos técnicos**
```
Pygame== 2.6.0