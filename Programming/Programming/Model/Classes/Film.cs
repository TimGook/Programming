using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Film
    {
        private string _name;
        private int _runnungTimeInMinutes;

        // Дата выпуска от 1900 года до текущего года
        //
        private int _releaseDate;

        private string _genre;
        
        // Рейтинг от 0 до 10
        private double _rating; 
    }
}
