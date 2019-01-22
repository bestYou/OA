using System;
using System.Security.Cryptography;
using System.Text;



namespace testEF
{
    class EncodeMD5
    {
        /// <summary>
        /// 加密用户密码
        /// </summary>
        /// <param name="password">密码</param>
        /// <returns>加密密码</returns>
        public static string getMD5(string password)
        {
            if (!string.IsNullOrEmpty(password))
            {
                // 32位加密
                byte[] result = Encoding.Default.GetBytes(password);
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] output = md5.ComputeHash(result);
                String md5_str = BitConverter.ToString(output).Replace("-", "");
                return md5_str;
            }
            return string.Empty;
        }
    }
}
