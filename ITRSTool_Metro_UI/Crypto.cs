using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ITRSTool_Metro_UI
{
    class Crypto
    {
        static public void en_to(string pass)
        {
            
                FileStream stream = new FileStream("options.ini", FileMode.OpenOrCreate, FileAccess.Write);
                DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();
                cryptic.Key = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
                cryptic.IV = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
                CryptoStream crStream = new CryptoStream(stream,
                cryptic.CreateEncryptor(), CryptoStreamMode.Write);
                byte[] data = ASCIIEncoding.ASCII.GetBytes("" + pass + "");
                crStream.Write(data, 0, data.Length);
                crStream.Close();
                stream.Close();
           
        }
        static public string en_ex()
        {
            string data = "";
            
                FileStream stream = new FileStream("options.ini",
                                  FileMode.Open, FileAccess.Read);

                DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();

                cryptic.Key = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
                cryptic.IV = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");

                CryptoStream crStream = new CryptoStream(stream,
                    cryptic.CreateDecryptor(), CryptoStreamMode.Read);

                StreamReader reader = new StreamReader(crStream);

                data = reader.ReadToEnd();


                reader.Close();
                stream.Close();
                return data;

        }


    }
    class encrypt_pass
    {
        static public Guid GetHashString(string s)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = string.Empty;
            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);
            return new Guid(hash);

        }
    }


}
    

