# 💱 ConversorDeMoneda

Sistema de conversión de divisas desarrollado en **C# Windows Forms** con arquitectura en 3 capas, SQL Server y Guna UI2.

> Autor: **Jvven!** | .NET Framework 4.7.2

---

## 📋 Descripción

Aplicación de escritorio que permite realizar conversiones entre distintas monedas registradas en la base de datos, con gestión de usuarios, tasas de cambio, historial de conversiones y auditoría de acciones.

---

## 🏗️ Arquitectura — 3 Capas

```
CapaPresentacion/        → Formularios WinForms (UI)
CapaNegocio/             → Lógica de negocio (CN_*)
CapaDatos/               → Acceso a datos y SQL Server (CD_*)
```

### Flujo de datos
```
Formulario → CN_* → CD_* → SQL Server (Stored Procedures)
```

---

## 🗄️ Base de Datos — `ConversorDeMoneda`

### Tablas

| Tabla | Descripción |
|-------|-------------|
| `Usuario` | Usuarios del sistema con nombre y rol |
| `TasaCambio` | Monedas con su valor respecto al DOP |
| `Conversion` | Historial de conversiones realizadas |
| `Auditoria` | Registro de acciones ejecutadas por usuario |

### Stored Procedures

| Procedimiento | Acción |
|---|---|
| `MostrarUsuario` / `InsertarUsuario` / `EditarUsuario` / `EliminarUsuario` | CRUD de usuarios |
| `MostrarTasaCambio` / `InsertarTasa` / `EditarTasa` / `EliminarTasa` | CRUD de tasas |
| `MostrarConversion` / `InsertarConversion` | Historial de conversiones |
| `MostrarAuditoria` / `InsertarAuditoria` | Registro de auditoría |

### Datos requeridos para iniciar
```sql
-- La moneda base DOP debe existir con valor 1.00
INSERT INTO TasaCambio VALUES ('DOP', 1.00, GETDATE())
```

---

## 📁 Estructura del Proyecto

```
ConversorDeMoneda/
├── CapaDatos/
│   ├── CD_Base.cs          ← Clase abstracta base
│   ├── CD_Conexion.cs      ← Manejo de conexión SQL Server
│   ├── CD_TasaCambio.cs
│   ├── CD_Usuario.cs
│   ├── CD_Conversion.cs
│   └── CD_Auditoria.cs
├── CapaNegocio/
│   ├── CN_TasaCambio.cs
│   ├── CN_Usuario.cs       ← Incluye clase estática Sesion
│   ├── CN_Conversion.cs    ← Incluye lógica de cálculo
│   └── CN_Auditoria.cs
├── ConversorDeMoneda/      ← CapaPresentacion
│   ├── FormInicio.cs       ← Selección de usuario
│   ├── Form1.cs            ← Menú principal con sidebar
│   └── FormConversion.cs  ← Conversor de monedas
└── ConversorDeMoneda.sql   ← Script de base de datos
```

---

## 🧱 Capa de Datos

### `CD_Base` (abstracta)
Clase base de la que heredan todas las clases de datos. Implementa el patrón plantilla para operaciones comunes.

```csharp
public abstract DataTable Mostrar();                              // Abstracto — cada clase lo implementa
protected virtual DataTable EjecutarMostrar(string sp)           // Ejecuta SELECT via stored procedure
public virtual void Eliminar(string sp, string param, int id)    // Elimina por ID via stored procedure
protected void LimpiarCeldas()                                   // Limpia parámetros del comando
```

### `CD_Conexion`
Gestiona la conexión a SQL Server con autenticación de Windows.
```
Server=.; Database=ConversorDeMoneda; Integrated Security=true;
```

### `CD_TasaCambio : CD_Base`
- `Mostrar()` → override → llama `MostrarTasaCambio`
- `Insertar(string, double)` → virtual → llama `InsertarTasa`
- `Editar(string, double, int)` → virtual → llama `EditarTasa`
- `Eliminar(int TasaID)` → llama `base.Eliminar("EliminarTasa"...)`

### `CD_Usuario : CD_Base`
- `Mostrar()` → override → llama `MostrarUsuario`
- `Insertar(string, string)` → llama `InsertarUsuario`
- `Editar(string, string, int)` → virtual → llama `EditarUsuario`
- `Eliminar(int UsuarioID)` → llama `base.Eliminar("EliminarUsuario"...)`

