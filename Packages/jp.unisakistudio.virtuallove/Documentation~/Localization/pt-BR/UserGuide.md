# Virtual Love

Ferramenta para avatares VRChat que permite curtir poses em dupla com outra pessoa, com rastreamento de 3 pontos ou no modo desktop. Inclui 22 poses para cada lado, masculino e feminino, totalizando 44. Também dá para fazer o espacate em pé e o desafio Jack-O.

Este README refere-se a v3.2.0 em desenvolvimento. A data oficial não está definida. A versão instalada aparece no topo do Inspector.

- [Página do produto na BOOTH](https://yunisaki.booth.pm/items/3641334)
- [Histórico de alterações](CHANGELOG.md)

## Idioma de apresentação e documentos offline

Escolha o idioma em «Language / 言語», no topo do Inspector. Uma única escolha aplica-se ao Inspector e aos menus VRChat gerados. Envie novamente o avatar para mudar o idioma dentro do jogo.

Sem escolha explícita, é usado o idioma do computador; idiomas não suportados utilizam inglês. São suportados Windows, macOS e Linux. A última escolha é salva em EditorPrefs e reutilizada em outros projetos do mesmo usuário do sistema neste computador. Todas as ferramentas de poses e todos os avatares usam o mesmo idioma. Alterá-lo no Inspector de qualquer ferramenta atualiza a preferência compartilhada; as escolhas de idioma por avatar são ignoradas. Não existe sincronização com outros computadores. O armazenamento da licença não é alterado. O botão de idioma aparece apenas na confirmação inicial da instalação quando não há um idioma salvo. As alterações posteriores são feitas no Inspector.

Você pode escolher o README e o histórico de alterações na [lista de idiomas](../index.html) incluída. «Manual» e «Ver alterações», no Inspector, também seguem o idioma selecionado. Os nomes das poses incluídas e das categorias do menu no jogo também são exibidos no idioma selecionado. Os termos de uso continuam sendo fornecidos em japonês, como antes.

## Instalação

1. Importe para o Unity «VirtualLove_Boy.unitypackage» ou «VirtualLove_Girl.unitypackage», incluídos nos arquivos da compra.
2. Depois de registrar a origem dos pacotes, você pode adicionar «Virtual Love» ao projeto desejado pelo VCC ou pelo ALCOM. É necessário Unisaki Posing System 3.2.0.
3. Na Hierarchy, clique com o botão direito no avatar desejado e escolha «Unisaki Studio > Adicionar Virtual Love (Masculino)» ou «Unisaki Studio > Adicionar Virtual Love (Feminino)».
4. Selecione «三点だいしゅき(男)» ou «三点だいしゅき(女)», adicionado dentro do avatar, e configure no Inspector as funções e as poses que vai usar.
5. Confira as poses na prévia e envie o avatar como de costume.

Requisitos: Unity 2022.3, VRChat Avatars SDK 3.10.4 ou posterior, Modular Avatar 1.x desde 1.15.1 e NDMF 1.x desde 1.14.0. Atualize os pacotes necessários em conjunto com VCC ou ALCOM.

## Atualizar versões anteriores

Atualize produto e Unisaki Posing System juntos. Configurações existentes são mantidas. Reveja funções e ExpressionParameters; se usava pré-cálculo, atualize-o antes de enviar novamente.

## Onde configurar

| Aba | Principais configurações |
| --- | --- |
| Funções | Adição de funções ao menu no jogo, Modo foto, respiração, imagens dos ícones e verificação do consumo de parâmetros |
| Poses | Poses a usar, busca, adição, reordenação, prévia e ajuste de animação |
| Configuração do avatar | Correção do corpo, importação da postura original e de movimentos próprios, predefinições |

Ative as funções necessárias antes de enviar o avatar. Os itens com «Abrir configurações» podem exibir configurações detalhadas logo abaixo.

## Controles básicos no jogo

Abra o menu Expressions e escolha uma pose de Virtual Love. Escolha as poses que formam par entre o lado masculino e o feminino e alinhe sua posição e direção com as da outra pessoa.

Você pode alternar a fixação da cabeça, dos braços e dos pés para ajustar as partes que acompanham seus movimentos. Com Fixar pés, dá para mexer a cabeça enquanto o lado dos pés mantém a pose. Se quiser espelhar uma pose ou ajustar a altura dela, ative antes as funções correspondentes no Unity.

### Modo foto

Você pode mover seu avatar para um lugar onde consiga vê-lo, ajustar a direção e tirar fotos.

1. No Unity, ative «Funções > Funções do menu > Modo foto».
2. No VRChat, abra «Modo foto» e escolha a pose desejada em «Escolher pose».
3. Com «Distância», mova o avatar para a frente em até 3m. Com uma distância maior que 0, o avatar fica voltado para você.
4. Gire-o com «Direção» e, quando a posição estiver definida, ative «Fixar pés» se necessário. Os pés não são fixados automaticamente no início, então você pode ajustar a posição antes de fixá-los.
5. Quando terminar de fotografar, pressione «Sair da foto». A distância e a direção são restauradas e a fixação dos pés é desativada.

Se você adicionou «Sem gestos» ao menu, também pode mudar o formato das mãos dentro do Modo foto.

Se você alterar a posição e a direção apenas na sua tela, os parâmetros sincronizados do Modo foto não são usados. Para mostrar a mesma posição e direção às outras pessoas, ative «Funções > Funções práticas > Sincronizar Modo foto» no Unity.

Se a sua cabeça ficar oculta ao se aproximar e atrapalhar as fotos, ative «Manter cabeça visível no Modo foto». A opção vale para a sua tela durante as fotos e, ao terminar, a exibição volta ao normal.

### Altura pés e Altura chão

Ao ativar os itens desejados em «Funções > Funções do menu» no Unity, eles são adicionados ao menu «Configurações» do VRChat.

- **Altura pés**: ajusta a altura do lado dos pés, mantendo a posição da cabeça. Use quando os pés afundam no chão ou ficam flutuando, ou para igualar a altura com a da outra pessoa.
- **Altura chão**: move o corpo inteiro, incluindo a cabeça, para cima e para baixo. 50% é a altura original, 0% corresponde a 3m abaixo e 100% a 3m acima. Para voltar à altura original, retorne a um valor próximo de 50%.

Em combinação com o Modo foto, você pode ajustar a altura, a distância e a direção do avatar. O movimento e a rotação do Modo foto e a Altura chão também corrigem os movimentos padrão e personalizados usados quando nenhuma pose está selecionada. Confira no próprio VRChat o ponto de vista e o comportamento após a substituição dos movimentos padrão.

### Espelhar e Sem gestos

- **Espelhar**: ative «Funções > Funções do menu > Espelhar» e, no menu do VRChat, troque a esquerda e a direita da pose.
- **Sem gestos**: ative «Funções > Funções do menu > Sem gestos». Quando ativado no VRChat, o formato dos dedos definido na pose é mantido mesmo ao apertar os controles.

### Respiração

1. Ative «Funções > Funções práticas > Animar respiração».
2. Em «Abrir configurações», escolha entre «Nenhum», «Fraco», «Médio», «Forte», «Rápido» e «Personalizado» para cada categoria de postura. Ajuste a intensidade na categoria correspondente às poses de Virtual Love. Em «Personalizado», você pode indicar uma animação de respiração preparada por você.
3. Se também quiser parar e retomar a respiração dentro do jogo, ative também «Funções > Funções do menu > Respiração». No VRChat, «Respiração» alterna entre ON/OFF.

Ao ativar «Desativar balanço em repouso do VRChat», você reduz o balanço padrão do corpo que é adicionado automaticamente em repouso. A respiração definida na ferramenta de poses continua funcionando normalmente.

### Reduzir a deformação da pose causada pela rotação da cabeça

Ative «Funções > Funções práticas > Reduzir deformação por rotação da cabeça». Use quando, ao desativar Fixar cabeça, a postura do corpo se deforma porque a orientação do pescoço é diferente da pose original.

### Virar

Virar é uma função usada com uma pose deitada compatível e as respectivas animações de lado, que você precisa preparar.

1. Ative «Funções > Funções do menu > Virar».
2. Em «Poses», abra «Detalhes» da pose desejada e ative «Ativar Virar».
3. Indique as animações correspondentes em «Pose lateral para virar» e, se necessário, ajuste «Intensidade da correção do chão».
4. No VRChat, escolha a pose correspondente, desative Fixar cabeça e ative «Virar». Ao inclinar a cabeça para a esquerda ou para a direita, o avatar se vira.

Nas poses que usam Virar, a configuração normal de MotionTime não pode ser usada. As poses incluídas em Virtual Love não trazem animações laterais para Virar; se quiser usar a função, prepare os movimentos correspondentes.

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
| Modo foto (apenas na sua tela) | 0 bit |
| Sincronização do Modo foto | 16 bit |
| Cabeça visível durante as fotos | 0 bit |
| Redução da deformação por rotação da cabeça | 1 bit (compartilhado com Virar) |
| Virar | 10 bit (dos quais 1 bit compartilhado com a redução da deformação) |

A esses valores soma-se o consumo da seleção de poses, entre outros. Confira o total no Inspector. Quando várias ferramentas de poses usam as funções comuns, a parte compartilhada não é contada em duplicidade. O consumo de outros sistemas, como roupas, não está incluído nesse total.

## Conferir e ajustar as poses

Com «Prévia», disponível em cada pose de «Poses», você pode exibir a postura na Scene. Ao abrir «Ajuste de animação», é possível ajustar a orientação do corpo e as articulações durante a prévia e salvar o resultado.

As poses incluídas foram criadas tendo como referência «あのん（Anon）», de こよりLab. Ajuste, por exemplo, os pontos de contato com a outra pessoa de acordo com o tipo físico e a roupa.

Com «Ativar correção específica do avatar», em «Configuração do avatar», você pode corrigir as diferenças nos ângulos iniciais das articulações e na torção em relação ao avatar de referência. «Impedir flexão inversa dos joelhos» reduz a flexão dos joelhos no sentido inverso. Ao abrir as configurações detalhadas, você pode ajustar «Flexão mínima do joelho (graus)». Confira também na prévia a aparência com as correções ativadas.

A busca por nome de pose, a adição de várias animações e a alteração da ordem também são feitas em «Poses». Desative ou exclua as poses desnecessárias.

A prévia rápida não executa a compilação de MA e NDMF; por isso, confira também o estado final, incluindo roupas e outros sistemas, depois de compilar o avatar.

### Imagens dos ícones das poses

Ao ativar «Gerar ícones das poses», em «Funções», você pode adicionar imagens das poses ao menu no jogo. A compilação leva mais tempo por causa da geração das imagens. Para reduzir o tamanho, ative «Reduzir tamanho dos ícones». Para Android, os ícones das poses não são gerados.

### Predefinições

Você pode escolher uma predefinição na parte inferior de «Configuração do avatar». «Aplicar esta predefinição» substitui as configurações atuais das poses; por isso, salve os ajustes já feitos antes de trocar.

Os arquivos de animação de ajuste criados com a função Ajuste de animação, assim como as predefinições que os utilizam, podem ser distribuídos e vendidos sem autorização individual de Unisaki Studio. Use-os, por exemplo, para compartilhar dados de ajuste para avatares criados por você.

## Pré-cálculo

Ao salvar com «Atualizar pré-cálculo» os menus e as animações gerados, eles são reaproveitados na compilação do avatar, o que deixa o processo mais rápido. Mesmo sem pré-cálculo, os dados necessários são gerados durante a compilação normal.

Depois de alterar poses ou funções, consulte «Verificar configurações» no Inspector e, se você usa o pré-cálculo, atualize-o. Ocultar um aviso não atualiza o resultado gerado.

## Dar de presente

Se você não for usar pessoalmente, pode dar de presente a versão masculina ou a feminina ao seu par. Quem recebe o presente só pode usá-lo com a pessoa que o presenteou.

## Notas de utilização

- Este produto foi criado como uma brincadeira. Não o use para atos de assédio.
- Use-o respeitando os termos de uso e as regras de boa convivência do VRChat.
- A fixação da postura durante o rastreamento de corpo inteiro não é compatível.
- Dependendo do tipo físico, da roupa e das modificações do avatar, pode ser necessário um ajuste manual.
- Se você usar em conjunto outros sistemas que alteram a postura, confira o funcionamento das fixações e da troca de pose. Em alguns casos, é possível ajustá-lo em «Configuração do avatar > Integrar bloqueios de rastreamento com outras ferramentas».
- O criador não se responsabiliza por quaisquer prejuízos decorrentes do uso desta ferramenta.

## Termos de uso

Use este produto somente depois de aceitar os termos de uso, elaborados com a licença VN3.

[Termos de uso de Virtual Love](https://drive.google.com/file/d/1Uu8y4z-G-P0btDCdY-ahQsTJInCNbxyD/view?usp=sharing)
