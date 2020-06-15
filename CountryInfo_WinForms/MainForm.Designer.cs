namespace CountryInfo_WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.FindCountryButton = new System.Windows.Forms.Button();
            this.ShowFromDBButton = new System.Windows.Forms.Button();
            this.CountryData = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Population = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CountryData)).BeginInit();
            this.SuspendLayout();
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryTextBox.Location = new System.Drawing.Point(13, 13);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(243, 29);
            this.CountryTextBox.TabIndex = 0;
            // 
            // FindCountryButton
            // 
            this.FindCountryButton.Location = new System.Drawing.Point(262, 12);
            this.FindCountryButton.Name = "FindCountryButton";
            this.FindCountryButton.Size = new System.Drawing.Size(115, 30);
            this.FindCountryButton.TabIndex = 1;
            this.FindCountryButton.Text = "Поиск страны";
            this.FindCountryButton.UseVisualStyleBackColor = true;
            this.FindCountryButton.Click += new System.EventHandler(this.FindCountryButton_Click);
            // 
            // ShowFromDBButton
            // 
            this.ShowFromDBButton.Location = new System.Drawing.Point(386, 12);
            this.ShowFromDBButton.Name = "ShowFromDBButton";
            this.ShowFromDBButton.Size = new System.Drawing.Size(154, 30);
            this.ShowFromDBButton.TabIndex = 2;
            this.ShowFromDBButton.Text = "Вывод всех стран из БД";
            this.ShowFromDBButton.UseVisualStyleBackColor = true;
            this.ShowFromDBButton.Click += new System.EventHandler(this.ShowFromDBButton_Click);
            // 
            // CountryData
            // 
            this.CountryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CountryData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Code,
            this.Capital,
            this.Area,
            this.Population,
            this.Region});
            this.CountryData.Location = new System.Drawing.Point(13, 95);
            this.CountryData.Name = "CountryData";
            this.CountryData.Size = new System.Drawing.Size(527, 283);
            this.CountryData.TabIndex = 3;
            // 
            // Name
            // 
            this.Name.HeaderText = "Название";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Code
            // 
            this.Code.HeaderText = "Код страны";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 30;
            // 
            // Capital
            // 
            this.Capital.HeaderText = "Столица";
            this.Capital.Name = "Capital";
            this.Capital.ReadOnly = true;
            // 
            // Area
            // 
            this.Area.HeaderText = "Площадь";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            this.Area.Width = 50;
            // 
            // Population
            // 
            this.Population.HeaderText = "Население";
            this.Population.Name = "Population";
            this.Population.ReadOnly = true;
            // 
            // Region
            // 
            this.Region.HeaderText = "Регион";
            this.Region.Name = "Region";
            this.Region.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 390);
            this.Controls.Add(this.CountryData);
            this.Controls.Add(this.ShowFromDBButton);
            this.Controls.Add(this.FindCountryButton);
            this.Controls.Add(this.CountryTextBox);
            this.Text = "Информация о странах";
            ((System.ComponentModel.ISupportInitialize)(this.CountryData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.Button FindCountryButton;
        private System.Windows.Forms.Button ShowFromDBButton;
        private System.Windows.Forms.DataGridView CountryData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capital;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Population;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
    }
}

