# ANEXO A10-CRIPTOGRAFÍA // EncryptVsHash-NetCore

# .Cifrado y Descrifrado

Cifrado: Base64 Encoding Method.

Descifrado: Base64 Decoding Method.

# .Tipo de Algortimos HASH

En .NET Core 2.1 - Incluye clases para 5 algoritmos HASH diferentes, entre ellos:

Nombre / Límite del mensaje (bits) /Tamaño del código Hash (bits)

MD5 / 2^64 / 128

SHA-1 / 2^64 / 160

SHA-256 / 2^64 / 256

SHA-384 / 2^128 / 384

SHA-512 / 2^128 / 512

Información:
* Los hash son algoritmos que reciben un input de entrada (texto, contraseña u otros) y resuelven una salida alfanumérica de longitud normalmente fija que es la representación del input de entrada, es decir, los valores de genera una cadena que solo puede volverse a crear con esos mismos valores.

* MD5: Es el algoritmo hash más rápido, pero el tamaño del código hash lo hace más susceptible a los ataques por  fuerza bruta. Considerado como NO seguro.

* SHA-1: Genera un 160 bits (20 bytes) hash a partir de cualquier valor de entrada. Considerado como NO seguro. (Ref. https://www.sha1-generator.info/es/cual-es-sha1-hash)

* SHA-256, SHA-384, y SHA-512: Son variaciones de SHA-1. Aunque  SHA-256, SHA-384, y SHA-512 producen códigos hash más largos, un código hash más largo no proporciona una mayor seguridad si el algoritmo subyacente tuviera algún fallo. Dando más bits solo se incrementa el esfuerzo para encontrar colisiones pero según avancen los métodos de criptoanálisis y la potencia de los ordenadores se irán recortando los tiempos y estaremos en las mismas. (Ref. http://www.iwar.org.uk/comsec/resources/cipher/sha256-384-512.pdf)

# Cifrado, Descifrado y Tipos de HASH C# .Net Core
En: https://github.com/LeonardoFranciaR/Encrypt-vs-Hash-NetCore-API/wiki/Encrypt-vs-Hash-.NetCore-API
