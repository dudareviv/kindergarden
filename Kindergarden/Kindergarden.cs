using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kindergarden
{
    /// <summary>
    /// Класс, описывающий Детский сад
    /// </summary>
    public class Kindergarden
    {
        /// <summary>
        /// Название
        /// </summary>
        public string name;

        /// <summary>
        /// Номер
        /// </summary>
        public int number;

        /// <summary>
        /// Количество детей
        /// </summary>
        public int childrenCount;

        /// <summary>
        /// Район города
        /// </summary>
        public string district;

        /// <summary>
        /// Плата за месяц
        /// </summary>
        public float payment;

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="name">Название детсада</param>
        /// <param name="number">Номер детсада</param>
        /// <param name="childrenCount">Количество детей, на которое рассчитан детсад</param>
        /// <param name="district">Район города, где находится детсад</param>
        /// <param name="payment">Плата за месяц</param>
        public Kindergarden(string name, int number, int childrenCount, string district, float payment)
        {
            this.name = name;
            this.number = number;
            this.childrenCount = childrenCount;
            this.district = district;
            this.payment = payment;
        }

        /// <summary>
        /// Перегрузка конструктора
        /// </summary>
        /// <param name="data"></param>
        public Kindergarden(string[] data)
        {
            if (data.Length != 5)
            {
                throw new System.Exception("Неверный формат данных для записи.");
            }

            this.name = data[0];
            this.number = Convert.ToInt32(data[1]);
            this.childrenCount = Convert.ToInt32(data[2]);
            this.district = data[3];
            this.payment = Convert.ToSingle(data[4]);
        }

        /// <summary>
        /// Преобразует данные в массив строк.
        /// </summary>
        /// <returns>Массив типа строка для строки в таблице</returns>
        public string[] ToGridRow()
        {
            return new string[]{
                name,
                number.ToString(),
                childrenCount.ToString(),
                district,
                payment.ToString()
            };
        }
    }
}
