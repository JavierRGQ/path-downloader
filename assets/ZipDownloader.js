addInstallButton('zip_downloader', 'zip_downloader', 'zip_downloader', 'Descargar Output ZIP', async () => {
    // Llama al método C# para comprimir y obtener el path del zip
    const zipPath = await callExtension('ZipDownloaderExtension.CompressAndDownloadOutput');
    // Descarga el archivo zip
    window.open(`/download?file=${encodeURIComponent(zipPath)}`);
});
