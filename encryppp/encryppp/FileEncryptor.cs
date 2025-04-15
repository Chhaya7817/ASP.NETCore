using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using Microsoft.Windows.Compatibility;

class FileEncryptor
{
    static void Main()
    {
        Console.WriteLine("Select CSV and XLS Files:");

        List<string> filePaths = SelectFiles();
        if (filePaths.Count > 0)
        {
            byte[] key = GenerateRandomKey();
            EncryptFiles(filePaths, key);

            Console.WriteLine($"Encryption key: {BitConverter.ToString(key).Replace("-", "")}");
            Console.WriteLine("Files encrypted successfully!");
        }
    }

    static List<string> SelectFiles()
    {
        List<string> filePaths = new List<string>();

        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv|Excel Files (*.xls;*.xlsx)|*.xls;*.xlsx|All Files (*.*)|*.*";

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    filePaths.Add(fileName);
                }
            }
        }

        return filePaths;
    }

    static byte[] GenerateRandomKey()
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.GenerateKey();
            return aesAlg.Key;
        }
    }

    static void EncryptFiles(List<string> filePaths, byte[] key)
    {
        foreach (var filePath in filePaths)
        {
            byte[] fileData = File.ReadAllBytes(filePath);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.GenerateIV();

                using (ICryptoTransform encryptor = aesAlg.CreateEncryptor())
                using (MemoryStream msEncrypt = new MemoryStream())
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length);
                    csEncrypt.Write(fileData, 0, fileData.Length);
                    csEncrypt.FlushFinalBlock();

                    byte[] encryptedData = msEncrypt.ToArray();
                    File.WriteAllBytes(filePath + ".enc", encryptedData);
                }
            }
        }
    }
}
