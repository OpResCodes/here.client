using System;
using System.IO;
using System.Security.Cryptography;
using System.Text.Json;

namespace Here.Client
{
    public class ApiKeys
    {
        private static readonly byte[] key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };

        public string AppId { get; set; }

        public string ApiKey { get; set; }

        public static ApiKeys LoadFromJson(string filePath)
        {
            using StreamReader reader = new StreamReader(filePath);
            string json = reader.ReadToEnd();
            return System.Text.Json.JsonSerializer.Deserialize<ApiKeys>(json);
        }

        public string ToJson()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                IgnoreReadOnlyProperties = true,
                IncludeFields = false
            };
            return JsonSerializer.Serialize(this, options);
        }

        public static void SaveEncrypted(string filePath, ApiKeys keys)
        {
            using FileStream myStream = new FileStream(filePath, FileMode.OpenOrCreate);
            using Aes aes = Aes.Create();
            aes.Key = key;
            byte[] iv = aes.IV;
            myStream.Write(iv, 0, iv.Length);
            using CryptoStream cryptStream = new CryptoStream(
                myStream,
                aes.CreateEncryptor(),
                CryptoStreamMode.Write);
            using StreamWriter sWriter = new StreamWriter(cryptStream);
            sWriter.Write(keys.ToJson());
        }

        public static ApiKeys LoadEncrypted(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                throw new ArgumentException(nameof(filePath));

            using FileStream myStream = new FileStream(filePath, FileMode.Open);
            using Aes aes = Aes.Create();
            byte[] iv = new byte[aes.IV.Length];
            myStream.Read(iv, 0, iv.Length);
            using CryptoStream cryptStream = new CryptoStream(
                myStream,
                aes.CreateDecryptor(key, iv),
                CryptoStreamMode.Read);
            using StreamReader sReader = new StreamReader(cryptStream);
            string json = sReader.ReadToEnd();
            return System.Text.Json.JsonSerializer.Deserialize<ApiKeys>(json);
        }

    }
}
