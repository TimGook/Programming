using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using ObjectOrientedPractics.Model;
using static System.Environment;

namespace ObjectOrientedPractics.ClassesSerialization
{
    /// <summary>
    /// Класс для сериализации и десериализации данных.
    /// </summary>
    internal class ItemsSerializer
    {
        /// <summary>
        /// Путь к директории.
        /// </summary>
        private static readonly string PathDirectory =
            $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/ObjectOrientedPractics";

        /// <summary>
        /// Путь к файлу.
        /// </summary>
        private static readonly string PathFile = $"{PathDirectory}/items.json";

        /// <summary>
        /// Метод для получения списка товаров.
        /// </summary>
        /// <returns>Возвращает список товаров.</returns>
        public static List<Item> LoadItems()
        {
            try
            {
                var items = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(PathFile));
                return items;
            }
            catch (DirectoryNotFoundException)
            {
                var dataString = CreateDto();
                Directory.CreateDirectory(PathDirectory);
                CreateNewFile<Item>();
                File.WriteAllText(PathFile, dataString);
                return new List<Item>();

            }
            catch (FileNotFoundException)
            {
                var dataString = CreateDto();
                CreateNewFile<Item>();
                File.WriteAllText(PathFile, dataString);
                return new List<Item>();

            }
            catch (JsonSerializationException)
            {
                var dataString = CreateDto();
                CreateNewFile<Item>();
                File.WriteAllText(PathFile, dataString);
                return new List<Item>();
            }
        }

        /// <summary>
        /// Сохраняет список товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public static void Save(List<Item> items)
        {
            try
            {
                File.WriteAllText(PathFile, JsonConvert.SerializeObject(items));
            }
            catch (DirectoryNotFoundException)
            {
                var dataString = CreateDto();
                Directory.CreateDirectory(PathDirectory);
                CreateNewFile<Item>();
                File.WriteAllText(PathFile, dataString);
            }
            catch (FileNotFoundException)
            {
                var dataString = CreateDto();
                CreateNewFile<Item>();
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
            var fileStream = File.Create(PathFile);

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
            var items = new List<Item>();
            var dataString = JsonConvert.SerializeObject(items);
            return dataString;
        }





        ///// <summary>
        ///// Класс с методами для сериализации.
        ///// </summary>
        //internal static class ProjectSerializer
        //{
        //    /// <summary>
        //    /// Путь к файлу
        //    /// </summary>
        //    private static string FilepathItems = (Path.Combine(Environment.GetFolderPath(SpecialFolder.ApplicationData), @"Project\\ItemsData.json"));

        //    private static string FilepathCustomers = (Path.Combine(Environment.GetFolderPath(SpecialFolder.ApplicationData), @"Project\\CustomersData.json"));

        //    /// <summary>
        //    /// Метод для сохранения данных в json файл.
        //    /// </summary>
        //    /// <param name="ItemsListBox">Элемент управления для отображения списка элементов.</param>
        //    /// <param name="_ItemsList"> Список товаров.</param>
        //    public static void SaveItems(ref ListBox ItemsListBox, List<Item> _ItemsList)
        //    {
        //        if (ItemsListBox.Items.Count != 0)
        //        {
        //            var jsonString = System.Text.Json.JsonSerializer.Serialize(_ItemsList);
        //            if (!Directory.Exists(Path.Combine(Environment.GetFolderPath(SpecialFolder.ApplicationData), @"Project")))
        //            {
        //                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(SpecialFolder.ApplicationData), @"Project"));
        //            }
        //            File.WriteAllText(FilepathItems, jsonString);
        //        }
        //    }

        //    /// <summary>
        //    /// Метод для загрузки данных из json файла в список
        //    /// </summary>
        //    /// <param name="_ItemsList"> Список с данными</param>
        //    public static void ItemsInfo(ref List<Item> _ItemsList)
        //    {
        //        if (File.Exists(FilepathItems))
        //        {
        //            _ItemsList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(FilepathItems));
        //        }
        //    }

        //    /// <summary>
        //    /// Метод для сохранения данных в json файл.
        //    /// </summary>
        //    /// <param name="CustomersListBox">Элемент управления для отображения списка элементов.</param>
        //    /// <param name="_customersList"> Список покупателей.</param>
        //    public static void SaveCustomers(ref ListBox CustomersListBox, List<Item> _customersList)
        //    {
        //        if (CustomersListBox.Items.Count != 0)
        //        {
        //            //var jsonString = System.Text.Json.JsonSerializer.Serialize(_customersList);
        //            var jsonString = System.Text.Json.JsonSerializer.Serialize(_customersList);
        //            if (!Directory.Exists(Path.Combine(Environment.GetFolderPath(SpecialFolder.ApplicationData), @"Project")))
        //            {
        //                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(SpecialFolder.ApplicationData), @"Project"));
        //            }
        //            File.WriteAllText(FilepathCustomers, jsonString);
        //        }
        //    }

        //    /// <summary>
        //    /// Метод для загрузки данных из json файла в список
        //    /// </summary>
        //    /// <param name="_customersList"> Список с данными</param>
        //    public static void CustomerInfo(ref List<Item> _customersList)
        //    {
        //        if (File.Exists(FilepathCustomers))
        //        {
        //            _customersList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(FilepathCustomers));
        //        }
        //    }
        //}
    }
}