### `CD_Conversion : CD_Base`
- `Mostrar()` → override → llama `MostrarConversion`
- `Insertar(int, int, decimal, decimal, decimal)` → virtual → llama `InsertarConversion`

### `CD_Auditoria : CD_Base`
- `Mostrar()` → override → llama `MostrarAuditoria`
- `Insertar(int, string)` → llama `InsertarAuditoria`

---

## 🧠 Capa de Negocio

### `Sesion` (clase estática)
Almacena los datos del usuario activo durante toda la sesión de la aplicación.
```csharp
public static int    UsuarioID     { get; set; }
public static string UsuarioNombre { get; set; }
public static string Rol           { get; set; }
```

### `CN_Conversion`
Contiene la lógica de cálculo de conversión entre monedas usando DOP como moneda base.

```csharp
// Fórmula: monto × valorTasa
public decimal CalculoConversion(decimal MontoOrigen, decimal ValorTasa)
    => MontoOrigen * ValorTasa;
```

> Ejemplo: 100 USD × 60.00 (tasa DOP) = RD$ 6,000.00

---

## 🖥️ Capa de Presentación

### `FormInicio`
- Pantalla de bienvenida con ComboBox de usuarios.
- Al presionar **Entrar**, guarda el usuario en `Sesion` y abre `Form1`.

### `Form1` — Menú Principal
Panel lateral animado (colapsa/expande con hover) con navegación a los módulos:

| Botón | Módulo |
|-------|--------|
| INICIO | Abre `FormConversion` dentro del panel principal |
| USUARIO | CRUD de usuarios |
| TASA DE CAMBIO | CRUD de tasas de cambio |
| REGISTRO | Historial de conversiones (solo lectura) |
| AUDITORÍA | Log de acciones (solo lectura) |

Los botones **Guardar / Editar / Eliminar** son reutilizables y se comportan según el módulo activo mediante un `switch(moduloActivo)`.

### `FormConversion`
- Muestra el nombre y ID del usuario activo.
- ComboBox con las monedas disponibles.
- Al seleccionar una moneda, muestra su tasa en tiempo real.
- Al presionar **Conversión**, calcula, muestra el resultado y guarda el registro automáticamente.

---

## 🎨 Paleta de Colores

| Elemento | Color |
|----------|-------|
| Fondo principal | `RGB(19, 19, 31)` |
| Cards / paneles | `RGB(42, 42, 64)` |
| Inputs | `RGB(37, 37, 56)` |
| Acento verde (botón, títulos) | `#4FFFB0` |
| Rosa (labels) | `#F92672` |
| Amarillo (valores/tasas) | `#E6C07B` |
| Texto principal | `RGB(171, 178, 191)` |

---

## ⚙️ Requisitos

- Visual Studio 2019 o superior
- .NET Framework 4.7.2
- SQL Server (instancia local `.\` o `localhost`)
- Guna UI2 (via NuGet)

---

## 🚀 Instalación

1. Clonar el repositorio:
```bash
git clone https://github.com/Jvven-24/ConversorDeMoneda.git
```

2. Ejecutar el script SQL en SSMS:
```
ConversorDeMoneda.sql
```

3. Verificar la cadena de conexión en `CD_Conexion.cs`:
```csharp
"Server=.; Database=ConversorDeMoneda; Integrated Security=true;"
```

4. Abrir la solución en Visual Studio y ejecutar con `F5`.

---

## 🧩 Conceptos POO Aplicados

| Concepto | Dónde se aplica |
|----------|----------------|
| **Herencia** | `CD_TasaCambio`, `CD_Usuario`, etc. heredan de `CD_Base` |
| **Abstracción** | `CD_Base` es abstracta con método `Mostrar()` abstracto |
| **Polimorfismo** | `override` en cada `Mostrar()`, `virtual` en `Insertar/Editar` |
| **Encapsulamiento** | Propiedades con `get/set`, campos `protected` en `CD_Base` |
| **Clase estática** | `Sesion` mantiene estado global del usuario activo |

---

*Desarrollado por **Jvven!***
