using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Поле адреса.
        /// </summary>
        private Address _address = new Address();

        private bool _isValidIndex = false;

        private bool _isValidCountry = false;

        private bool _isValidCity = false;

        private bool _isValidStreet = false;

        private bool _isValidBuilding = false;

        private bool _isValidApartment = false;

        /// <summary>
        /// Возвращает и задает адрес покупателя.
        /// </summary>
        public Address CustomerAddress
        {
            get => _address;
            set
            {
                IndexTextBox.Text = value.Index.ToString();
                CountryTextBox.Text = value.Country;
                CityTextBox.Text = value.City;
                StreetTextBox.Text = value.Street;
                BuildingTextBox.Text = value.Building;
                ApartmentTextBox.Text = value.Apartment;
                _address = value;
            }
        }

        public AddressControl()
        {
            InitializeComponent();
        }

        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CustomerAddress.Index = int.Parse(IndexTextBox.Text);
                IndexTextBox.BackColor = Color.White;
                _isValidIndex = true;
            }
            catch (ArgumentException) 
            {
                IndexTextBox.BackColor = Color.LightPink;
                _isValidIndex = false;
            }
            catch (FormatException)
            {
                IndexTextBox.BackColor = Color.LightPink;
                _isValidIndex = false;
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                    CustomerAddress.Country = CountryTextBox.Text;
                    CountryTextBox.BackColor = Color.White;
                    _isValidCountry = true;
            }
            catch (ArgumentException)
            {
                    CountryTextBox.BackColor = Color.LightPink;
                    _isValidCountry = false;
            }
            catch (FormatException)
            {
                    CountryTextBox.BackColor = Color.LightPink;
                    _isValidCountry = false;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
                {
                    CustomerAddress.City = CityTextBox.Text;
                    CityTextBox.BackColor = Color.White;
                    _isValidCity = true;
                }
                catch (ArgumentException)
                {
                    CityTextBox.BackColor = Color.LightPink;
                    _isValidCity = false;
                }
            }
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                    CustomerAddress.Street = StreetTextBox.Text;
                    StreetTextBox.BackColor = Color.White;
                    _isValidStreet = true;
            }
            catch (ArgumentException)
            {
                    StreetTextBox.BackColor = Color.LightPink;
                    _isValidStreet = false;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                    CustomerAddress.Building = BuildingTextBox.Text;
                    BuildingTextBox.BackColor = Color.White;
                    _isValidBuilding = true;
            }
            catch (ArgumentException)
            {
                    BuildingTextBox.BackColor = Color.LightPink;
                    _isValidBuilding = false;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CustomerAddress.Apartment = ApartmentTextBox.Text;
                ApartmentTextBox.BackColor = Color.White;
                _isValidApartment = true;
            }
            catch (ArgumentException)
            {
                ApartmentTextBox.BackColor = Color.LightPink;
                _isValidApartment = false;
            }
        }

        /// <summary>
        /// Включает/выключает поля.
        /// </summary>
        /// <param name="flag">Включить - True/Выключить - False.</param>
        public void ToggleAddressTextBoxes(bool flag)
        {
                IndexTextBox.Enabled = flag;
                CountryTextBox.Enabled = flag;
                CityTextBox.Enabled = flag;
                StreetTextBox.Enabled = flag;
                BuildingTextBox.Enabled = flag;
                ApartmentTextBox.Enabled = flag;
        }

        /// <summary>
        /// Функция очистки значений всех <see cref="TextBoxBase"/>.
        /// </summary>
        public void AddressClear()
        {
            IndexTextBox.Clear();
            IndexTextBox.BackColor = Color.White;
            CountryTextBox.Clear();
            CountryTextBox.BackColor = Color.White;
            CityTextBox.Clear();
            CityTextBox.BackColor = Color.White;
            StreetTextBox.Clear();
            StreetTextBox.BackColor = Color.White;
            BuildingTextBox.Clear();
            BuildingTextBox.BackColor = Color.White;
            ApartmentTextBox.Clear();
            ApartmentTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// Функция проверки на введённость значений в <see cref="TextBoxBase"/>.
        /// </summary>
        /// <returns>True - не введены. False - введены. </returns>
        public bool AddressIsNullOrEmpty()
        {
            if (!string.IsNullOrEmpty(IndexTextBox.Text) & !string.IsNullOrEmpty(CountryTextBox.Text)
                & !string.IsNullOrEmpty(CityTextBox.Text) & !string.IsNullOrEmpty(StreetTextBox.Text)
                & !string.IsNullOrEmpty(BuildingTextBox.Text) & !string.IsNullOrEmpty(ApartmentTextBox.Text))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Проверка на правильность введённых данных.
        /// </summary>
        /// <returns>True - всё введено правильно. False - неправильно введены.</returns>
        public bool IsValidAddress()
        {
            if (_isValidApartment & _isValidBuilding & _isValidCity & _isValidCountry & _isValidIndex & _isValidStreet)
            {
                return true;
            }
            return false;
        }
    }
}




















