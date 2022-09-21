namespace ListOfFlights.View
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
            this.FlightsListBox = new System.Windows.Forms.ListBox();
            this.DeparturePointTextBox = new System.Windows.Forms.TextBox();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.DepartureTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FlightTimeTextBox = new System.Windows.Forms.TextBox();
            this.FlightTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.FlightTimeLabel = new System.Windows.Forms.Label();
            this.DepartureTimeLabel = new System.Windows.Forms.Label();
            this.FlightTypeLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FlightsListBox
            // 
            this.FlightsListBox.FormattingEnabled = true;
            this.FlightsListBox.ItemHeight = 16;
            this.FlightsListBox.Location = new System.Drawing.Point(12, 12);
            this.FlightsListBox.Name = "FlightsListBox";
            this.FlightsListBox.Size = new System.Drawing.Size(303, 356);
            this.FlightsListBox.TabIndex = 0;
            // 
            // DeparturePointTextBox
            // 
            this.DeparturePointTextBox.Location = new System.Drawing.Point(479, 15);
            this.DeparturePointTextBox.MaxLength = 100;
            this.DeparturePointTextBox.Name = "DeparturePointTextBox";
            this.DeparturePointTextBox.Size = new System.Drawing.Size(227, 22);
            this.DeparturePointTextBox.TabIndex = 1;
            this.DeparturePointTextBox.TextChanged += new System.EventHandler(this.DeparturePointTextBox_TextChanged);
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.Location = new System.Drawing.Point(476, 64);
            this.DestinationTextBox.MaxLength = 100;
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(230, 22);
            this.DestinationTextBox.TabIndex = 2;
            this.DestinationTextBox.TextChanged += new System.EventHandler(this.DestinationTextBox_TextChanged);
            // 
            // DepartureTimeDateTimePicker
            // 
            this.DepartureTimeDateTimePicker.Location = new System.Drawing.Point(431, 121);
            this.DepartureTimeDateTimePicker.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.DepartureTimeDateTimePicker.MinDate = new System.DateTime(2022, 9, 7, 0, 0, 0, 0);
            this.DepartureTimeDateTimePicker.Name = "DepartureTimeDateTimePicker";
            this.DepartureTimeDateTimePicker.Size = new System.Drawing.Size(321, 22);
            this.DepartureTimeDateTimePicker.TabIndex = 3;
            // 
            // FlightTimeTextBox
            // 
            this.FlightTimeTextBox.Location = new System.Drawing.Point(431, 172);
            this.FlightTimeTextBox.Name = "FlightTimeTextBox";
            this.FlightTimeTextBox.Size = new System.Drawing.Size(321, 22);
            this.FlightTimeTextBox.TabIndex = 4;
            this.FlightTimeTextBox.TextChanged += new System.EventHandler(this.FlightTimeTextBox_TextChanged);
            // 
            // FlightTypeComboBox
            // 
            this.FlightTypeComboBox.FormattingEnabled = true;
            this.FlightTypeComboBox.Location = new System.Drawing.Point(431, 234);
            this.FlightTypeComboBox.Name = "FlightTypeComboBox";
            this.FlightTypeComboBox.Size = new System.Drawing.Size(321, 24);
            this.FlightTypeComboBox.TabIndex = 5;
            this.FlightTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.FlightTypeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Место отправления";
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Location = new System.Drawing.Point(328, 70);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(130, 16);
            this.DestinationLabel.TabIndex = 7;
            this.DestinationLabel.Text = "Место назначения";
            // 
            // FlightTimeLabel
            // 
            this.FlightTimeLabel.AutoSize = true;
            this.FlightTimeLabel.Location = new System.Drawing.Point(327, 178);
            this.FlightTimeLabel.Name = "FlightTimeLabel";
            this.FlightTimeLabel.Size = new System.Drawing.Size(98, 16);
            this.FlightTimeLabel.TabIndex = 8;
            this.FlightTimeLabel.Text = "Время полёта";
            // 
            // DepartureTimeLabel
            // 
            this.DepartureTimeLabel.AutoSize = true;
            this.DepartureTimeLabel.Location = new System.Drawing.Point(326, 126);
            this.DepartureTimeLabel.Name = "DepartureTimeLabel";
            this.DepartureTimeLabel.Size = new System.Drawing.Size(99, 16);
            this.DepartureTimeLabel.TabIndex = 9;
            this.DepartureTimeLabel.Text = "Время вылета";
            // 
            // FlightTypeLabel
            // 
            this.FlightTypeLabel.AutoSize = true;
            this.FlightTypeLabel.Location = new System.Drawing.Point(342, 242);
            this.FlightTypeLabel.Name = "FlightTypeLabel";
            this.FlightTypeLabel.Size = new System.Drawing.Size(83, 16);
            this.FlightTypeLabel.TabIndex = 10;
            this.FlightTypeLabel.Text = "Тип вылета";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 394);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(107, 44);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(158, 394);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(105, 44);
            this.RemoveButton.TabIndex = 12;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.FlightTypeLabel);
            this.Controls.Add(this.DepartureTimeLabel);
            this.Controls.Add(this.FlightTimeLabel);
            this.Controls.Add(this.DestinationLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FlightTypeComboBox);
            this.Controls.Add(this.FlightTimeTextBox);
            this.Controls.Add(this.DepartureTimeDateTimePicker);
            this.Controls.Add(this.DestinationTextBox);
            this.Controls.Add(this.DeparturePointTextBox);
            this.Controls.Add(this.FlightsListBox);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "ListOfFlights";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FlightsListBox;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.DateTimePicker DepartureTimeDateTimePicker;
        private System.Windows.Forms.TextBox FlightTimeTextBox;
        private System.Windows.Forms.ComboBox FlightTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.Label FlightTimeLabel;
        private System.Windows.Forms.Label DepartureTimeLabel;
        private System.Windows.Forms.Label FlightTypeLabel;
        private System.Windows.Forms.TextBox DeparturePointTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
    }
}

