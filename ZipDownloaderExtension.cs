using SwarmUI.Core;
using SwarmUI.Utils;
using SwarmUI.Text2Image;
using SwarmUI.Builtin_ComfyUIBackend;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;
using System;

namespace SwarmExtensions.ZipDownloader
{
    public class ZipDownloaderExtension : Extension
    {
        public ZipDownloaderExtension()
        {
            ExtensionName = "ZipDownloaderExtension";
            // Registrar el JS correctamente en la carpeta assets
            ScriptFiles.Add("assets/ZipDownloader.js");
        }

        // Método público para comprimir y descargar output
        public static string CompressAndDownloadOutput()
        {
            // Usa un path fijo para output
            string outputPath = "output";
            if (!Directory.Exists(outputPath))
                throw new Exception($"Output path not found: {outputPath}");

            string zipPath = Path.Combine(outputPath, "SwarmUI_Output.zip");
            if (File.Exists(zipPath))
                File.Delete(zipPath);

            ZipFile.CreateFromDirectory(outputPath, zipPath);
            return zipPath;
        }
    }
}
