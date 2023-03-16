namespace FlightsList.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FlightsListBox = new System.Windows.Forms.ListBox();
            this.DeparturePointTextBox = new System.Windows.Forms.TextBox();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.DepartureTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FlightTimeTextBox = new System.Windows.Forms.TextBox();
            this.FlightTypeComboBox = new System.Windows.Forms.ComboBox();
            this.DeparturePointLabel = new System.Windows.Forms.Label();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.FlightTimeLabel = new System.Windows.Forms.Label();
            this.DepartureTimeLabel = new System.Windows.Forms.Label();
            this.FlightTypeLabel = new System.Windows.Forms.Label();
            this.SelectedFlightPanel = new System.Windows.Forms.Panel();
            this.SelectedFlightLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SelectedFlightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlightsListBox
            // 
            this.FlightsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FlightsListBox.FormattingEnabled = true;
            this.FlightsListBox.ItemHeight = 16;
            this.FlightsListBox.Location = new System.Drawing.Point(14, 12);
            this.FlightsListBox.Name = "FlightsListBox";
            this.FlightsListBox.Size = new System.Drawing.Size(297, 468);
            this.FlightsListBox.TabIndex = 0;
            this.FlightsListBox.SelectedIndexChanged += new System.EventHandler(this.FlightsListBox_SelectedIndexChanged);
            // 
            // DeparturePointTextBox
            // 
            this.DeparturePointTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeparturePointTextBox.Location = new System.Drawing.Point(162, 26);
            this.DeparturePointTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.DeparturePointTextBox.MaxLength = 3000;
            this.DeparturePointTextBox.Name = "DeparturePointTextBox";
            this.DeparturePointTextBox.Size = new System.Drawing.Size(371, 22);
            this.DeparturePointTextBox.TabIndex = 1;
            this.DeparturePointTextBox.TextChanged += new System.EventHandler(this.DeparturePointTextBox_TextChanged);
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationTextBox.Location = new System.Drawing.Point(162, 55);
            this.DestinationTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.DestinationTextBox.MaxLength = 3000;
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(371, 22);
            this.DestinationTextBox.TabIndex = 2;
            this.DestinationTextBox.TextChanged += new System.EventHandler(this.DestinationTextBox_TextChanged);
            // 
            // DepartureTimeDateTimePicker
            // 
            this.DepartureTimeDateTimePicker.Location = new System.Drawing.Point(162, 84);
            this.DepartureTimeDateTimePicker.Margin = new System.Windows.Forms.Padding(10);
            this.DepartureTimeDateTimePicker.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.DepartureTimeDateTimePicker.MinDate = new System.DateTime(2023, 3, 9, 0, 0, 0, 0);
            this.DepartureTimeDateTimePicker.Name = "DepartureTimeDateTimePicker";
            this.DepartureTimeDateTimePicker.Size = new System.Drawing.Size(194, 22);
            this.DepartureTimeDateTimePicker.TabIndex = 3;
            this.DepartureTimeDateTimePicker.Value = new System.DateTime(2023, 3, 9, 23, 55, 46, 0);
            this.DepartureTimeDateTimePicker.ValueChanged += new System.EventHandler(this.DepartureTimeDateTimePicker_ValueChanged);
            // 
            // FlightTimeTextBox
            // 
            this.FlightTimeTextBox.Location = new System.Drawing.Point(162, 114);
            this.FlightTimeTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.FlightTimeTextBox.Name = "FlightTimeTextBox";
            this.FlightTimeTextBox.Size = new System.Drawing.Size(119, 22);
            this.FlightTimeTextBox.TabIndex = 4;
            this.FlightTimeTextBox.TextChanged += new System.EventHandler(this.FlightTimeTextBox_TextChanged);
            // 
            // FlightTypeComboBox
            // 
            this.FlightTypeComboBox.FormattingEnabled = true;
            this.FlightTypeComboBox.Location = new System.Drawing.Point(162, 144);
            this.FlightTypeComboBox.Margin = new System.Windows.Forms.Padding(10);
            this.FlightTypeComboBox.Name = "FlightTypeComboBox";
            this.FlightTypeComboBox.Size = new System.Drawing.Size(119, 24);
            this.FlightTypeComboBox.TabIndex = 5;
            this.FlightTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.FlightTypeComboBox_SelectedIndexChanged);
            this.FlightTypeComboBox.TextChanged += new System.EventHandler(this.FlightTypeComboBox_TextChanged);
            // 
            // DeparturePointLabel
            // 
            this.DeparturePointLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeparturePointLabel.AutoSize = true;
            this.DeparturePointLabel.Location = new System.Drawing.Point(10, 26);
            this.DeparturePointLabel.Margin = new System.Windows.Forms.Padding(10);
            this.DeparturePointLabel.Name = "DeparturePointLabel";
            this.DeparturePointLabel.Padding = new System.Windows.Forms.Padding(3);
            this.DeparturePointLabel.Size = new System.Drawing.Size(146, 22);
            this.DeparturePointLabel.TabIndex = 6;
            this.DeparturePointLabel.Text = "Место отправления:";
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Location = new System.Drawing.Point(17, 55);
            this.DestinationLabel.Margin = new System.Windows.Forms.Padding(10);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Padding = new System.Windows.Forms.Padding(3);
            this.DestinationLabel.Size = new System.Drawing.Size(139, 22);
            this.DestinationLabel.TabIndex = 7;
            this.DestinationLabel.Text = "Место назначения:";
            // 
            // FlightTimeLabel
            // 
            this.FlightTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlightTimeLabel.AutoSize = true;
            this.FlightTimeLabel.Location = new System.Drawing.Point(49, 114);
            this.FlightTimeLabel.Margin = new System.Windows.Forms.Padding(10);
            this.FlightTimeLabel.Name = "FlightTimeLabel";
            this.FlightTimeLabel.Padding = new System.Windows.Forms.Padding(3);
            this.FlightTimeLabel.Size = new System.Drawing.Size(107, 22);
            this.FlightTimeLabel.TabIndex = 8;
            this.FlightTimeLabel.Text = "Время полёта:";
            // 
            // DepartureTimeLabel
            // 
            this.DepartureTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartureTimeLabel.AutoSize = true;
            this.DepartureTimeLabel.Location = new System.Drawing.Point(48, 84);
            this.DepartureTimeLabel.Margin = new System.Windows.Forms.Padding(10);
            this.DepartureTimeLabel.Name = "DepartureTimeLabel";
            this.DepartureTimeLabel.Padding = new System.Windows.Forms.Padding(3);
            this.DepartureTimeLabel.Size = new System.Drawing.Size(108, 22);
            this.DepartureTimeLabel.TabIndex = 9;
            this.DepartureTimeLabel.Text = "Время вылета:";
            // 
            // FlightTypeLabel
            // 
            this.FlightTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlightTypeLabel.AutoSize = true;
            this.FlightTypeLabel.Location = new System.Drawing.Point(64, 147);
            this.FlightTypeLabel.Margin = new System.Windows.Forms.Padding(10);
            this.FlightTypeLabel.Name = "FlightTypeLabel";
            this.FlightTypeLabel.Padding = new System.Windows.Forms.Padding(3);
            this.FlightTypeLabel.Size = new System.Drawing.Size(92, 22);
            this.FlightTypeLabel.TabIndex = 10;
            this.FlightTypeLabel.Text = "Тип вылета:";
            // 
            // SelectedFlightPanel
            // 
            this.SelectedFlightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedFlightPanel.Controls.Add(this.SelectedFlightLabel);
            this.SelectedFlightPanel.Controls.Add(this.DeparturePointLabel);
            this.SelectedFlightPanel.Controls.Add(this.DeparturePointTextBox);
            this.SelectedFlightPanel.Controls.Add(this.DestinationTextBox);
            this.SelectedFlightPanel.Controls.Add(this.FlightTypeLabel);
            this.SelectedFlightPanel.Controls.Add(this.DepartureTimeDateTimePicker);
            this.SelectedFlightPanel.Controls.Add(this.DepartureTimeLabel);
            this.SelectedFlightPanel.Controls.Add(this.FlightTimeTextBox);
            this.SelectedFlightPanel.Controls.Add(this.FlightTimeLabel);
            this.SelectedFlightPanel.Controls.Add(this.FlightTypeComboBox);
            this.SelectedFlightPanel.Controls.Add(this.DestinationLabel);
            this.SelectedFlightPanel.Location = new System.Drawing.Point(321, 12);
            this.SelectedFlightPanel.Margin = new System.Windows.Forms.Padding(5);
            this.SelectedFlightPanel.Name = "SelectedFlightPanel";
            this.SelectedFlightPanel.Size = new System.Drawing.Size(543, 180);
            this.SelectedFlightPanel.TabIndex = 13;
            // 
            // SelectedFlightLabel
            // 
            this.SelectedFlightLabel.AutoSize = true;
            this.SelectedFlightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedFlightLabel.Location = new System.Drawing.Point(3, 0);
            this.SelectedFlightLabel.Name = "SelectedFlightLabel";
            this.SelectedFlightLabel.Size = new System.Drawing.Size(119, 18);
            this.SelectedFlightLabel.TabIndex = 14;
            this.SelectedFlightLabel.Text = "Selected Flight";
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddButton.Image = global::FlightsList.Properties.Resources.add_24x24;
            this.AddButton.Location = new System.Drawing.Point(14, 486);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(34, 35);
            this.AddButton.TabIndex = 11;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButtonClick);
            this.AddButton.MouseEnter += new System.EventHandler(this.AddButton_MouseEnter);
            this.AddButton.MouseLeave += new System.EventHandler(this.AddButton_MouseLeave);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RemoveButton.FlatAppearance.BorderSize = 0;
            this.RemoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.RemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveButton.Image")));
            this.RemoveButton.Location = new System.Drawing.Point(54, 486);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(34, 35);
            this.RemoveButton.TabIndex = 12;
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButtonClick);
            this.RemoveButton.MouseEnter += new System.EventHandler(this.RemoveButton_MouseEnter);
            this.RemoveButton.MouseLeave += new System.EventHandler(this.RemoveButton_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 527);
            this.Controls.Add(this.SelectedFlightPanel);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.FlightsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 300);
            this.Name = "MainForm";
            this.Text = "FlightsList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.SelectedFlightPanel.ResumeLayout(false);
            this.SelectedFlightPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FlightsListBox;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.DateTimePicker DepartureTimeDateTimePicker;
        private System.Windows.Forms.TextBox FlightTimeTextBox;
        private System.Windows.Forms.ComboBox FlightTypeComboBox;
        private System.Windows.Forms.Label DeparturePointLabel;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.Label FlightTimeLabel;
        private System.Windows.Forms.Label DepartureTimeLabel;
        private System.Windows.Forms.Label FlightTypeLabel;
        private System.Windows.Forms.TextBox DeparturePointTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Panel SelectedFlightPanel;
        private System.Windows.Forms.Label SelectedFlightLabel;
    }
}

