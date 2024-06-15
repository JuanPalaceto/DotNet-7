using System.IO.Compression; // BrotliStream, GZipStream, CompressionMode
using System.Xml; // XmlWriter, XmlReader

using static System.Environment; // CurrentDirectory
using static System.IO.Path; // Combine

partial class Program
{
    static void Compress(string alrorithm = "gzip")
    {
        // define a file path using algorithm as file extension
        string filePath = Combine(CurrentDirectory, $"streams.{alrorithm}");

        FileStream file = File.Create(filePath);
        Stream compressor;

        if (alrorithm == "gzip")
        {
            compressor = new GZipStream(file, CompressionMode.Compress);
        }
        else
        {
            compressor = new BrotliStream(file, CompressionMode.Compress);
        }

        using (compressor)
        {
            using (XmlWriter xml = XmlWriter.Create(compressor))
            {
                xml.WriteStartDocument();
                xml.WriteStartElement("callsigns");
                foreach (string item in Viper.Callsigns)
                {
                    xml.WriteElementString("callsign", item);
                }
            }
        } // also closes underlying stream

        // output all the contents of the compressed file
        WriteLine("{0} contains {1:N0} bytes.", filePath, new FileInfo(filePath).Length);

        WriteLine($"The compressed contents:");
        WriteLine(File.ReadAllText(filePath));

        // read a compressed file
        WriteLine("Reading the compressed XML file:");
        file = File.Open(filePath, FileMode.Open);
        Stream decompressor;
        if (alrorithm == "gzip")
        {
            decompressor = new GZipStream(file, CompressionMode.Decompress);
        }
        else
        {
            decompressor = new BrotliStream(file, CompressionMode.Decompress);
        }

        using (decompressor)
        using (XmlReader reader = XmlReader.Create(decompressor))
        while (reader.Read())
            {
                // check if we are on an element node named callsign
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "callsign"))
                {
                    reader.Read(); // move to the next inside element
                    WriteLine($"{reader.Value}"); // reads its value
                }
            }
    }
}