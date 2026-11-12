# Virtual Love

Herramienta para avatares de VRChat que permite adoptar poses en pareja con otra persona, con seguimiento de 3 puntos o en escritorio. Incluye 22 poses para el hombre y 22 para la mujer, 44 en total. También permite hacer el espagat de pie y el reto Jack-O.

Este README corresponde a v3.2.0 en desarrollo. La fecha oficial no está fijada. La versión instalada aparece arriba del Inspector.

- [Página del producto en BOOTH](https://yunisaki.booth.pm/items/3641334)
- [Historial de cambios](CHANGELOG.md)

## Idioma de la interfaz y documentación sin conexión

Elige el idioma en «Language / 言語», arriba del Inspector. Una sola selección controla el Inspector y los menús VRChat generados. Vuelve a subir el avatar para cambiar el idioma dentro del juego.

Sin una selección explícita se usa el idioma del ordenador; si no está disponible, se utiliza inglés. Se admiten Windows, macOS y Linux. La última elección se guarda en EditorPrefs y se reutiliza en otros proyectos del mismo usuario del sistema en este ordenador. Todas las herramientas de poses y los avatares usan el mismo idioma. Cambiarlo en el Inspector de cualquier herramienta actualiza la preferencia común; se ignoran las elecciones de idioma de cada avatar. No se sincroniza con otros ordenadores. El almacenamiento de las licencias no cambia. El botón de idioma solo aparece en la confirmación inicial de instalación cuando no hay un idioma guardado. Los cambios posteriores se realizan en el Inspector.

Elige el idioma del README y del historial de cambios en la [lista de idiomas](../index.html) incluida. Los enlaces del Inspector al manual y los cambios también siguen esa selección. Los nombres de las poses incluidas y de las categorías del menú del juego se muestran igualmente en el idioma elegido. Las condiciones de uso siguen incluidas en japonés, como hasta ahora.

## Instalación

1. Importa en Unity «VirtualLove_Boy.unitypackage» o «VirtualLove_Girl.unitypackage», incluido en los archivos de tu compra.
2. Una vez registrado el repositorio de paquetes, puedes añadir Virtual Love a tu proyecto desde VCC o ALCOM. Se requiere Unisaki Posing System 3.2.0.
3. Haz clic derecho en el avatar de Hierarchy y elige «Unisaki Studio > Añadir Virtual Love (Hombre)» o «Unisaki Studio > Añadir Virtual Love (Mujer)».
4. Selecciona «三点だいしゅき(男)» o «三点だいしゅき(女)», añadido dentro del avatar, y configura funciones y poses en Inspector.
5. Comprueba las poses con la vista previa y sube el avatar normalmente.

Requisitos: Unity 2022.3, VRChat Avatars SDK 3.10.4 o posterior, Modular Avatar 1.x desde 1.15.1 y NDMF 1.x desde 1.14.0. Actualiza los paquetes necesarios juntos con VCC o ALCOM.

## Actualizar desde versiones anteriores

Actualiza este producto y Unisaki Posing System juntos. La configuración existente se conserva. Revisa funciones y ExpressionParameters en Inspector; si usabas precálculo, pulsa «Actualizar precálculo» antes de volver a subir.

## Dónde se configura

| Pestaña | Ajustes principales |
| --- | --- |
| Funciones | Menús del juego, Modo foto, respiración, iconos y comprobación del consumo de parámetros |
| Poses | Poses en uso, búsqueda, adición, orden, vista previa y ajuste de animación |
| Configuración del avatar | Correcciones del cuerpo, poses originales o movimientos propios y preajustes |

Activa las funciones que necesites antes de subir el avatar. Los elementos con «Abrir ajustes» pueden mostrar debajo sus ajustes detallados.

## Controles básicos dentro del juego

Abre el menú Expressions y elige una pose de Virtual Love. Elige las poses que forman pareja entre hombre y mujer y alinea tu posición y dirección con las de tu pareja.

Activa o desactiva la fijación de cabeza, brazos y pies para decidir qué partes siguen tus movimientos. Con «Fijar pies» puedes mover la cabeza mientras la parte inferior del cuerpo mantiene la pose. Para reflejar una pose o ajustar su altura, activa antes en Unity las funciones correspondientes.

### Modo foto

Puedes mover tu avatar a un lugar donde lo veas, ajustar su dirección y hacer fotos.

1. En Unity, activa «Funciones > Funciones del menú > Modo foto».
2. En VRChat abre «Modo foto» y escoge la pose que quieras en «Elegir pose».
3. «Distancia» mueve el avatar hasta 3m hacia delante. Con distancia mayor que 0, el avatar mira hacia ti.
4. Gíralo con «Dirección» y, cuando esté en su sitio, activa «Fijar pies» si lo necesitas. Los pies no se fijan automáticamente al empezar, para que puedas ajustar primero la posición.
5. Al terminar las fotos, pulsa «Salir de foto». Se restablecen distancia y dirección y se liberan los pies.

Si añadiste «Sin gestos» al menú, también puedes cambiar la forma de las manos dentro del Modo foto.

Si solo cambias la posición y la dirección en tu propia vista, el Modo foto no usa parámetros sincronizados. Para mostrar la misma posición y dirección a otras personas, activa en Unity «Funciones > Funciones prácticas > Sincronizar el Modo foto».

Si tu propia cabeza desaparece al acercarse y dificulta las fotos, activa «Mantener la cabeza visible en Modo foto». Se aplica a tu propia vista durante las fotos y recupera la visualización normal al salir.

### Altura pies y Altura suelo

Activa en Unity los elementos que quieras en «Funciones > Funciones del menú» para añadirlos al menú «Ajustes» de VRChat.

- **Altura pies**: ajusta la altura del lado de los pies conservando la posición de la cabeza. Úsala cuando los pies se hundan en el suelo o floten, o para igualar la altura con tu pareja.
- **Altura suelo**: mueve verticalmente todo el cuerpo, cabeza incluida. 50% es la altura original, 0% son 3m por debajo y 100% son 3m por encima. Para volver a la altura original, devuelve el valor a cerca de 50%.

Combínalas con el Modo foto para ajustar la altura, la distancia y la dirección del avatar. El movimiento y giro del Modo foto y «Altura suelo» también corrigen los movimientos estándar o propios que se usan cuando no hay ninguna pose seleccionada. Comprueba en el propio VRChat el punto de vista y el comportamiento tras sustituir los movimientos estándar.

### Reflejar y Sin gestos

- **Reflejar**: activa «Funciones > Funciones del menú > Reflejar» y cambia la pose entre izquierda y derecha desde el menú de VRChat.
- **Sin gestos**: activa «Funciones > Funciones del menú > Sin gestos». Al activarlo en VRChat, la forma de los dedos definida en la pose se mantiene aunque aprietes los mandos.

### Respiración

1. Activa «Funciones > Funciones prácticas > Animar la respiración».
2. En «Abrir ajustes», elige «Ninguno», «Bajo», «Medio», «Alto», «Rápido» o «Personalizado» para cada categoría de poses. Ajusta la intensidad en la categoría que corresponda a las poses de Virtual Love. «Personalizado» permite asignar una animación de respiración propia.
3. Para detener y reanudar la respiración también dentro del juego, activa además «Funciones > Funciones del menú > Respiración». En VRChat, «Respiración» la cambia entre ON/OFF.

Activa «Desactivar el balanceo en reposo de VRChat» para reducir el balanceo estándar del cuerpo que se añade automáticamente en reposo. La respiración configurada en la herramienta de poses sigue funcionando.

### Reducir deformaciones por la rotación de cabeza

Activa «Funciones > Funciones prácticas > Reducir deformaciones por la rotación de cabeza». Úsalo cuando, al desactivar «Fijar cabeza», el cuerpo se deforma porque la orientación de la cabeza difiere de la de la pose original.

### Darse vuelta

Darse vuelta es una función que requiere preparar una pose tumbada compatible y animaciones laterales.

1. Activa «Funciones > Funciones del menú > Darse vuelta».
2. En «Poses», abre los «Detalles» de la pose que quieras y activa «Activar Darse vuelta».
3. Asigna las animaciones correspondientes a «Pose lateral para darse vuelta» y ajusta la «Intensidad de corrección del suelo» cuando sea necesario.
4. En VRChat elige la pose compatible, desactiva «Fijar cabeza» y activa «Darse vuelta». Inclina la cabeza a izquierda o derecha para girar.

Las poses que usan Darse vuelta no pueden usar el MotionTime normal. Las poses incluidas en Virtual Love no traen animaciones laterales para darse vuelta, así que prepara movimientos adecuados si quieres usar la función.

## Consumo de parámetros

Desactivar las funciones que no necesites reduce el consumo de ExpressionParameters.

| Función | Consumo adicional |
| --- | --- |
| Reflejar | 1 bit |
| Sin gestos | 1 bit |
| Altura pies | 8 bit |
| Altura suelo | 8 bit |
| Animación de la respiración | 0 bit |
| Respiración (ON/OFF en el juego) | 1 bit |
| Modo foto (solo en tu vista) | 0 bit |
| Sincronización del Modo foto | 16 bit |
| Cabeza visible durante las fotos | 0 bit |
| Reducción de deformaciones por la rotación de cabeza | 1 bit (compartido con Darse vuelta) |
| Darse vuelta | 10 bit (1 bit compartido con la reducción de deformaciones) |

A esto se suma el consumo de la selección de poses y otros elementos. Comprueba el total en Inspector. Si varias herramientas de poses usan las funciones comunes, la parte compartida no se cuenta dos veces. El consumo de otros sistemas, como la ropa, no se incluye en este total.

## Comprobar y ajustar las poses

«Vista previa» de cada pose en «Poses» muestra la postura en Scene. Abre «Ajuste de animación» para ajustar la orientación del cuerpo y las articulaciones mientras ves el resultado, y guarda.

Las poses incluidas se crearon tomando como referencia «あのん（Anon）» de こよりLab. Ajusta los puntos de contacto con tu pareja y otros detalles según la complexión y la ropa.

En «Configuración del avatar», «Activar la corrección del avatar» corrige las diferencias de ángulos iniciales de las articulaciones y de torsión respecto al avatar de referencia. «Evitar la flexión inversa de rodillas» limita que las rodillas se doblen al revés. Abre los ajustes detallados para regular «Flexión mínima de rodilla (grados)». Comprueba también en la vista previa el aspecto con las correcciones activadas.

La búsqueda por nombre, la adición de varias animaciones y el cambio de orden también se hacen en «Poses». Desactiva o elimina las poses que no necesites.

La vista previa sencilla no ejecuta la compilación de MA ni NDMF, así que comprueba también el resultado final, con ropa y otros sistemas, después de compilar el avatar.

### Iconos de las poses

Activa «Generar iconos de poses» en «Funciones» para añadir imágenes de las poses al menú del juego. La generación de imágenes alarga la compilación. Para ahorrar espacio, activa «Reducir el tamaño de los iconos». Para Android no se generan iconos de poses.

### Preajustes

Puedes elegir un preajuste al final de «Configuración del avatar». «Aplicar este preajuste» reemplaza la configuración actual de las poses; guarda tus retoques antes de cambiar.

Los archivos de animación de ajuste creados con la función de ajuste de animación, y los preajustes configurados con ellos, pueden distribuirse y venderse sin permiso individual de Unisaki Studio. Úsalos, por ejemplo, para compartir datos de ajuste para tus propios avatares.

## Precálculo

«Actualizar precálculo» guarda los menús y animaciones generados para reutilizarlos y acelerar la compilación del avatar. Sin precálculo, la compilación normal genera los datos necesarios.

Después de cambiar poses o funciones, revisa «Comprobar configuración» en Inspector y, si usas precálculo, actualízalo. Ocultar una advertencia no actualiza los datos generados.

## Regalos

Si no lo vas a usar personalmente, puedes regalar a tu pareja una de las dos ediciones, Hombre o Mujer. Quien lo reciba solo puede usarlo con la persona que se lo regaló.

## Notas de uso

- Este producto se creó como artículo de broma. No lo uses para acosar a nadie.
- Úsalo respetando las condiciones de servicio y las normas de convivencia de VRChat.
- No se admite la fijación de poses durante el seguimiento de cuerpo completo.
- Según la complexión, la ropa y las modificaciones del avatar, puede hacer falta un ajuste manual.
- Si lo combinas con otros sistemas que cambian la postura, comprueba cómo funcionan las fijaciones y el cambio de pose. «Configuración del avatar > Integrar bloqueos de seguimiento con otras herramientas» puede ayudar a ajustarlo.
- El autor no se hace responsable de los perjuicios derivados del uso de esta herramienta.

## Condiciones de uso

Usa este producto solo después de aceptar sus condiciones de uso, elaboradas con la licencia VN3.

[Condiciones de uso de Virtual Love](https://drive.google.com/file/d/1Uu8y4z-G-P0btDCdY-ahQsTJInCNbxyD/view?usp=sharing)
