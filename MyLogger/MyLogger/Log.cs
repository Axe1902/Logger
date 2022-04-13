using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogger
{
    public class Log
    {
        //Создаю enum поля с доступами логгирования
        public enum LogLevel { Debug, Info, Warning, Error }

        //Данный метод генерирует строку сообщения лога в зависимости от наличия или отсутствия ошибки
        private static string LogStringBuilder(string message, LogLevel level, DateTime time, Exception ex = null) { 
            return ex != null ? $"{time}|{level}|{message}|{ex}" 
                              : $"{time}|{level}|{message}";
        }

        //Данный метод записывает лог в файл, предварительно получил строку для записи от LogStringBuilder
        public static void LogWriter(string message, LogLevel level, Exception ex = null) {
            DateTime timeOfMes = DateTime.Now;
            StreamWriter sw = new StreamWriter("Log.txt", true);
            sw.WriteLine(LogStringBuilder(message, level, timeOfMes, ex));
            sw.Close();
        }

    }
}