# SwarmUI-Zip-Downloader

Extensión para SwarmUI que permite comprimir el contenido de la carpeta de output y descargarlo como un archivo ZIP con un solo click.

## Instalación

1. Copia la carpeta `SwarmUI-Zip-Downloader` dentro de `SwarmUI/src/Extensions/`
2. Reinicia SwarmUI
3. Haz click en el botón "Descargar Output ZIP" en la interfaz

## Funcionamiento

- Al hacer click, se llama al método C# que comprime la carpeta de output (según la configuración de SwarmUI)
- Se genera un archivo `SwarmUI_Output.zip` dentro de la carpeta de output
- El archivo se descarga automáticamente

## Requisitos
- SwarmUI
- Permisos de escritura en la carpeta de output
- .NET con soporte para System.IO.Compression

## Licencia
MIT