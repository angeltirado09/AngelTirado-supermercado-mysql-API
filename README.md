# API Supermercado - Trabajo Práctico N° 1 (Git y Docker)

**Autor:** Angel Tirado  
**Materia:** Ingenieria de software  

## Descripción
Este proyecto es una API REST desarrollada en .NET estructurada en múltiples capas (Backend, Data, Abstractions). El objetivo principal de este repositorio es demostrar el dominio del ciclo de vida de despliegue utilizando herramientas estándar de la industria: **Git** para el control de versiones y **Docker** para la contenedorización. 
Este proyecto es una api que se avanzó de un proyecto de otra materia en ISTEA, en el cual la API trae productos con stock bajo según una base de datos en MySql. Para probar el funcionamiento de la misma añadi una validacion donde si no se posee la base de datos se trae un array vacío, de esta manera se demuestra que la API funciona tanto en mi maquina como en la tuya.

## Tecnologías Utilizadas
**Framework:** .NET (C#)
**Control de Versiones:** Git y GitHub
**Contenedores:** Docker y Docker Desktop
**Editor:** Visual Studio 2022

## Requisitos Previos
Para levantar este proyecto localmente, solo necesita tener instalado:
1. [Git](https://git-scm.com/)
2. [Docker Desktop](https://www.docker.com/products/docker-desktop/) 

---

## Pasos de instalación y ejecución

Pasos para clonar, construir y ejecutar la API de forma aislada.

1. Clonar el repositorio
Clona el proyecto de forma local e ingresa a la carpeta raíz de la solución (donde reside el archivo `.sln`):
```bash
git clone https://github.com/angeltirado09/AngelTirado-supermercado-mysql-API.git
cd AngelTirado-supermercado-mysql-API
```


2. Construcción de la imagen Docker (Build)
Vamos a leer el Dockerfile y a descargar las dependencias de .NET para empaquetar la aplicación, (Nota: recuerda estar posicionado en la raíz del proyecto, donde se encuentra el archivo .sln y la carpeta Supermercado.Backend):
```bash
docker build -t api-supermercado -f Supermercado.Backend/Dockerfile .
```

3. Ejecución del contenedor (Run)
Una vez construida la imagen, levantamos el contenedor mapeando el puerto 8080 local al 8080 del contenedor:
```bash
docker run -d -p 8080:8080 --name mi-api-supermercado api-supermercado
```

4. Verificar que la aplicación funcione
Abre tu navegador web e ingresa a la siguiente ruta para probar el endpoint:
```bash
http://localhost:8080/api/Producto/getStockBajo
```

Si la base de datos está vacía, la API responderá exitosamente con un arreglo vacío [], confirmando que el contenedor está vivo y recibiendo peticiones HTTP como se explicó al principio.

---
1. Repositorio publicado en GitHub
<img width="1600" height="738" alt="image" src="https://github.com/user-attachments/assets/0cd30239-f9da-484e-ba3c-05fd0f3732b0" />

2. Construcción exitosa de la imagen (Docker Build)
<img width="1340" height="461" alt="image" src="https://github.com/user-attachments/assets/3143869b-21d6-418e-8584-153eba8e6f41" />

3. Contenedor activo
<img width="1219" height="102" alt="image" src="https://github.com/user-attachments/assets/7406ca9e-69ef-40b3-8e17-768efe7ee686" />

4. Endpoint respondiendo de manera correcta
<img width="1600" height="155" alt="image" src="https://github.com/user-attachments/assets/8767b616-4167-4785-8659-8846c990298a" />


Espero le guste profe, saludos!!
