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

        public void Write(float floatData)
        {
            bw.Write(floatData);
        }

        public void Write(int integerData)
        {
            bw.Write(integerData);
        }

        public void Write(uint uintegerData)
        {
            bw.Write(uintegerData);
        }
        
        public void Write(bool booleanData)
        {
            bw.Write(booleanData);
        }

        public void Write(char theChar)
        {
            bw.Write(theChar);
        }
        
        public void Write(byte theByte)
        {
            bw.Write(theByte);
        }
        
        public void Write(byte[] theBytes)
        {
            byte[] buffer = Compress(theBytes);

            bw.Write(buffer.Length);
            bw.Write(buffer);
        }

        public void WriteFile(string filePath)
        {
            Write(File.ReadAllBytes(filePath));
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

        public string ReadString()
        {
            return br.ReadString();
        }

        public float ReadFloat()
        {
            return br.ReadSingle();
        }
        
        public int ReadInteger()
        {
            return br.ReadInt32();
        }

        public uint ReadUInteger()
        {
            return br.ReadUInt32();
        }

        public bool ReadBoolean()
        {
            return br.ReadBoolean();
        }

        public char ReadChar()
        {
            return br.ReadChar();
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

        public void ReadFile(string filePath)
        {
            File.WriteAllBytes(filePath, ReadBytes());
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
