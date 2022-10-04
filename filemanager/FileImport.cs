using System.IO;
public class FileImport{
    StreamReader reader;
    Converter converter;
    public FileImport(){
        reader = new StreamReader(FilePath.getPath());
        converter = new Converter();
    }
    public void read(){
        string line = reader.ReadLine();
        while(line != null){
            CardList.getInstance().addCard(converter.convertToCard(line));
            line = reader.ReadLine();
        }
        reader.Close();
    }

}