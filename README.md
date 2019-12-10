# EncryptVsHash-NetCore

# .Cifrado y Descrifrado

Cifrado: Base64 Encoding Method.

Descifrado: Base64 Decoding Method.

# .Tipo de Algortimos HASH

NET Core incluye clases para 5 algoritmos HASH diferentes, entre ellos:

Nombre / Límite del mensaje (bits) /Tamaño del código Hash (bits)

MD5 / 2^64 / 128

SHA-1 / 2^64 / 160

SHA-256 / 2^64 / 256

SHA-384 / 2^128 / 384

SHA-512 / 2^128 / 512

Tamaño del código Hash (bits): La longitud de un código hash se mide en bits, lo que significa que un código hash de 64 bits puede representar 2^64 valores hash diferentes (18.446.744.073.709.551.616). Por ejemplo, a un ritmo de comprobación de 10 millones de mensajes por segundo, se tardaría unos 58.494 años para encontrar una coincidencia. Es computacionalmente factible, pero muy poco probable. Independientemente del tamaño o el contenido del mensaje procesado, los algoritmos hash producen siempre códigos hash de una longitud determinada, lo que significa que hay un conjunto finito de valores hash (se puede crear un número infinito de mensajes diferentes, pero sólo hay un número finito de códigos hash posibles, por lo tanto, es posible encontrar un par de mensajes que producen el mismo código hash).
MD5: Es el algoritmo hash más rápido incluido en .NET Framework y .Net Core, pero el tamaño del código hash lo hace más susceptible a los ataques por  fuerza bruta y los ataques de cumpleaños. Se detectaron defectos de diseño en MD5 y ya no se consideró seguro.
SHA-1: Un número de ataques significativos fueron divulgados sobre SHA-1, lo que ha planteado dudas y también se recomienda abandonarlo.
SHA-256, SHA-384, y SHA-512: Son variaciones de SHA-1. Aunque  SHA-256, SHA-384, y SHA-512 producen códigos hash más largos, un código hash más largo no proporciona una mayor seguridad si el algoritmo subyacente tuviera algún fallo. Dando más bits solo se incrementa el esfuerzo para encontrar colisiones pero según avancen los métodos de criptoanálisis y la potencia de los ordenadores se irán recortando los tiempos y estaremos en las mismas.

# Cifrado, Descifrado y Tipos de HASH C# .Net Core
En: https://github.com/LeonardoFranciaR/docker-glpi/wiki
