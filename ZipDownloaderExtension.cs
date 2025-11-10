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
        }

        public override void OnInit()
        {
            InstallableFeatures.RegisterInstallableFeature(new InstallableFeature()
            {
                FeatureId = "zip_downloader",
                Name = "Zip Output Downloader",
                Description = "Compresses the SwarmUI output folder and downloads as a zip file.",
                FeatureType = "Extension",
                AssetFiles = new() { "ZipDownloader.js" },
                Installer = () => Task.CompletedTask
            });
        }

        // Called from JS when user clicks the button
        public static string CompressAndDownloadOutput()
        {
            // Get output path from SwarmUI config
            string outputPath = Program.Config.Get("output_path", "output");
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
