using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace passpro
{
    class CheckPro
    {
        public static string KEY = "";
        private string PassFill = "./pass.pass";
        private string keyFill = "./key";
        /// <summary>
        /// 本结构用于存储密码，包括
        /// no  密码序号
        /// passType    密码类型
        /// passUserName    用户名
        /// passPassword    密码
        /// </summary>
        public struct passStruct
        {            
            public string no { get; set; }
            public string passType { get; set; }
            public string passUserName { get; set; }
            public string passPassword { get; set; }
        }
        //插入密码
        public void insertPass(passStruct pass)
        {
            if (this.checkPassFill())
            {
                this.writePassFill(pass);
            }
            else
            {
                this.createFile();
                this.writePassFill(pass);
            }
        }

        public bool checkPassFill()
        {
            if (File.Exists(this.PassFill) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool checkKeyFile()
        {
            if (File.Exists(this.keyFill) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool checkKeyValue(string key)
        {
            string value = File.ReadAllText(this.keyFill);
            if (this.MD5Encrypt16(key) == value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void createKey(string key)
        {
            //File.Create("./key");
            string md5Key = this.MD5Encrypt16(key);
            File.WriteAllText(this.keyFill, md5Key);
        }

        private void createFile()
        {
            File.Create(this.PassFill);
        }
        //写入密码文件
        private void writePassFill(passStruct pass)
        {
            string content =
                pass.no.ToString() + "\t" +
                pass.passType + "\t" +
                pass.passUserName + "\t" +
                pass.passPassword + "\r\n";
            FileStream fm = File.Open(this.PassFill, FileMode.Append);
            fm.Position = fm.Length;
            StreamWriter sw = new StreamWriter(fm);
            sw.Write(content);
            sw.Close();
            fm.Close();
        }
        //删除密码
        public void deletePass(passStruct psObj)
        {
            FileStream fs = File.Open(this.PassFill, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            
            string srLine = sr.ReadLine();
            List<string> list = new List<string> {srLine};
            while (srLine != null)
            {
                srLine = sr.ReadLine();
                list.Add(srLine);
            }

            sr.Close();
            string obj = psObj.no + "\t" +
                            psObj.passType + "\t" +
                            psObj.passUserName + "\t" +
                            psObj.passPassword;

            list.Remove(obj);
            fs.Close();
            fs = File.Open(this.PassFill, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < list.Count-1; i++)
            {
                sw.Write(list[i] + "\r\n");
            }
            sw.Close();
            fs.Close();
        }
        //读取pass文件的内容
        public List<passStruct> readPassFill()
        {
            FileStream fs = File.Open(this.PassFill, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            List<passStruct> list = new List<passStruct> { };
            string srLine = sr.ReadLine();

            while (srLine != null)
            {
                string[] strarr = srLine.Split('\t');
                passStruct passStruct = new passStruct();
                passStruct.no = strarr[0];
                passStruct.passType = strarr[1];
                passStruct.passUserName = strarr[2];
                passStruct.passPassword = strarr[3];
                list.Add(passStruct);
                srLine = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            return list;
        }
        //修改密码文件
        public  void updatePassFill(passStruct oldPs,passStruct newPs)
        {
            FileStream fs = File.Open(this.PassFill,FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string srLine = sr.ReadLine();
            List<string> list = new List<string> { srLine };
            while(srLine != null)
            {
                srLine = sr.ReadLine();
                list.Add(srLine);
            }
            string oldObj = oldPs.no + "\t" +
                            oldPs.passType + "\t" +
                            oldPs.passUserName + "\t" +
                            oldPs.passPassword;
            string newObj = newPs.no + "\t" +
                            newPs.passType + "\t" +
                            newPs.passUserName + "\t" +
                            newPs.passPassword;
            int item = list.IndexOf(oldObj);
            list.Remove(oldObj);
            list.Insert(item, newObj);
            fs.Close();
            fs = File.Open(this.PassFill, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < list.Count - 1; i++)
            {
                sw.Write(list[i] + "\r\n");
            }
            sw.Close();
            fs.Close();
        }
        private string MD5Encrypt16(string password)
        {
            var md5 = new MD5CryptoServiceProvider();
            string t2 = BitConverter.ToString(md5.ComputeHash(Encoding.Default.GetBytes(password)), 4, 8);
            t2 = t2.Replace("-", "");
            return t2;
        }

        public struct RSAKey
        {
            public string PublicKey { get; set; }
            public string PrivateKey { get; set; }
        }

        public static RSAKey GetRASKey()
        {
            RSACryptoServiceProvider.UseMachineKeyStore = true;
            RSACryptoServiceProvider rsaProvider = new RSACryptoServiceProvider();
            RSAParameters p = rsaProvider.ExportParameters(true);

            return new RSAKey()
            {
                PublicKey = ComponentKey(p.Exponent, p.Modulus),
                PrivateKey = ComponentKey(p.D, p.Modulus)
            };
        }

        private static string ComponentKey(byte[] b1, byte[] b2)
        {
            List<byte> list = new List<byte>();
            list.Add((byte)b1.Length);
            list.AddRange(b1);
            list.AddRange(b2);
            byte[] b = list.ToArray<byte>();
            return Convert.ToBase64String(b);
        }
    }
}
