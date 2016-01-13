using System.Collections.Generic;

namespace Kindergarden
{
    class KindergardenDataProvider
    {
        private List<Kindergarden> items = new List<Kindergarden>();

        /// <summary>
        /// Вернет все элементы в коллекции.
        /// </summary>
        /// <returns></returns>
        public List<Kindergarden> GetItems()
        {
            return items;
        }

        /// <summary>
        /// Задает элементы.
        /// </summary>
        /// <param name="items"></param>
        public void SetItems(List<Kindergarden> items)
        {
            this.items = items;
        }

        /// <summary>
        /// Чистит список.
        /// </summary>
        public void Clear()
        {
            this.items = new List<Kindergarden>();
        }

        /// <summary>
        /// Вернет элемент по указанному индексу.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Kindergarden GetItem(int index) {
            return items[index];
        }

        /// <summary>
        /// Добавление нового элемента.
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(Kindergarden item)
        {
            items.Add(item);
        }

        /// <summary>
        /// Перегрузка добавления элемента.
        /// </summary>
        /// <param name="data"></param>
        public void AddItem(string[] data)
        {
            items.Add(new Kindergarden(data));
        }

        /// <summary>
        /// Вернет результат проверки существования элемента в указанном индексе.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool HasItem(int index)
        {
            return items[index] != null;
        }

        /// <summary>
        /// Удаляет элемент по его индексу.
        /// </summary>
        /// <param name="index"></param>
        public void RemoveItem(int index)
        {
            items.RemoveAt(index);
        }

        /// <summary>
        /// Сортирует элементы по номеру в указанном порядке.
        /// </summary>
        /// <param name="asc"></param>
        public void SortByNumber(bool asc)
        {
            if (asc)
            {
                items.Sort((x, y) => x.number.CompareTo(y.number));
            }
            else
            {
                items.Sort((x, y) => y.number.CompareTo(x.number));
            }

        }
    }
}
