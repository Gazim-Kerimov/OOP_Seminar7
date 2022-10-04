using System.Collections;
using System.IO;
public class FileExport{
    StreamWriter writer;
    public void exportList(){
        writer = new StreamWriter(FilePath.getPath());
        List<Card> list = CardList.getInstance().getList();
        for(int i = 0; i < list.Count; i++){
            string line = list[i].ToString();
            writer.WriteLine(line);
        }
        writer.Flush();
        writer.Close();
        Console.WriteLine("Данные успешно выгружены в файл");
    }
}