//private void IndexTextBox_TextChanged(object sender, EventArgs e)
//{
//    try
//    {
//        if (!string.IsNullOrEmpty(IndexTextBox.Text) & int.TryParse(IndexTextBox.Text, out var number))
//        {
//            _address.Index = number;
//            IndexTextBox.BackColor = Color.White;
//            ExceptionToolTip.SetToolTip(IndexTextBox, null);
//            _isValidIndex = true;
//        }
//    }
//    catch (ArgumentException)
//    {
//        IndexTextBox.BackColor = Color.LightPink;
//        ExceptionToolTip.SetToolTip(IndexTextBox, "Шестизначное число!");
//        _isValidIndex = false;
//    }

//    catch (FormatException)
//    {
//        IndexTextBox.BackColor = Color.LightPink;
//        ExceptionToolTip.SetToolTip(IndexTextBox, "Шестизначное число!");
//        _isValidIndex = false;
//    }
//}

//private void CountryTextBox_TextChanged(object sender, EventArgs e)
//{
//    try
//    {
//        if (!string.IsNullOrEmpty(CountryTextBox.Text))
//        {
//            _address.Country = CountryTextBox.Text;
//            CountryTextBox.BackColor = Color.White;
//            ExceptionToolTip.SetToolTip(CountryTextBox, null);
//            _isValidCountry = true;
//        }
//    }
//    catch (ArgumentException)
//    {
//        CountryTextBox.BackColor = Color.LightPink;
//        ExceptionToolTip.SetToolTip(CountryTextBox, "Не более 50 символов!");
//        _isValidCountry = false;
//    }

//    catch (FormatException)
//    {
//        CountryTextBox.BackColor = Color.LightPink;
//        ExceptionToolTip.SetToolTip(CountryTextBox, "Не более 50 символов!");
//        _isValidCountry = false;
//    }
//}

//private void CityTextBox_TextChanged(object sender, EventArgs e)
//{
//    try
//    {
//        if (!string.IsNullOrEmpty(CityTextBox.Text))
//        {
//            _address.City = CityTextBox.Text;
//            CityTextBox.BackColor = Color.White;
//            ExceptionToolTip.SetToolTip(CityTextBox, null);
//            _isValidCity = true;
//        }
//    }
//    catch (ArgumentException)
//    {
//        CityTextBox.BackColor = Color.LightPink;
//        ExceptionToolTip.SetToolTip(CityTextBox, "Не более 50 символов!");
//        _isValidCity = false;
//    }

//    catch (FormatException)
//    {
//        CityTextBox.BackColor = Color.LightPink;
//        ExceptionToolTip.SetToolTip(CityTextBox, "Не более 50 символов!");
//        _isValidCity = false;
//    }
//}

//private void StreetTextBox_TextChanged(object sender, EventArgs e)
//{
//    try
//    {
//        if (!string.IsNullOrEmpty(StreetTextBox.Text))
//        {
//            _address.Street = StreetTextBox.Text;
//            StreetTextBox.BackColor = Color.White;
//            ExceptionToolTip.SetToolTip(StreetTextBox, null);
//            _isValidStreet = true;
//        }
//    }
//    catch (ArgumentException)
//    {
//        StreetTextBox.BackColor = Color.LightPink;
//        ExceptionToolTip.SetToolTip(StreetTextBox, "Не более 100 символов!");
//        _isValidStreet = false;
//    }

//    catch (FormatException)
//    {
//        StreetTextBox.BackColor = Color.LightPink;
//        ExceptionToolTip.SetToolTip(StreetTextBox, "Не более 100 символов!");
//        _isValidStreet = false;
//    }
//}

//private void BuildingTextBox_TextChanged(object sender, EventArgs e)
//{
//    try
//    {
//        if (!string.IsNullOrEmpty(BuildingTextBox.Text))
//        {
//            _address.Building = BuildingTextBox.Text;
//            BuildingTextBox.BackColor = Color.White;
//            ExceptionToolTip.SetToolTip(BuildingTextBox, null);
//            _isValidBuilding = true;
//        }
//    }
//    catch (ArgumentException)
//    {
//        BuildingTextBox.BackColor = Color.LightPink;
//        ExceptionToolTip.SetToolTip(BuildingTextBox, "Не более 10 символов!");
//        _isValidBuilding = false;
//    }

//    catch (FormatException)
//    {
//        BuildingTextBox.BackColor = Color.LightPink;
//        ExceptionToolTip.SetToolTip(BuildingTextBox, "Не более 10 символов!");
//        _isValidBuilding = false;
//    }
//}

//private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
//{
//    try
//    {
//        if (!string.IsNullOrEmpty(ApartmentTextBox.Text))
//        {
//            _address.Apartment = ApartmentTextBox.Text;
//            ApartmentTextBox.BackColor = Color.White;
//            ExceptionToolTip.SetToolTip(ApartmentTextBox, null);
//            _isValidApartment = true;
//        }
//    }
//    catch (ArgumentException)
//    {
//        ApartmentTextBox.BackColor = Color.LightPink;
//        ExceptionToolTip.SetToolTip(ApartmentTextBox, "Не более 10 символов!");
//        _isValidApartment = false;
//    }

//    catch (FormatException)
//    {
//        ApartmentTextBox.BackColor = Color.LightPink;
//        ExceptionToolTip.SetToolTip(ApartmentTextBox, "Не более 10 символов!");
//        _isValidApartment = false;

//    }
//}