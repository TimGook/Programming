using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersApp.Model.Classes
{
    /// <summary>
    /// Класс для сериализации и десериализации данных.
    /// </summary>
    internal class WorkersSerializer
    {
        /// <summary>
        /// Путь к директории.
        /// </summary>
        private static readonly string PathDirectory =
            $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/WorkersRegister";

        /// <summary>
        /// Путь к файлу.
        /// </summary>
        private static readonly string PathFile = $"{PathDirectory}/workers.json";

        /// <summary>
        /// Метод для получения списка работников.
        /// </summary>
        /// <returns>Возвращает список рабочих.</returns>
        public static List<Worker> LoadWorkers()
        {
            try
            {
                var workers = JsonConvert.DeserializeObject<List<Worker>>(File.ReadAllText(PathFile));
                return workers;
            }
            catch (DirectoryNotFoundException)
            {
                var dataString = CreateDto();
                Directory.CreateDirectory(PathDirectory);
                CreateNewFile<Worker>();
                File.WriteAllText(PathFile, dataString);
                return new List<Worker>();

            }
            catch (FileNotFoundException)
            {
                var dataString = CreateDto();
                CreateNewFile<Worker>();
                File.WriteAllText(PathFile, dataString);
                return new List<Worker>();

            }
            catch (JsonSerializationException)
            {
                var dataString = CreateDto();
                CreateNewFile<Worker>();
                File.WriteAllText(PathFile, dataString);
                return new List<Worker>();
            }
        }

        /// <summary>
        /// Сохраняет список работников.
        /// </summary>
        /// <param name="workers">Список рабочих.</param>
        public static void Save(List<Worker> workers)
        {
            try
            {
                File.WriteAllText(PathFile, JsonConvert.SerializeObject(workers));
            }
            catch (DirectoryNotFoundException)
            {
                var dataString = CreateDto();
                Directory.CreateDirectory(PathDirectory);
                CreateNewFile<Worker>();
                File.WriteAllText(PathFile, dataString);
            }
            catch (FileNotFoundException)
            {
                var dataString = CreateDto();
                CreateNewFile<Worker>();
                File.WriteAllText(PathFile, dataString);
            }

        }

        /// <summary>
        /// Создает файл.
        /// </summary>
        /// <typeparam name="T">Тип файла.</typeparam>
        /// <param name="items">Содерижмое файла.</param>
        private static void CreateNewFile<T>(List<T> items = null)
        {
            using var fileStream = File.Create(PathFile);

            if (items != null)
            {
                File.WriteAllText(PathFile, JsonConvert.SerializeObject(items));
            }
        }

        /// <summary>
        /// Создает экземпляр класса Dto.
        /// </summary>
        /// <returns>Возвращает строку.</returns>
        private static string CreateDto()
        {
            var workers = new List<Worker>();
            var dataString = JsonConvert.SerializeObject(workers);
            return dataString;
        }
    }
}
