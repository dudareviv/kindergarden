using System;
using System.IO;
using System.Windows.Forms;

namespace Kindergarden
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Коллекция записей типа Детский сад.
        /// </summary>
        private KindergardenDataProvider dataProvider = new KindergardenDataProvider();

        /// <summary>
        /// Конструктор класса MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeColumnNames();
            InitializeRowsData();
        }

        /// <summary>
        /// Инициализация колонок таблицы.
        /// </summary>
        private void InitializeColumnNames()
        {
            this.KindergardenDataView.ColumnCount = 5;

            this.KindergardenDataView.Columns[0].Name = "Наименование";
            this.KindergardenDataView.Columns[1].Name = "Номер";
            this.KindergardenDataView.Columns[2].Name = "Количество детей";
            this.KindergardenDataView.Columns[3].Name = "Район";
            this.KindergardenDataView.Columns[4].Name = "Стоимость";
        }

        /// <summary>
        /// Сброс полей формы и таблицы, вывод данных в таблицу из коллекции.
        /// </summary>
        private void InitializeRowsData()
        {
            NameField.Clear();
            NumberField.Value = NumberField.Minimum;
            ChirdrenCountField.Value = ChirdrenCountField.Minimum;
            DisctrictField.Clear();
            PaymentField.Value = PaymentField.Minimum;

            rowIndex = -1;

            SaveButton.Text = "Добавить";
            DeleteButton.Enabled = false;
            this.KindergardenDataView.Rows.Clear();

            foreach (Kindergarden item in dataProvider.GetItems())
            {
                if (!FilterCheckbox.Checked || FilterField.Value < item.childrenCount)
                {
                    this.KindergardenDataView.Rows.Add(item.ToGridRow());
                }
            }
        }

        /// <summary>
        /// Обработчик клика по кнопке Добавить/Сохранить.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Kindergarden item;

                if (rowIndex != -1 && dataProvider.HasItem(rowIndex))
                {
                    item = dataProvider.GetItem(rowIndex);

                    item.name = NameField.Text;
                    item.number = (int)NumberField.Value;
                    item.childrenCount = (int)ChirdrenCountField.Value;
                    item.district = DisctrictField.Text;
                    item.payment = (float)PaymentField.Value;
                }
                else
                {
                    item = new Kindergarden(NameField.Text,
                        (int)NumberField.Value,
                        (int)ChirdrenCountField.Value,
                        DisctrictField.Text,
                        (float)PaymentField.Value);

                    dataProvider.AddItem(item);
                }

                InitializeRowsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла ошибка");
            }
        }


        /// <summary>
        /// Показывает в каком направлении сортировать.
        /// </summary>
        private bool sortAsc = false;

        /// <summary>
        /// Обработка клика по кнопке "Сортировать".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortButton_Click(object sender, EventArgs e)
        {
            dataProvider.SortByNumber(sortAsc);

            sortAsc = !sortAsc;

            InitializeRowsData();
        }

        /// <summary>
        /// Обработка изменения значения флага "Фильтр".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            InitializeRowsData();
        }

        /// <summary>
        /// Обработка изменения значения поля "Фильтр".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterField_ValueChanged(object sender, EventArgs e)
        {
            InitializeRowsData();
        }

        /// <summary>
        /// Номер выбранной строки.
        /// </summary>
        private int rowIndex = -1;

        /// <summary>
        /// Обработка клика по строке в таблице.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KindergardenDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Не обрабатываем первую строку, т.к. это заголовок
            if(e.RowIndex == -1)
            {
                return;
            }

            SaveButton.Text = "Сохранить";
            DeleteButton.Enabled = true;

            rowIndex = e.RowIndex;
            Kindergarden item = dataProvider.GetItem(rowIndex);

            NameField.Text = item.name;
            NumberField.Value = item.number;
            ChirdrenCountField.Value = item.childrenCount;
            DisctrictField.Text = item.district;
            PaymentField.Value = (decimal)item.payment;
        }

        /// <summary>
        /// Обработка клика по кнопке "Удалить".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            dataProvider.RemoveItem(rowIndex);
            InitializeRowsData();
        }

        /// <summary>
        /// Обработка клика по кнопке "Загрузить файл".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataLoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(fileDialog.FileName))
                    {
                        dataProvider.Clear();
                        String line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            dataProvider.AddItem(line.Split('\t'));
                        }
                        sr.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось загрузить файл. Ошибка:" + ex.Message);
                }
            }

            InitializeRowsData();
        }

        /// <summary>
        /// Обработка клика по кнопке "Сохранить файл".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataSaveButton_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog fileDialog = new SaveFileDialog();

            fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = fileDialog.OpenFile()) != null)
                    {
                        StreamWriter sw = new StreamWriter(myStream);

                        foreach (Kindergarden item in dataProvider.GetItems())
                        {
                            sw.WriteLine(String.Join("\t", item.ToGridRow()));
                        }

                        sw.Close();
                        myStream.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось сохранить файл. Ошибка:" + ex.Message);
                }
            }
        }
    }
}