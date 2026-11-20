\# 🎲 Generala - Juego de mesa



Aplicación de escritorio que permite jugar a la Generala entre dos jugadores, gestionar partidas y consultar estadísticas de rendimiento.



Desarrollada en C# con Windows Forms como Trabajo Práctico Integrador de la carrera Licenciatura en Gestión de Tecnologías Informáticas (UAI).



\## ✨ Funcionalidades



\- \*\*Gestión de usuarios:\*\* registro e inicio de sesión.

\- \*\*Partidas para dos jugadores:\*\* posibilidad de jugar contra otro usuario.

\- \*\*Mecánica del juego:\*\* lanzamiento de dados, selección de dados a conservar y cálculo automático de puntajes.

\- \*\*Reglas de la Generala:\*\* implementación de las distintas categorías y condiciones de victoria.

\- \*\*Estadísticas:\*\* consulta de resultados y rendimiento de los jugadores.

\- \*\*Historial de movimientos:\*\* almacenamiento de los movimientos de las partidas mediante archivos XML.

\- \*\*Persistencia de datos:\*\* almacenamiento de usuarios, partidas y resultados en SQL Server.



\## 🛠️ Tecnologías utilizadas



\- C#

\- .NET Framework 4.7.2

\- Windows Forms

\- SQL Server

\- ADO.NET

\- XML

\- Visual Studio



\## 🏗️ Arquitectura



El proyecto está organizado siguiendo una arquitectura de cuatro capas, separando responsabilidades para facilitar el mantenimiento y la organización del código.



| Capa | Responsabilidad |

|---|---|

| \*\*BE (Business Entities)\*\* | Clases y entidades del sistema. |

| \*\*BLL (Business Logic Layer)\*\* | Reglas de negocio, lógica del juego y cálculos de puntaje. |

| \*\*DAL (Data Access Layer)\*\* | Acceso a datos, operaciones con SQL Server y almacenamiento XML. |

| \*\*Presentación\*\* | Interfaz gráfica desarrollada con Windows Forms. |



\## 🗄️ Base de datos



Se utiliza SQL Server para almacenar la información de usuarios, partidas, categorías y estadísticas.



El acceso a datos se realiza mediante ADO.NET y procedimientos almacenados.



\## 🚀 Instalación y ejecución



1\. Clonar el repositorio:

&#x20;  ```bash

&#x20;  git clone https://github.com/LuistaDm/Generala.git

&#x20;  ```



2\. Abrir `Generala.slnx` con Visual Studio.



3\. Verificar que SQL Server LocalDB esté instalado.



4\. Configurar la base de datos `TpGenerala` y la cadena de conexión en `DAL/Acceso.cs`.



5\. Compilar la solución y ejecutar el proyecto de presentación.



\## 👨‍💻 Autor



\*\*Luis Domin\*\*



Estudiante de Licenciatura en Gestión de Tecnologías Informáticas - Universidad Abierta Interamericana (UAI).



\- \[GitHub](https://github.com/LuistaDm)

\- \[LinkedIn](https://www.linkedin.com/in/luis-domin-bb7342360/)



\---



Proyecto académico desarrollado como Trabajo Práctico Integrador.

