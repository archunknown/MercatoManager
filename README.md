# MercatoManager

Una aplicación de escritorio en Windows Forms para la gestión de clientes y productos en un mercado. Permite registrar clientes, agregar productos y asignar productos a clientes, calculando el total gastado por cada cliente.

## Características

### Gestión de Clientes
- Registro de clientes con validación de DNI (8 dígitos) y celular (9 dígitos)
- Campos: Nombres, Apellidos, DNI, Celular
- Visualización en DataGridView

### Gestión de Productos
- Registro de productos con código, nombre, categoría y precio
- Validación de precio numérico
- Visualización en DataGridView

### Asignación de Productos
- Asignar productos a clientes desde combos desplegables
- Cálculo automático del total gastado por cliente
- Actualización en tiempo real del total

### Persistencia de Datos
- Guardado automático en archivos JSON (`cliente.txt`, `producto.txt`)
- Carga automática al iniciar la aplicación

## Requisitos

- .NET 8.0 o superior
- Windows 10/11
- Visual Studio 2022 (opcional, para desarrollo)

## Instalación y Ejecución

1. Clona el repositorio:
   ```bash
   git clone <url-del-repositorio>
   cd MercatoManager
   ```

2. Restaura las dependencias:
   ```bash
   dotnet restore
   ```

3. Ejecuta la aplicación:
   ```bash
   dotnet run
   ```

## Estructura del Proyecto

```
MercatoManager/
├── Models/
│   ├── Cliente.cs      # Clase Cliente con validaciones
│   └── Producto.cs     # Clase Producto
├── Form1.cs            # Lógica principal de la aplicación
├── Form1.Designer.cs   # Diseño de la interfaz de usuario
├── Program.cs          # Punto de entrada
├── cliente.txt         # Archivo de datos de clientes (generado)
├── producto.txt        # Archivo de datos de productos (generado)
└── TODO.md             # Lista de tareas completadas
```

## Uso

1. **Agregar Cliente**: Completa los campos en la sección "Registro de Clientes" y presiona "Agregar Cliente"
2. **Agregar Producto**: Completa los campos en la sección "Registro de Productos" y presiona "Agregar Producto"
3. **Asignar Producto**: Selecciona un cliente y un producto en los combos, luego presiona "Asignar"
4. **Ver Total**: El total gastado se actualiza automáticamente al seleccionar un cliente

## Validaciones

- DNI: Debe tener exactamente 8 dígitos numéricos
- Celular: Debe tener exactamente 9 dígitos numéricos
- Precio: Debe ser un valor numérico válido

## Tecnologías Utilizadas

- **C#** - Lenguaje de programación
- **Windows Forms** - Framework de UI
- **System.Text.Json** - Serialización de datos
- **.NET 8.0** - Framework de desarrollo

## Contribución

1. Fork el proyecto
2. Crea una rama para tu feature (`git checkout -b feature/nueva-funcionalidad`)
3. Commit tus cambios (`git commit -am 'Agrega nueva funcionalidad'`)
4. Push a la rama (`git push origin feature/nueva-funcionalidad`)
5. Abre un Pull Request

## Licencia

Este proyecto está bajo la Licencia MIT. Ver el archivo `LICENSE` para más detalles.

## Autor

Desarrollado como parte de un proyecto de práctica en Windows Forms con C#.
