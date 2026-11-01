# Datos de integrantes

Elvin Mota Cueto #14

Frander Furcal Padilla #8

# Descripción del proyecto

El proyecto trata de un sistema que permite la realización de usuarios para un centro educativo y la 
verificación de la clave de los usuarios, evaluando los carácteres y verificando que la clave no
contenga el usuario en esta.

para luego mostrar el nombre del usuario creado y la verificación de la clave con False/True

# Entrada:

-Nombre del estudiante

-el apellido del estudiante

-clave

# Proceso

El programa hace lo siguiente:

1.Recibe los datos introducidos por el usuario/estudiante

3.Obtiene el usuario formado mediante la funcion GenerarUsuario()

4. verifica la clave mediante la funcion ClaveValida()

5. y através de el procedimkiento MostrarCuenta() da la salida
   de los resultados de las funciones GenerarUsuario() y ClaveValida()

# Salida

muestra:

-El usuario formado

-el resultado de la validación de la clave

# Tecnologías utilizadas

-Lenguaje c#

-uso de git para controlar las versiones (aprendiendo)

-Plataforma para guardar el code GitHub (igual que en el ejercicio.1)

# Capturas de pantalla del programa ejecutado

Escenario 1: <img width="959" height="503" alt="Captura de pantalla 2026-10-31 211652" src="https://github.com/user-attachments/assets/c7868222-5264-490c-9cbf-7ca11109caf7" />

-estudiante: elmas

-apellido: capo

-clave: wowowowo

-la clave cumple con tener 8 o más caracteres y la aucencia de el usuario en esta, asi que muestra True



Escenario 2: <img width="959" height="504" alt="Captura de pantalla 2026-10-31 211803" src="https://github.com/user-attachments/assets/60ca51f2-7997-43af-8350-480815fb1525" />


-estudiante: ana

-apellido: belle

-clave: abelle12345

-la clave cumple con los 8 caracteres, pero contiene "abelle" en su clave y por esa razón incumple la aucencia de el usuario en la clave, asi que muestra False. 
