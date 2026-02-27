# 🛒 Sistema de Gestión de Catálogo de Artículos (ABM)

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white) ![.NET Framework](https://img.shields.io/badge/.NET_Framework-4.8.1-blue?style=for-the-badge&logo=.net&logoColor=white) ![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white) ![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D4?style=for-the-badge&logo=windows&logoColor=white) ![License: MIT](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)

Un sistema de escritorio robusto desarrollado en **C# (.NET Framework 4.8.1)** para la gestión completa de un catálogo de artículos. Construido con arquitectura en capas (Presentación, Negocio, Dominio), validaciones sólidas y enfoque en la experiencia de usuario.

---

## ✨ Características principales

- ABM completo: alta, baja y modificación de artículos.
- Búsqueda avanzada:
  - `Filtro Rápido`: búsqueda en tiempo real por Código, Nombre, Marca, Categoría y Descripción.
  - `Filtro Avanzado`: criterios dinámicos (LIKE, exacto, mayor/menor) y filtros por rango numérico.
- Validaciones "fail‑fast" en UI y lógica de negocio (prevenir entradas inválidas antes de acceder a BD).
- Manejo de imágenes: `OpenFileDialog`, copia local controlada y configuración de carpeta de imágenes.
- Configuración externalizada en `App.config` (ruta de imágenes, `connectionString`).
- UI Windows Forms con comportamiento modal y estilos consistentes.

---

## 🧭 Requisitos previos

- Windows 10/11
- Visual Studio 2019/2022 (con workload de .NET desktop)
- .NET Framework 4.8.1 (runtime/developer pack)
- SQL Server (Express o instancia local)
- Git (opcional)

---

## 🚀 Instalación rápida

1.  Clonar el repositorio: `git clone https://github.com/LucianoTito/Curso-C-sharp-SQL-Nivel-2.git`
2. Ejecutar el script SQL (ubicación: `sql/` o el archivo provisto por el curso) para crear la base `CATALOGO_DB`.
3.  Abrir la solución (`.sln`) en Visual Studio.
4.  Revisar y ajustar `App.config`:
    - `images-folder` (ruta para guardar imágenes locales).
    - `connectionString` (usar autenticación segura).
5.  Compilar y ejecutar la aplicación.

---

## 🔧 Ejemplo de configuración (`App.config`)

```xml
<configuration>
  <appSettings>
    <!-- Ruta para guardar imágenes locales -->
    <add key="images-folder" value="C:\Catalogo_App_Imagenes\" />
  </appSettings>
  <connectionStrings>
    <!-- Usar autenticación segura -->
    <add name="DefaultConnection" connectionString="Server=.\SQLEXPRESS;Database=CATALOGO_DB;Trusted_Connection=True;" providerName="System.Data.SqlClient" />
  </connectionStrings>
</configuration>
```

---

## 👨‍💻 Sobre el Autor

**Luciano Tito Cedrón** Estudiante de la Tecnicatura Universitaria en Programación (UTN-FRGP) y desarrollador en formación constante Actualmente orientando mi carrera hacia la **Ingeniería de Datos** en el ecosistema de **Microsoft Azure**.

*¡Cualquier feedback constructivo es bienvenido!*

Aviso: no subir cadenas de conexión con credenciales al repositorio.

---

## 🗂 Estructura del proyecto (resumida)

- `Presentacion/` — Formularios WinForms (`FrmArticulos`, `FrmAltaArticulo`, etc.).
- `Negocio/` — Lógica y acceso a datos (`ArticuloNegocio`, `MarcaNegocio`, `CategoriaNegocio`).
- `Dominio/` — Entidades (`Articulo`, `Marca`, `Categoria`).
- `sql/` — Scripts de creación e inserción de datos (si aplica).
- `assets/` — Capturas/GIFs para el README (recomendado).

---

## 🧪 Uso rápido

- `Agregar`: crear artículo y seleccionar imagen (local o URL).
- `Modificar`: editar campos y actualizar imagen si es necesario.
- `Eliminar`: borrar registro (confirmación).
- `Filtro Rápido`: escribe texto para filtrar en tiempo real.
- `Filtro Avanzado`: seleccionar `Campo` → `Criterio` → `Valor` y presionar `Buscar`.

---

## ✅ Buenas prácticas aplicadas

- Separación por capas y responsabilidad única.
- Validaciones en UI y capa de negocio.
- Externalización de rutas y settings.
- Manejo responsable de ficheros e imágenes.

---

## 🤝 Contribuciones

- Abrir un issue para discutir cambios.
- Crear una rama por feature: `feature/nombre-descriptivo`.
- Enviar PR con descripción clara y capturas si aplica.

---

