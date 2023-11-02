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
        public Address Address
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
                Address.Index = value.Index;
                Address.Country = value.Country;
                Address.City = value.City;
                Address.Street = value.Street;
                Address.Building = value.Building;
                Address.Apartment = value.Apartment;
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
                if (!string.IsNullOrEmpty(IndexTextBox.Text) & int.TryParse(IndexTextBox.Text, out var number))
                {
                    _address.Index = number;
                    IndexTextBox.BackColor = Color.White;
                    _isValidIndex = true;
                }
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
                if (!string.IsNullOrEmpty(CountryTextBox.Text))
                {
                    _address.Country = CountryTextBox.Text;
                    CountryTextBox.BackColor = Color.White;
                    _isValidCountry = true;
                }
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
                if (!string.IsNullOrEmpty(CityTextBox.Text))
                {
                    _address.City = CityTextBox.Text;
                    CityTextBox.BackColor = Color.White;
                    _isValidCity = true;
                }
            }
            catch (ArgumentException)
            {
                CityTextBox.BackColor = Color.LightPink;
                _isValidCity = false;
            }

            catch (FormatException)
            {
                CityTextBox.BackColor = Color.LightPink;
                _isValidCity = false;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(StreetTextBox.Text))
                {
                    _address.Street = StreetTextBox.Text;
                    StreetTextBox.BackColor = Color.White;
                    _isValidStreet = true;
                }
            }
            catch (ArgumentException)
            {
                StreetTextBox.BackColor = Color.LightPink;
                _isValidStreet = false;
            }

            catch (FormatException)
            {
                StreetTextBox.BackColor = Color.LightPink;
                _isValidStreet = false;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(BuildingTextBox.Text))
                {
                    _address.Building = BuildingTextBox.Text;
                    BuildingTextBox.BackColor = Color.White;
                    _isValidBuilding = true;
                }
            }
            catch (ArgumentException)
            {
                BuildingTextBox.BackColor = Color.LightPink;
                _isValidBuilding = false;
            }

            catch (FormatException)
            {
                BuildingTextBox.BackColor = Color.LightPink;
                _isValidBuilding = false;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(ApartmentTextBox.Text))
                {
                    _address.Apartment = ApartmentTextBox.Text;
                    ApartmentTextBox.BackColor = Color.White;
                    _isValidApartment = true;
                }
            }
            catch (ArgumentException)
            {
                ApartmentTextBox.BackColor = Color.LightPink;
                _isValidApartment = false;
            }

            catch (FormatException)
            {
                ApartmentTextBox.BackColor = Color.LightPink;
                _isValidApartment = false;

            }
        }

        /// <summary>
        /// Функция очистки значений всех <see cref="TextBoxBase"/>.
        /// </summary>
        public void AddressClear()
        {
            IndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();
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