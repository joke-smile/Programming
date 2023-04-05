namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            this.ItemsButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.ItemInfoTextBox = new System.Windows.Forms.TextBox();
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionsLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ItemCostTextBox = new System.Windows.Forms.TextBox();
            this.ItemIdTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SelectedItemLabel = new System.Windows.Forms.Label();
            this.ItemSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ItemsCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ItemsCategoryLabel = new System.Windows.Forms.Label();
            this.ItemsButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSplitContainer)).BeginInit();
            this.ItemSplitContainer.Panel1.SuspendLayout();
            this.ItemSplitContainer.Panel2.SuspendLayout();
            this.ItemSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsButtonsPanel
            // 
            this.ItemsButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsButtonsPanel.ColumnCount = 3;
            this.ItemsButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ItemsButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ItemsButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ItemsButtonsPanel.Controls.Add(this.AddItemButton, 0, 0);
            this.ItemsButtonsPanel.Controls.Add(this.RemoveItemButton, 1, 0);
            this.ItemsButtonsPanel.Location = new System.Drawing.Point(5, 651);
            this.ItemsButtonsPanel.Name = "ItemsButtonsPanel";
            this.ItemsButtonsPanel.RowCount = 1;
            this.ItemsButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ItemsButtonsPanel.Size = new System.Drawing.Size(344, 63);
            this.ItemsButtonsPanel.TabIndex = 11;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(4, 4);
            this.AddItemButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(106, 55);
            this.AddItemButton.TabIndex = 3;
            this.AddItemButton.Text = "Add";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Location = new System.Drawing.Point(117, 3);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(108, 55);
            this.RemoveItemButton.TabIndex = 3;
            this.RemoveItemButton.Text = "Remove";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ItemsLabel.Location = new System.Drawing.Point(5, 5);
            this.ItemsLabel.Margin = new System.Windows.Forms.Padding(5);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(55, 20);
            this.ItemsLabel.TabIndex = 3;
            this.ItemsLabel.Text = "Items";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 16;
            this.ItemsListBox.Location = new System.Drawing.Point(9, 33);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(340, 612);
            this.ItemsListBox.TabIndex = 0;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // ItemInfoTextBox
            // 
            this.ItemInfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemInfoTextBox.Location = new System.Drawing.Point(7, 268);
            this.ItemInfoTextBox.Multiline = true;
            this.ItemInfoTextBox.Name = "ItemInfoTextBox";
            this.ItemInfoTextBox.Size = new System.Drawing.Size(593, 381);
            this.ItemInfoTextBox.TabIndex = 10;
            this.ItemInfoTextBox.TextChanged += new System.EventHandler(this.ItemInfoTextBox_TextChanged);
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemNameTextBox.Location = new System.Drawing.Point(7, 188);
            this.ItemNameTextBox.Multiline = true;
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.Size = new System.Drawing.Size(593, 55);
            this.ItemNameTextBox.TabIndex = 9;
            this.ItemNameTextBox.TextChanged += new System.EventHandler(this.ItemNameTextBox_TextChanged);
            // 
            // DescriptionsLabel
            // 
            this.DescriptionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionsLabel.AutoSize = true;
            this.DescriptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionsLabel.Location = new System.Drawing.Point(12, 246);
            this.DescriptionsLabel.Name = "DescriptionsLabel";
            this.DescriptionsLabel.Size = new System.Drawing.Size(87, 18);
            this.DescriptionsLabel.TabIndex = 7;
            this.DescriptionsLabel.Text = "Description:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(12, 167);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(52, 18);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Name:";
            // 
            // ItemCostTextBox
            // 
            this.ItemCostTextBox.Location = new System.Drawing.Point(110, 95);
            this.ItemCostTextBox.Name = "ItemCostTextBox";
            this.ItemCostTextBox.Size = new System.Drawing.Size(133, 22);
            this.ItemCostTextBox.TabIndex = 4;
            this.ItemCostTextBox.TextChanged += new System.EventHandler(this.ItemCostTextBox_TextChanged);
            // 
            // ItemIdTextBox
            // 
            this.ItemIdTextBox.Enabled = false;
            this.ItemIdTextBox.Location = new System.Drawing.Point(110, 50);
            this.ItemIdTextBox.Name = "ItemIdTextBox";
            this.ItemIdTextBox.Size = new System.Drawing.Size(133, 22);
            this.ItemIdTextBox.TabIndex = 3;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLabel.Location = new System.Drawing.Point(12, 92);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(44, 18);
            this.CostLabel.TabIndex = 2;
            this.CostLabel.Text = "Cost:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdLabel.Location = new System.Drawing.Point(12, 50);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(26, 18);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "ID:";
            // 
            // SelectedItemLabel
            // 
            this.SelectedItemLabel.AutoSize = true;
            this.SelectedItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedItemLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectedItemLabel.Location = new System.Drawing.Point(3, 5);
            this.SelectedItemLabel.Name = "SelectedItemLabel";
            this.SelectedItemLabel.Size = new System.Drawing.Size(124, 20);
            this.SelectedItemLabel.TabIndex = 0;
            this.SelectedItemLabel.Text = "Selected Item";
            // 
            // ItemSplitContainer
            // 
            this.ItemSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.ItemSplitContainer.Name = "ItemSplitContainer";
            // 
            // ItemSplitContainer.Panel1
            // 
            this.ItemSplitContainer.Panel1.Controls.Add(this.ItemsButtonsPanel);
            this.ItemSplitContainer.Panel1.Controls.Add(this.ItemsListBox);
            this.ItemSplitContainer.Panel1.Controls.Add(this.ItemsLabel);
            // 
            // ItemSplitContainer.Panel2
            // 
            this.ItemSplitContainer.Panel2.Controls.Add(this.ItemsCategoryComboBox);
            this.ItemSplitContainer.Panel2.Controls.Add(this.ItemsCategoryLabel);
            this.ItemSplitContainer.Panel2.Controls.Add(this.ItemInfoTextBox);
            this.ItemSplitContainer.Panel2.Controls.Add(this.SelectedItemLabel);
            this.ItemSplitContainer.Panel2.Controls.Add(this.CostLabel);
            this.ItemSplitContainer.Panel2.Controls.Add(this.ItemNameTextBox);
            this.ItemSplitContainer.Panel2.Controls.Add(this.ItemIdTextBox);
            this.ItemSplitContainer.Panel2.Controls.Add(this.DescriptionsLabel);
            this.ItemSplitContainer.Panel2.Controls.Add(this.IdLabel);
            this.ItemSplitContainer.Panel2.Controls.Add(this.NameLabel);
            this.ItemSplitContainer.Panel2.Controls.Add(this.ItemCostTextBox);
            this.ItemSplitContainer.Size = new System.Drawing.Size(972, 728);
            this.ItemSplitContainer.SplitterDistance = 356;
            this.ItemSplitContainer.TabIndex = 11;
            // 
            // ItemsCategoryComboBox
            // 
            this.ItemsCategoryComboBox.FormattingEnabled = true;
            this.ItemsCategoryComboBox.Location = new System.Drawing.Point(110, 131);
            this.ItemsCategoryComboBox.Name = "ItemsCategoryComboBox";
            this.ItemsCategoryComboBox.Size = new System.Drawing.Size(133, 24);
            this.ItemsCategoryComboBox.TabIndex = 12;
            this.ItemsCategoryComboBox.SelectedValueChanged += new System.EventHandler(this.ItemsCategoryComboBox_SelectedValueChanged);
            this.ItemsCategoryComboBox.TextChanged += new System.EventHandler(this.ItemsCategoryComboBox_TextChanged);
            // 
            // ItemsCategoryLabel
            // 
            this.ItemsCategoryLabel.AutoSize = true;
            this.ItemsCategoryLabel.Location = new System.Drawing.Point(12, 131);
            this.ItemsCategoryLabel.Name = "ItemsCategoryLabel";
            this.ItemsCategoryLabel.Size = new System.Drawing.Size(65, 16);
            this.ItemsCategoryLabel.TabIndex = 11;
            this.ItemsCategoryLabel.Text = "Category:";
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemSplitContainer);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(972, 728);
            this.ItemsButtonsPanel.ResumeLayout(false);
            this.ItemSplitContainer.Panel1.ResumeLayout(false);
            this.ItemSplitContainer.Panel1.PerformLayout();
            this.ItemSplitContainer.Panel2.ResumeLayout(false);
            this.ItemSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSplitContainer)).EndInit();
            this.ItemSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.TextBox ItemCostTextBox;
        private System.Windows.Forms.TextBox ItemIdTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label SelectedItemLabel;
        private System.Windows.Forms.Label DescriptionsLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox ItemInfoTextBox;
        private System.Windows.Forms.TextBox ItemNameTextBox;
        private System.Windows.Forms.TableLayoutPanel ItemsButtonsPanel;
        private System.Windows.Forms.SplitContainer ItemSplitContainer;
        private System.Windows.Forms.ComboBox ItemsCategoryComboBox;
        private System.Windows.Forms.Label ItemsCategoryLabel;
    }
}
