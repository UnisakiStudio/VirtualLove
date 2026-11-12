# Virtual Love

Ferramenta para avatares VRChat que permite desfrutar de poses a dois com outra pessoa, em rastreamento de 3 pontos ou no modo desktop. Inclui 22 poses para cada lado, masculino e feminino, num total de 44. Também permite fazer a espargata em pé e o desafio Jack-O.

Este README refere-se a v3.2.0 em desenvolvimento. A data oficial não está definida. A versão instalada aparece no topo do Inspector.

- [Página do produto na BOOTH](https://yunisaki.booth.pm/items/3641334)
- [Histórico de alterações](CHANGELOG.md)

## Idioma de apresentação e documentos offline

Escolha o idioma em «Language / 言語», no topo do Inspector. Uma única escolha aplica-se ao Inspector e aos menus VRChat gerados. Carregue novamente o avatar para mudar o idioma dentro do jogo.

Sem escolha explícita, é usado o idioma do computador; idiomas não suportados utilizam inglês. São suportados Windows, macOS e Linux. A última escolha é guardada em EditorPrefs e reutilizada noutros projetos do mesmo utilizador do sistema neste computador. Todas as ferramentas de poses e todos os avatares usam o mesmo idioma. Alterá-lo no Inspector de qualquer ferramenta atualiza a preferência comum; as escolhas de idioma por avatar são ignoradas. Não existe sincronização com outros computadores. O armazenamento da licença não é alterado. O botão de idioma aparece apenas na confirmação inicial da instalação quando não há um idioma guardado. As alterações posteriores são feitas no Inspector.

Pode escolher o README e o histórico de alterações na [lista de idiomas](../index.html) incluída. «Manual» e «Ver alterações», no Inspector, também seguem o idioma selecionado. Os nomes das poses incluídas e das categorias do menu no jogo são igualmente apresentados no idioma selecionado. Os termos de utilização continuam a ser fornecidos em japonês, como até agora.

## Instalação

1. Importe para o Unity «VirtualLove_Boy.unitypackage» ou «VirtualLove_Girl.unitypackage», incluídos nos ficheiros da compra. Na edição em inglês, os ficheiros chamam-se «VirtualLove_Male_Installer.unitypackage» e «VirtualLove_Female_Installer.unitypackage».
2. Depois de registar a origem dos pacotes, pode adicionar «Virtual Love» ao projeto pretendido a partir de VCC ou ALCOM. É necessário Unisaki Posing System 3.2.0.
3. Na Hierarchy, clique com o botão direito no avatar pretendido e escolha «Unisaki Studio > Adicionar Virtual Love (Masculino)» ou «Unisaki Studio > Adicionar Virtual Love (Feminino)».
4. Selecione «三点だいしゅき(男)» ou «三点だいしゅき(女)», adicionado dentro do avatar, e configure no Inspector as funções e as poses a utilizar.
5. Verifique as poses na pré-visualização e carregue o avatar como habitualmente.

Requisitos: Unity 2022.3, VRChat Avatars SDK 3.10.4 ou posterior, Modular Avatar 1.x desde 1.15.1 e NDMF 1.x desde 1.14.0. Atualize os pacotes necessários em conjunto com VCC ou ALCOM.

## Atualizar versões anteriores

Atualize produto e Unisaki Posing System juntos. Configurações existentes são mantidas. Reveja funções e ExpressionParameters; se usava pré-cálculo, atualize-o antes de enviar novamente.

## Onde configurar

| Separador | Definições principais |
| --- | --- |
| Funções | Adição de funções ao menu no jogo, Modo foto, respiração, imagens dos ícones e verificação do consumo de parâmetros |
| Poses | Poses a utilizar, pesquisa, adição, reordenação, pré-visualização e ajuste de animação |
| Configuração do avatar | Correção do corpo, importação da postura original e de movimentos próprios, predefinições |

Ative as funções necessárias antes de carregar o avatar. Os itens com «Abrir configurações» podem mostrar configurações detalhadas por baixo.

## Controlos básicos no jogo

Abra o menu Expressions e escolha uma pose de Virtual Love. Escolha as poses que formam par entre o lado masculino e o feminino e alinhe a sua posição e direção com as da outra pessoa.

Pode alternar a fixação da cabeça, dos braços e dos pés para ajustar as partes que acompanham os seus movimentos. Com Fixar pés, pode mexer a cabeça enquanto o lado dos pés mantém a pose. Se quiser espelhar uma pose ou ajustar a sua altura, ative previamente as funções correspondentes no Unity.

### Modo foto

Pode deslocar o seu avatar para um local onde o consiga ver, ajustar a direção e tirar fotografias.

1. No Unity, ative «Funções > Funções do menu > Modo foto».
2. No VRChat, abra «Modo foto» e escolha a pose pretendida em «Escolher pose».
3. Com «Distância», desloque o avatar para a frente até 3m. Com uma distância superior a 0, o avatar fica virado para si.
4. Rode-o com «Direção» e, quando a posição estiver definida, ative «Fixar pés» se necessário. Os pés não são fixados automaticamente no início, pelo que pode ajustar a posição antes de os fixar.
5. Quando terminar de fotografar, prima «Sair da foto». A distância e a direção são repostas e a fixação dos pés é desativada.

Se adicionou «Sem gestos» ao menu, também pode mudar a forma das mãos dentro do Modo foto.

Se alterar a posição e a direção apenas no seu ecrã, os parâmetros sincronizados do Modo foto não são utilizados. Para mostrar a mesma posição e direção às outras pessoas, ative «Funções > Funções práticas > Sincronizar Modo foto» no Unity.

Se a sua cabeça ficar oculta ao aproximar-se e dificultar as fotografias, ative «Manter cabeça visível no Modo foto». Aplica-se ao seu ecrã durante as fotografias e, ao terminar, regressa a apresentação normal.

### Altura pés e Altura chão

Ao ativar os itens pretendidos em «Funções > Funções do menu» no Unity, estes são adicionados ao menu «Definições» do VRChat.

- **Altura pés**: ajusta a altura do lado dos pés, mantendo a posição da cabeça. Utilize quando os pés se afundam no chão ou ficam a flutuar, ou para acertar a altura com a da outra pessoa.
- **Altura chão**: desloca todo o corpo, incluindo a cabeça, para cima e para baixo. 50% é a altura original, 0% corresponde a 3m abaixo e 100% a 3m acima. Para repor a altura original, volte a um valor próximo de 50%.

Em combinação com o Modo foto, pode ajustar a altura, a distância e a direção do avatar. O movimento e a rotação do Modo foto e a Altura chão também corrigem os movimentos padrão e personalizados utilizados quando nenhuma pose está selecionada. Verifique no próprio VRChat o ponto de vista e o comportamento após a substituição dos movimentos padrão.

### Espelhar e Sem gestos

- **Espelhar**: ative «Funções > Funções do menu > Espelhar» e, no menu do VRChat, troque a esquerda e a direita da pose.
- **Sem gestos**: ative «Funções > Funções do menu > Sem gestos». Quando ativado no VRChat, a forma dos dedos definida na pose mantém-se mesmo ao apertar os comandos.

### Respiração

1. Ative «Funções > Funções práticas > Animar respiração».
2. Em «Abrir configurações», escolha entre «Nenhum», «Fraco», «Médio», «Forte», «Rápido» e «Personalizado» para cada categoria de postura. Ajuste a intensidade na categoria correspondente às poses de Virtual Love. Em «Personalizado», pode indicar uma animação de respiração preparada por si.
3. Se também quiser parar e retomar a respiração dentro do jogo, ative igualmente «Funções > Funções do menu > Respiração». No VRChat, «Respiração» alterna entre ON/OFF.

Ao ativar «Desativar balanço em repouso do VRChat», reduz o balanço padrão do corpo que é adicionado automaticamente em repouso. A respiração definida na ferramenta de poses continua a funcionar normalmente.

### Reduzir a deformação da pose causada pela rotação da cabeça

Ative «Funções > Funções práticas > Reduzir deformação por rotação da cabeça». Utilize quando, ao desativar Fixar cabeça, a postura do corpo se deforma porque a orientação do pescoço difere da pose original.

### Virar

Virar é uma função que se utiliza preparando uma pose deitada compatível e as respetivas animações de lado.

1. Ative «Funções > Funções do menu > Virar».
2. Em «Poses», abra «Detalhes» da pose pretendida e ative «Ativar Virar».
3. Indique as animações correspondentes em «Pose lateral para virar» e, se necessário, ajuste «Intensidade da correção do chão».
4. No VRChat, escolha a pose correspondente, desative Fixar cabeça e ative «Virar». Ao inclinar a cabeça para a esquerda ou para a direita, o avatar vira-se.

Nas poses que utilizam Virar, a configuração normal de MotionTime não pode ser usada. As poses incluídas em Virtual Love não trazem animações laterais para Virar; se quiser utilizar a função, prepare os movimentos correspondentes.

## Consumo de parâmetros

Desativar as funções desnecessárias reduz o consumo de ExpressionParameters.

| Função | Consumo adicional |
| --- | --- |
| Espelhar | 1 bit |
| Sem gestos | 1 bit |
| Altura pés | 8 bit |
| Altura chão | 8 bit |
| Movimento de respiração | 0 bit |
| ON/OFF da respiração no jogo | 1 bit |
| Modo foto (apenas no seu ecrã) | 0 bit |
| Sincronização do Modo foto | 16 bit |
| Cabeça visível durante as fotografias | 0 bit |
| Redução da deformação por rotação da cabeça | 1 bit (partilhado com Virar) |
| Virar | 10 bit (dos quais 1 bit partilhado com a redução da deformação) |

A estes valores soma-se o consumo da seleção de poses, entre outros. Verifique o total no Inspector. Quando várias ferramentas de poses utilizam as funções comuns, a parte partilhada não é contada em duplicado. O consumo de outros sistemas, como roupas, não está incluído neste total.

## Verificar e ajustar as poses

Com «Pré-visualização», disponível em cada pose de «Poses», pode mostrar a postura na Scene. Ao abrir «Ajuste de animação», pode ajustar a orientação do corpo e as articulações durante a pré-visualização e guardar o resultado.

As poses incluídas foram criadas tendo como referência «あのん（Anon）», de こよりLab. Ajuste, por exemplo, os pontos de contacto com a outra pessoa de acordo com a constituição física e a roupa.

Com «Ativar correção específica do avatar», em «Configuração do avatar», pode corrigir as diferenças nos ângulos iniciais das articulações e na torção em relação ao avatar de referência. «Impedir flexão inversa dos joelhos» reduz a flexão dos joelhos no sentido inverso. Ao abrir as configurações detalhadas, pode ajustar «Flexão mínima do joelho (graus)». Verifique também na pré-visualização o aspeto com as correções ativadas.

A pesquisa por nome de pose, a adição de várias animações e a alteração da ordem também são feitas em «Poses». Desative ou elimine as poses desnecessárias.

A pré-visualização rápida não executa a compilação de MA e NDMF; por isso, verifique também o estado final, incluindo roupas e outros sistemas, depois de compilar o avatar.

### Imagens dos ícones das poses

Ao ativar «Gerar ícones das poses», em «Funções», pode adicionar imagens das poses ao menu no jogo. A compilação demora mais tempo devido à geração das imagens. Para reduzir o tamanho, ative «Reduzir tamanho dos ícones». Para Android, os ícones das poses não são gerados.

### Predefinições

Pode escolher uma predefinição no fundo de «Configuração do avatar». «Aplicar esta predefinição» substitui as configurações atuais das poses; por isso, guarde os ajustes já feitos antes de mudar.

Os ficheiros de animação de ajuste criados com a função Ajuste de animação, bem como as predefinições que os utilizam, podem ser distribuídos e vendidos sem autorização individual de Unisaki Studio. Utilize-os, por exemplo, para partilhar dados de ajuste para avatares criados por si.

## Pré-cálculo

Ao guardar com «Atualizar pré-cálculo» os menus e as animações gerados, estes são reutilizados na compilação do avatar, o que torna o processo mais rápido. Mesmo sem pré-cálculo, os dados necessários são gerados durante a compilação normal.

Depois de alterar poses ou funções, consulte «Verificar configurações» no Inspector e, se utilizar o pré-cálculo, atualize-o. Ocultar um aviso não atualiza o resultado gerado.

## Oferecer como presente

Se não for utilizar pessoalmente, pode oferecer a versão masculina ou a feminina ao seu par. Quem recebe a oferta só a pode utilizar com a pessoa que a ofereceu.

## Notas de utilização

- Este produto foi criado com fins humorísticos. Não o utilize para atos de assédio.
- Utilize-o respeitando os termos de utilização e as regras de boa convivência do VRChat.
- A fixação da postura durante o rastreamento de corpo inteiro não é suportada.
- Consoante a constituição física, a roupa e as modificações do avatar, pode ser necessário um ajuste manual.
- Se utilizar em conjunto outros sistemas que alteram a postura, verifique o funcionamento das fixações e da mudança de pose. Em alguns casos, é possível ajustá-lo em «Configuração do avatar > Integrar bloqueios de rastreamento com outras ferramentas».
- O criador não se responsabiliza por quaisquer prejuízos resultantes da utilização desta ferramenta.

## Termos de utilização

Utilize este produto apenas depois de aceitar os termos de utilização, elaborados com a licença VN3.

[Termos de utilização de Virtual Love](https://drive.google.com/file/d/1Uu8y4z-G-P0btDCdY-ahQsTJInCNbxyD/view?usp=sharing)
