namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CustomersSplitContainer = new System.Windows.Forms.SplitContainer();
            this.CustomersButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.RemoveCustomerButton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.SelectedCustomerSplitContainer = new System.Windows.Forms.SplitContainer();
            this.SelectedCustomerLabel = new System.Windows.Forms.Label();
            this.CustomerFullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.CustomerAddressTextBox = new System.Windows.Forms.TextBox();
            this.CustomersIdLabel = new System.Windows.Forms.Label();
            this.CustomerIdTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersSplitContainer)).BeginInit();
            this.CustomersSplitContainer.Panel1.SuspendLayout();
            this.CustomersSplitContainer.Panel2.SuspendLayout();
            this.CustomersSplitContainer.SuspendLayout();
            this.CustomersButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCustomerSplitContainer)).BeginInit();
            this.SelectedCustomerSplitContainer.Panel1.SuspendLayout();
            this.SelectedCustomerSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomersSplitContainer
            // 
            this.CustomersSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.CustomersSplitContainer.Name = "CustomersSplitContainer";
            // 
            // CustomersSplitContainer.Panel1
            // 
            this.CustomersSplitContainer.Panel1.Controls.Add(this.CustomersButtonsPanel);
            this.CustomersSplitContainer.Panel1.Controls.Add(this.CustomersListBox);
            this.CustomersSplitContainer.Panel1.Controls.Add(this.CustomersLabel);
            // 
            // CustomersSplitContainer.Panel2
            // 
            this.CustomersSplitContainer.Panel2.Controls.Add(this.SelectedCustomerSplitContainer);
            this.CustomersSplitContainer.Size = new System.Drawing.Size(966, 719);
            this.CustomersSplitContainer.SplitterDistance = 358;
            this.CustomersSplitContainer.TabIndex = 0;
            // 
            // CustomersButtonsPanel
            // 
            this.CustomersButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersButtonsPanel.ColumnCount = 3;
            this.CustomersButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CustomersButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CustomersButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CustomersButtonsPanel.Controls.Add(this.AddCustomerButton, 0, 0);
            this.CustomersButtonsPanel.Controls.Add(this.RemoveCustomerButton, 1, 0);
            this.CustomersButtonsPanel.Location = new System.Drawing.Point(4, 651);
            this.CustomersButtonsPanel.Name = "CustomersButtonsPanel";
            this.CustomersButtonsPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.CustomersButtonsPanel.RowCount = 1;
            this.CustomersButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CustomersButtonsPanel.Size = new System.Drawing.Size(345, 63);
            this.CustomersButtonsPanel.TabIndex = 12;
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(4, 4);
            this.AddCustomerButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(107, 52);
            this.AddCustomerButton.TabIndex = 3;
            this.AddCustomerButton.Text = "Add";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // RemoveCustomerButton
            // 
            this.RemoveCustomerButton.Location = new System.Drawing.Point(118, 3);
            this.RemoveCustomerButton.Name = "RemoveCustomerButton";
            this.RemoveCustomerButton.Size = new System.Drawing.Size(108, 54);
            this.RemoveCustomerButton.TabIndex = 3;
            this.RemoveCustomerButton.Text = "Remove";
            this.RemoveCustomerButton.UseVisualStyleBackColor = true;
            this.RemoveCustomerButton.Click += new System.EventHandler(this.RemoveCustomerButton_Click);
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 16;
            this.CustomersListBox.Location = new System.Drawing.Point(9, 33);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(340, 612);
            this.CustomersListBox.TabIndex = 0;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLabel.Location = new System.Drawing.Point(5, 5);
            this.CustomersLabel.Margin = new System.Windows.Forms.Padding(5);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(100, 20);
            this.CustomersLabel.TabIndex = 0;
            this.CustomersLabel.Text = "Customers";
            // 
            // SelectedCustomerSplitContainer
            // 
            this.SelectedCustomerSplitContainer.Location = new System.Drawing.Point(3, 0);
            this.SelectedCustomerSplitContainer.Name = "SelectedCustomerSplitContainer";
            this.SelectedCustomerSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SelectedCustomerSplitContainer.Panel1
            // 
            this.SelectedCustomerSplitContainer.Panel1.Controls.Add(this.SelectedCustomerLabel);
            this.SelectedCustomerSplitContainer.Panel1.Controls.Add(this.CustomerFullNameTextBox);
            this.SelectedCustomerSplitContainer.Panel1.Controls.Add(this.FullNameLabel);
            this.SelectedCustomerSplitContainer.Panel1.Controls.Add(this.AddressLabel);
            this.SelectedCustomerSplitContainer.Panel1.Controls.Add(this.CustomerAddressTextBox);
            this.SelectedCustomerSplitContainer.Panel1.Controls.Add(this.CustomersIdLabel);
            this.SelectedCustomerSplitContainer.Panel1.Controls.Add(this.CustomerIdTextBox);
            this.SelectedCustomerSplitContainer.Size = new System.Drawing.Size(589, 716);
            this.SelectedCustomerSplitContainer.SplitterDistance = 257;
            this.SelectedCustomerSplitContainer.TabIndex = 19;
            // 
            // SelectedCustomerLabel
            // 
            this.SelectedCustomerLabel.AutoSize = true;
            this.SelectedCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedCustomerLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectedCustomerLabel.Location = new System.Drawing.Point(5, 5);
            this.SelectedCustomerLabel.Margin = new System.Windows.Forms.Padding(5);
            this.SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            this.SelectedCustomerLabel.Size = new System.Drawing.Size(169, 20);
            this.SelectedCustomerLabel.TabIndex = 11;
            this.SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // CustomerFullNameTextBox
            // 
            this.CustomerFullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerFullNameTextBox.Location = new System.Drawing.Point(87, 82);
            this.CustomerFullNameTextBox.Name = "CustomerFullNameTextBox";
            this.CustomerFullNameTextBox.Size = new System.Drawing.Size(175, 22);
            this.CustomerFullNameTextBox.TabIndex = 15;
            this.CustomerFullNameTextBox.TextChanged += new System.EventHandler(this.CustomerFullNameTextBox_TextChanged);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameLabel.Location = new System.Drawing.Point(6, 82);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(79, 18);
            this.FullNameLabel.TabIndex = 13;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressLabel.Location = new System.Drawing.Point(6, 113);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(66, 18);
            this.AddressLabel.TabIndex = 16;
            this.AddressLabel.Text = "Address:";
            // 
            // CustomerAddressTextBox
            // 
            this.CustomerAddressTextBox.Location = new System.Drawing.Point(87, 113);
            this.CustomerAddressTextBox.Multiline = true;
            this.CustomerAddressTextBox.Name = "CustomerAddressTextBox";
            this.CustomerAddressTextBox.Size = new System.Drawing.Size(323, 126);
            this.CustomerAddressTextBox.TabIndex = 18;
            this.CustomerAddressTextBox.TextChanged += new System.EventHandler(this.CustomerAddressTextBox_TextChanged);
            // 
            // CustomersIdLabel
            // 
            this.CustomersIdLabel.AutoSize = true;
            this.CustomersIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersIdLabel.Location = new System.Drawing.Point(6, 50);
            this.CustomersIdLabel.Name = "CustomersIdLabel";
            this.CustomersIdLabel.Size = new System.Drawing.Size(26, 18);
            this.CustomersIdLabel.TabIndex = 12;
            this.CustomersIdLabel.Text = "ID:";
            // 
            // CustomerIdTextBox
            // 
            this.CustomerIdTextBox.Enabled = false;
            this.CustomerIdTextBox.Location = new System.Drawing.Point(87, 50);
            this.CustomerIdTextBox.Name = "CustomerIdTextBox";
            this.CustomerIdTextBox.Size = new System.Drawing.Size(133, 22);
            this.CustomerIdTextBox.TabIndex = 14;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustomersSplitContainer);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(966, 719);
            this.CustomersSplitContainer.Panel1.ResumeLayout(false);
            this.CustomersSplitContainer.Panel1.PerformLayout();
            this.CustomersSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersSplitContainer)).EndInit();
            this.CustomersSplitContainer.ResumeLayout(false);
            this.CustomersButtonsPanel.ResumeLayout(false);
            this.SelectedCustomerSplitContainer.Panel1.ResumeLayout(false);
            this.SelectedCustomerSplitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCustomerSplitContainer)).EndInit();
            this.SelectedCustomerSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer CustomersSplitContainer;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Label CustomersLabel;
        private System.Windows.Forms.TableLayoutPanel CustomersButtonsPanel;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Button RemoveCustomerButton;
        private System.Windows.Forms.SplitContainer SelectedCustomerSplitContainer;
        private System.Windows.Forms.Label SelectedCustomerLabel;
        private System.Windows.Forms.TextBox CustomerFullNameTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox CustomerAddressTextBox;
        private System.Windows.Forms.Label CustomersIdLabel;
        private System.Windows.Forms.TextBox CustomerIdTextBox;
    }
}
