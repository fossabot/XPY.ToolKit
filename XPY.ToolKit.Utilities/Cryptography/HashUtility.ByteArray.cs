﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace XPY.ToolKit.Utilities.Cryptography {
    public static partial class HashUtility {
        /// <summary>
        /// 將Byte陣列使用指定的雜湊演算法轉換為雜湊
        /// </summary>
        /// <typeparam name="Algorithm">雜湊演算法型別</typeparam>
        /// <param name="binary">Byte陣列</param>
        /// <returns>雜湊Binary</returns>
        public static byte[] ToHash<Algorithm>(byte[] binary) where Algorithm : HashAlgorithm {
            using (var tempStream = new MemoryStream(binary)) {
                return ToHash<Algorithm>(tempStream);
            }
        }

        /// <summary>
        /// 將Byte陣列使用指定的雜湊演算法轉換為雜湊後在轉換為16進位字串表示
        /// </summary>
        /// <typeparam name="Algorithm">雜湊演算法型別</typeparam>
        /// <param name="binary">Byte陣列</param>
        /// <param name="upper">是否轉換為大寫</param>
        /// <returns>雜湊字串</returns>
        public static string ToHashString<Algorithm>(byte[] binary, bool upper = true) where Algorithm : HashAlgorithm {
            using (var tempStream = new MemoryStream(binary)) {
                return ToHashString<Algorithm>(tempStream);
            }
        }
    }
}
