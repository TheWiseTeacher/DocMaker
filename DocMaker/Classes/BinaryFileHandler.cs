using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DocMaker
{
    class BinaryFileHandler
    {
        public enum FileMode
        {
            READ = System.IO.FileMode.Open,
            WRITE = System.IO.FileMode.Create,
        }

        private string filePath = null;
        private FileMode fileMode = FileMode.READ;
        private FileStream fileStream = null;

        private BinaryWriter bw = null;
        private BinaryReader br = null;

        public BinaryFileHandler(string file, FileMode mode)
        {
            filePath = file;
            fileMode = mode;

            fileStream = new FileStream(filePath, (System.IO.FileMode)fileMode);

            switch (fileMode)
            {
                case FileMode.READ:
                    br = new BinaryReader(fileStream);
                    break;

                case FileMode.WRITE:
                    bw = new BinaryWriter(fileStream);
                    break;
            }
        }

        public void Write(string stringData)
        {
            bw.Write(stringData);
        }

        public void Write(int integerData)
        {
            bw.Write(integerData);
        }
        
        public void Write(bool booleanData)
        {
            bw.Write(booleanData);
        }

        public void Write(byte theByte)
        {
            bw.Write(theByte);
        }

        public void Write(byte[] theBytes)
        {
            //byte[] buffer = new byte[theBytes.Length];
            //for (int i = 0; i < buffer.Length; i++) buffer[i] = (byte)(theBytes[i] ^ 0xFF);

            byte[] buffer = Compress(theBytes);

            bw.Write(buffer.Length);
            bw.Write(buffer);
        }

        public static byte[] Compress(byte[] data)
        {
            MemoryStream output = new MemoryStream();
            using (DeflateStream dstream = new DeflateStream(output, CompressionLevel.Optimal))
            {
                dstream.Write(data, 0, data.Length);
            }
            return output.ToArray();
        }

        public static byte[] Decompress(byte[] data)
        {
            MemoryStream input = new MemoryStream(data);
            MemoryStream output = new MemoryStream();
            using (DeflateStream dstream = new DeflateStream(input, CompressionMode.Decompress))
            {
                dstream.CopyTo(output);
            }
            return output.ToArray();
        }

        /*
        public void WriteClassObject(object objectData)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, objectData);
        }
        */

        public string ReadString()
        {
            return br.ReadString();
        }

        public int ReadInteger()
        {
            return br.ReadInt32();
        }

        public bool ReadBoolean()
        {
            return br.ReadBoolean();
        }

        public byte ReadByte()
        {
            return br.ReadByte();
        }

        public byte[] ReadBytes()
        {
            int s = br.ReadInt32();
            byte[] buffer = br.ReadBytes(s);

            return Decompress(buffer);
        }

        public void Close()
        {
            if (fileStream == null)
                return;

            fileStream.Close();
            fileStream.Dispose();
        }
    }
}
