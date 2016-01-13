namespace Kindergarden
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SaveButton = new System.Windows.Forms.Button();
            this.NameField = new System.Windows.Forms.TextBox();
            this.NumberField = new System.Windows.Forms.NumericUpDown();
            this.ChirdrenCountField = new System.Windows.Forms.NumericUpDown();
            this.DisctrictField = new System.Windows.Forms.TextBox();
            this.PaymentField = new System.Windows.Forms.NumericUpDown();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ChildrenCountLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.DistrictLabel = new System.Windows.Forms.Label();
            this.PaymentLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.KindergardenDataView = new System.Windows.Forms.DataGridView();
            this.SortButton = new System.Windows.Forms.Button();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.FilterCheckbox = new System.Windows.Forms.CheckBox();
            this.FilterField = new System.Windows.Forms.NumericUpDown();
            this.DataLoadButton = new System.Windows.Forms.Button();
            this.DataSaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChirdrenCountField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KindergardenDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterField)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(593, 22);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(110, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Добавить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(15, 25);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(153, 20);
            this.NameField.TabIndex = 1;
            // 
            // NumberField
            // 
            this.NumberField.Location = new System.Drawing.Point(174, 25);
            this.NumberField.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumberField.Name = "NumberField";
            this.NumberField.Size = new System.Drawing.Size(65, 20);
            this.NumberField.TabIndex = 2;
            // 
            // ChirdrenCountField
            // 
            this.ChirdrenCountField.Location = new System.Drawing.Point(245, 25);
            this.ChirdrenCountField.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ChirdrenCountField.Name = "ChirdrenCountField";
            this.ChirdrenCountField.Size = new System.Drawing.Size(95, 20);
            this.ChirdrenCountField.TabIndex = 3;
            // 
            // DisctrictField
            // 
            this.DisctrictField.Location = new System.Drawing.Point(346, 24);
            this.DisctrictField.Name = "DisctrictField";
            this.DisctrictField.Size = new System.Drawing.Size(150, 20);
            this.DisctrictField.TabIndex = 4;
            // 
            // PaymentField
            // 
            this.PaymentField.DecimalPlaces = 2;
            this.PaymentField.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PaymentField.Location = new System.Drawing.Point(502, 24);
            this.PaymentField.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PaymentField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PaymentField.Name = "PaymentField";
            this.PaymentField.Size = new System.Drawing.Size(85, 20);
            this.PaymentField.TabIndex = 5;
            this.PaymentField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PaymentField.ThousandsSeparator = true;
            this.PaymentField.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(83, 13);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Наименование";
            // 
            // ChildrenCountLabel
            // 
            this.ChildrenCountLabel.AutoSize = true;
            this.ChildrenCountLabel.Location = new System.Drawing.Point(242, 9);
            this.ChildrenCountLabel.Name = "ChildrenCountLabel";
            this.ChildrenCountLabel.Size = new System.Drawing.Size(98, 13);
            this.ChildrenCountLabel.TabIndex = 7;
            this.ChildrenCountLabel.Text = "Количество детей";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(171, 9);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(68, 13);
            this.NumberLabel.TabIndex = 8;
            this.NumberLabel.Text = "Номер сада";
            // 
            // DistrictLabel
            // 
            this.DistrictLabel.AutoSize = true;
            this.DistrictLabel.Location = new System.Drawing.Point(343, 8);
            this.DistrictLabel.Name = "DistrictLabel";
            this.DistrictLabel.Size = new System.Drawing.Size(76, 13);
            this.DistrictLabel.TabIndex = 9;
            this.DistrictLabel.Text = "Район города";
            // 
            // PaymentLabel
            // 
            this.PaymentLabel.AutoSize = true;
            this.PaymentLabel.Location = new System.Drawing.Point(499, 8);
            this.PaymentLabel.Name = "PaymentLabel";
            this.PaymentLabel.Size = new System.Drawing.Size(88, 13);
            this.PaymentLabel.TabIndex = 10;
            this.PaymentLabel.Text = "Плата за месяц";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(752, 22);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(80, 23);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // KindergardenDataView
            // 
            this.KindergardenDataView.AllowUserToAddRows = false;
            this.KindergardenDataView.AllowUserToDeleteRows = false;
            this.KindergardenDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KindergardenDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.KindergardenDataView.Location = new System.Drawing.Point(15, 50);
            this.KindergardenDataView.Name = "KindergardenDataView";
            this.KindergardenDataView.Size = new System.Drawing.Size(572, 499);
            this.KindergardenDataView.TabIndex = 0;
            this.KindergardenDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KindergardenDataView_CellContentClick);
            // 
            // SortButton
            // 
            this.SortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortButton.Location = new System.Drawing.Point(593, 246);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(239, 98);
            this.SortButton.TabIndex = 12;
            this.SortButton.Text = "Сортировать";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Location = new System.Drawing.Point(593, 50);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(47, 13);
            this.FilterLabel.TabIndex = 13;
            this.FilterLabel.Text = "Фильтр";
            // 
            // FilterCheckbox
            // 
            this.FilterCheckbox.AutoSize = true;
            this.FilterCheckbox.Location = new System.Drawing.Point(596, 69);
            this.FilterCheckbox.Name = "FilterCheckbox";
            this.FilterCheckbox.Size = new System.Drawing.Size(15, 14);
            this.FilterCheckbox.TabIndex = 14;
            this.FilterCheckbox.UseVisualStyleBackColor = true;
            this.FilterCheckbox.CheckedChanged += new System.EventHandler(this.FilterCheckbox_CheckedChanged);
            // 
            // FilterField
            // 
            this.FilterField.Location = new System.Drawing.Point(617, 66);
            this.FilterField.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.FilterField.Name = "FilterField";
            this.FilterField.Size = new System.Drawing.Size(86, 20);
            this.FilterField.TabIndex = 15;
            this.FilterField.ValueChanged += new System.EventHandler(this.FilterField_ValueChanged);
            // 
            // DataLoadButton
            // 
            this.DataLoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataLoadButton.Location = new System.Drawing.Point(593, 435);
            this.DataLoadButton.Name = "DataLoadButton";
            this.DataLoadButton.Size = new System.Drawing.Size(239, 54);
            this.DataLoadButton.TabIndex = 16;
            this.DataLoadButton.Text = "Загрузить файл";
            this.DataLoadButton.UseVisualStyleBackColor = true;
            this.DataLoadButton.Click += new System.EventHandler(this.DataLoadButton_Click);
            // 
            // DataSaveButton
            // 
            this.DataSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataSaveButton.Location = new System.Drawing.Point(593, 495);
            this.DataSaveButton.Name = "DataSaveButton";
            this.DataSaveButton.Size = new System.Drawing.Size(239, 54);
            this.DataSaveButton.TabIndex = 17;
            this.DataSaveButton.Text = "Сохранить файл";
            this.DataSaveButton.UseVisualStyleBackColor = true;
            this.DataSaveButton.Click += new System.EventHandler(this.DataSaveButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 561);
            this.Controls.Add(this.DataSaveButton);
            this.Controls.Add(this.DataLoadButton);
            this.Controls.Add(this.FilterField);
            this.Controls.Add(this.FilterCheckbox);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.KindergardenDataView);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PaymentLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ChirdrenCountField);
            this.Controls.Add(this.PaymentField);
            this.Controls.Add(this.NumberField);
            this.Controls.Add(this.DistrictLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.ChildrenCountLabel);
            this.Controls.Add(this.DisctrictField);
            this.Name = "MainForm";
            this.Text = "Детские сады";
            ((System.ComponentModel.ISupportInitialize)(this.NumberField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChirdrenCountField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KindergardenDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.NumericUpDown NumberField;
        private System.Windows.Forms.NumericUpDown ChirdrenCountField;
        private System.Windows.Forms.TextBox DisctrictField;
        private System.Windows.Forms.NumericUpDown PaymentField;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ChildrenCountLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label DistrictLabel;
        private System.Windows.Forms.Label PaymentLabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridView KindergardenDataView;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.CheckBox FilterCheckbox;
        private System.Windows.Forms.NumericUpDown FilterField;
        private System.Windows.Forms.Button DataLoadButton;
        private System.Windows.Forms.Button DataSaveButton;
    }
}

