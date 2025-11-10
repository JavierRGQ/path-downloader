window.addEventListener('DOMContentLoaded', () => {
    if (typeof addToolButton === 'function') {
        addToolButton('Descargar Output ZIP', async () => {
            const zipPath = await callExtension('ZipDownloaderExtension.CompressAndDownloadOutput');
            window.open(`/download?file=${encodeURIComponent(zipPath)}`);
        });
    } else if (typeof addInstallButton === 'function') {
        addInstallButton('zip_downloader', 'zip_downloader', 'zip_downloader', 'Descargar Output ZIP', async () => {
            const zipPath = await callExtension('ZipDownloaderExtension.CompressAndDownloadOutput');
            window.open(`/download?file=${encodeURIComponent(zipPath)}`);
        });
    } else {
        console.warn('No se encontró addToolButton ni addInstallButton en SwarmUI.');
    }
});
