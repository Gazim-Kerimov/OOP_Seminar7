
public class FileManager{
    public FileImport importer;
    FileExport exporter;
    public FileManager(){
        importer = new FileImport();
        exporter = new FileExport();
    }
    public void manage(){
        exporter.exportList();
    }
}