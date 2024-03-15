using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Contacts.Model.Services
{
    /// <summary>
    /// Предоставляет методы для сериализации контакта.
    /// </summary>
    internal class ContactSerializer
    {
        public string Filename { get; set; }

        /// <summary>
        /// Путь к директории.
        /// </summary>
        private static readonly string PathDirectory =
            $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/Contacts";

        /// <summary>
        /// Путь к файлу.
        /// </summary>
        private static readonly string PathFile = $"{PathDirectory}/contacts.json";

        /// <summary>
        /// Метод для загрузки данных контакта из файла.
        /// </summary>
        /// <returns>Возвращает контакт.</returns>
        public static Contact LoadFromFile()
        {
            try
            {
                var contact = JsonConvert.DeserializeObject<Contact>(File.ReadAllText(PathFile));
                return contact;
            }
            catch (DirectoryNotFoundException)
            {
                var dataString = CreateDto();
                Directory.CreateDirectory(PathDirectory);
                CreateNewFile<Contact>();
                File.WriteAllText(PathFile, dataString);
                return new Contact();

            }
            catch (FileNotFoundException)
            {
                var dataString = CreateDto();
                CreateNewFile<Contact>();
                File.WriteAllText(PathFile, dataString);
                return new Contact();

            }
            catch (JsonSerializationException)
            {
                var dataString = CreateDto();
                CreateNewFile<Contact>();
                File.WriteAllText(PathFile, dataString);
                return new Contact();
            }
        }

        /// <summary>
        /// Сохраняет контакт.
        /// </summary>
        /// <param name="contact">Контакт.</param>
        public static void SaveToFile(Contact contact)
        {
            try
            {
                File.WriteAllText(PathFile, JsonConvert.SerializeObject(contact));
            }
            catch (DirectoryNotFoundException)
            {
                var dataString = CreateDto();
                Directory.CreateDirectory(PathDirectory);
                CreateNewFile<Contact>();
                File.WriteAllText(PathFile, dataString);
            }
            catch (FileNotFoundException)
            {
                var dataString = CreateDto();
                CreateNewFile<Contact>();
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
            //using var fileStream = File.Create(PathFile);
            File.Create(PathFile);

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
            var contact = new Contact();
            var dataString = JsonConvert.SerializeObject(contact);
            return dataString;
        }
    }
}
