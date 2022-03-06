var path = @"C:\Users\thiag\Desktop\Git\Directory\globe";
DirectoryReader(path);
FileReader(path);
Console.WriteLine("Press [Enter] to finish...");
Console.ReadLine();

static void FileReader(string path)
{
    var archives = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
    foreach (var archive in archives)
    {
        var fileInfo = new FileInfo(archive);
        Console.WriteLine($"[Name]:{fileInfo.Name}");
        Console.WriteLine($"[Length]:{fileInfo.Length}");
        Console.WriteLine($"[Last Access Time]:{fileInfo.LastAccessTime}");
        Console.WriteLine($"[Folder]:{fileInfo.DirectoryName}");
        Console.WriteLine($"-------------------------------");
    }
}

static void DirectoryReader(string path)
{
    if (Directory.Exists(path))
    {
        var directory = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
        foreach (var dir in directory)
        {
            var dirInfo = new DirectoryInfo(dir);
            Console.WriteLine($"[Name]:{dirInfo.Name}");
            Console.WriteLine($"[Root]:{dirInfo.Root}");
            if (dirInfo.Parent != null)
                Console.WriteLine($"[Parent]:{dirInfo.Parent.Name}");
            Console.WriteLine("----------------------------");
        }
    }
    else
    {
        Console.WriteLine("Directory doens`t exist");
    }
}