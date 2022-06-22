
namespace Programming.View.Controls
{
    partial class RectanglesCollisionControl
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
            this.RemoveSelectedRectangleButton = new System.Windows.Forms.Button();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.RectangleSelectedHeightTextBox = new System.Windows.Forms.TextBox();
            this.RectangleSelectedHeightLabel = new System.Windows.Forms.Label();
            this.RectangleSelectedWidthTextBox = new System.Windows.Forms.TextBox();
            this.RectangleSelectedWidthLabel = new System.Windows.Forms.Label();
            this.RectangleSelectedYTextBox = new System.Windows.Forms.TextBox();
            this.RectangleSelectedYLabel = new System.Windows.Forms.Label();
            this.RectangleSelectedXTextBox = new System.Windows.Forms.TextBox();
            this.RectangleSelectedXLabel = new System.Windows.Forms.Label();
            this.RectangleSelectedIdLabel = new System.Windows.Forms.Label();
            this.RectangleSelectedIdTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.RectanglesLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RemoveSelectedRectangleButton
            // 
            this.RemoveSelectedRectangleButton.FlatAppearance.BorderSize = 0;
            this.RemoveSelectedRectangleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.RemoveSelectedRectangleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RemoveSelectedRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSelectedRectangleButton.Image = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.RemoveSelectedRectangleButton.Location = new System.Drawing.Point(270, 169);
            this.RemoveSelectedRectangleButton.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveSelectedRectangleButton.Name = "RemoveSelectedRectangleButton";
            this.RemoveSelectedRectangleButton.Size = new System.Drawing.Size(100, 32);
            this.RemoveSelectedRectangleButton.TabIndex = 31;
            this.RemoveSelectedRectangleButton.UseVisualStyleBackColor = true;
            this.RemoveSelectedRectangleButton.Click += new System.EventHandler(this.RemoveButton_Click);
            this.RemoveSelectedRectangleButton.MouseEnter += new System.EventHandler(this.RemoveButton_MouseEnter);
            this.RemoveSelectedRectangleButton.MouseLeave += new System.EventHandler(this.RemoveButton_MouseLeave);
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.FlatAppearance.BorderSize = 0;
            this.AddRectangleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.AddRectangleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.Image = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
            this.AddRectangleButton.Location = new System.Drawing.Point(13, 169);
            this.AddRectangleButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(100, 32);
            this.AddRectangleButton.TabIndex = 30;
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddRectangleButton.MouseEnter += new System.EventHandler(this.AddButton_MouseEnter);
            this.AddRectangleButton.MouseLeave += new System.EventHandler(this.AddButton_MouseLeave);
            // 
            // RectangleSelectedHeightTextBox
            // 
            this.RectangleSelectedHeightTextBox.Location = new System.Drawing.Point(71, 364);
            this.RectangleSelectedHeightTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RectangleSelectedHeightTextBox.Name = "RectangleSelectedHeightTextBox";
            this.RectangleSelectedHeightTextBox.Size = new System.Drawing.Size(132, 22);
            this.RectangleSelectedHeightTextBox.TabIndex = 29;
            this.RectangleSelectedHeightTextBox.TextChanged += new System.EventHandler(this.RectanglesHeightTextBox_TextChanged);
            // 
            // RectangleSelectedHeightLabel
            // 
            this.RectangleSelectedHeightLabel.AutoSize = true;
            this.RectangleSelectedHeightLabel.Location = new System.Drawing.Point(14, 370);
            this.RectangleSelectedHeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RectangleSelectedHeightLabel.Name = "RectangleSelectedHeightLabel";
            this.RectangleSelectedHeightLabel.Size = new System.Drawing.Size(49, 16);
            this.RectangleSelectedHeightLabel.TabIndex = 28;
            this.RectangleSelectedHeightLabel.Text = "Height:";
            // 
            // RectangleSelectedWidthTextBox
            // 
            this.RectangleSelectedWidthTextBox.Location = new System.Drawing.Point(71, 334);
            this.RectangleSelectedWidthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RectangleSelectedWidthTextBox.Name = "RectangleSelectedWidthTextBox";
            this.RectangleSelectedWidthTextBox.Size = new System.Drawing.Size(132, 22);
            this.RectangleSelectedWidthTextBox.TabIndex = 27;
            this.RectangleSelectedWidthTextBox.TextChanged += new System.EventHandler(this.RectanglesWidthTextBox_TextChanged);
            // 
            // RectangleSelectedWidthLabel
            // 
            this.RectangleSelectedWidthLabel.AutoSize = true;
            this.RectangleSelectedWidthLabel.Location = new System.Drawing.Point(18, 340);
            this.RectangleSelectedWidthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RectangleSelectedWidthLabel.Name = "RectangleSelectedWidthLabel";
            this.RectangleSelectedWidthLabel.Size = new System.Drawing.Size(44, 16);
            this.RectangleSelectedWidthLabel.TabIndex = 26;
            this.RectangleSelectedWidthLabel.Text = "Width:";
            // 
            // RectangleSelectedYTextBox
            // 
            this.RectangleSelectedYTextBox.Location = new System.Drawing.Point(71, 304);
            this.RectangleSelectedYTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RectangleSelectedYTextBox.Name = "RectangleSelectedYTextBox";
            this.RectangleSelectedYTextBox.Size = new System.Drawing.Size(132, 22);
            this.RectangleSelectedYTextBox.TabIndex = 25;
            this.RectangleSelectedYTextBox.TextChanged += new System.EventHandler(this.RectanglesYTextBox_TextChanged);
            // 
            // RectangleSelectedYLabel
            // 
            this.RectangleSelectedYLabel.AutoSize = true;
            this.RectangleSelectedYLabel.Location = new System.Drawing.Point(46, 310);
            this.RectangleSelectedYLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RectangleSelectedYLabel.Name = "RectangleSelectedYLabel";
            this.RectangleSelectedYLabel.Size = new System.Drawing.Size(19, 16);
            this.RectangleSelectedYLabel.TabIndex = 24;
            this.RectangleSelectedYLabel.Text = "Y:";
            // 
            // RectangleSelectedXTextBox
            // 
            this.RectangleSelectedXTextBox.Location = new System.Drawing.Point(71, 274);
            this.RectangleSelectedXTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RectangleSelectedXTextBox.Name = "RectangleSelectedXTextBox";
            this.RectangleSelectedXTextBox.Size = new System.Drawing.Size(132, 22);
            this.RectangleSelectedXTextBox.TabIndex = 23;
            this.RectangleSelectedXTextBox.TextChanged += new System.EventHandler(this.RectanglesXTextBox_TextChanged);
            // 
            // RectangleSelectedXLabel
            // 
            this.RectangleSelectedXLabel.AutoSize = true;
            this.RectangleSelectedXLabel.Location = new System.Drawing.Point(44, 277);
            this.RectangleSelectedXLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RectangleSelectedXLabel.Name = "RectangleSelectedXLabel";
            this.RectangleSelectedXLabel.Size = new System.Drawing.Size(18, 16);
            this.RectangleSelectedXLabel.TabIndex = 22;
            this.RectangleSelectedXLabel.Text = "X:";
            // 
            // RectangleSelectedIdLabel
            // 
            this.RectangleSelectedIdLabel.AutoSize = true;
            this.RectangleSelectedIdLabel.Location = new System.Drawing.Point(44, 250);
            this.RectangleSelectedIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RectangleSelectedIdLabel.Name = "RectangleSelectedIdLabel";
            this.RectangleSelectedIdLabel.Size = new System.Drawing.Size(21, 16);
            this.RectangleSelectedIdLabel.TabIndex = 21;
            this.RectangleSelectedIdLabel.Text = "Id:";
            // 
            // RectangleSelectedIdTextBox
            // 
            this.RectangleSelectedIdTextBox.Enabled = false;
            this.RectangleSelectedIdTextBox.Location = new System.Drawing.Point(71, 244);
            this.RectangleSelectedIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RectangleSelectedIdTextBox.Name = "RectangleSelectedIdTextBox";
            this.RectangleSelectedIdTextBox.ReadOnly = true;
            this.RectangleSelectedIdTextBox.Size = new System.Drawing.Size(132, 22);
            this.RectangleSelectedIdTextBox.TabIndex = 20;
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(10, 224);
            this.SelectedRectangleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(129, 16);
            this.SelectedRectangleLabel.TabIndex = 19;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.Location = new System.Drawing.Point(398, 29);
            this.CanvasPanel.Margin = new System.Windows.Forms.Padding(15);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(455, 436);
            this.CanvasPanel.TabIndex = 18;
            // 
            // RectanglesLabel
            // 
            this.RectanglesLabel.AutoSize = true;
            this.RectanglesLabel.Location = new System.Drawing.Point(13, 9);
            this.RectanglesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RectanglesLabel.Name = "RectanglesLabel";
            this.RectanglesLabel.Size = new System.Drawing.Size(79, 16);
            this.RectanglesLabel.TabIndex = 17;
            this.RectanglesLabel.Text = "Rectangles:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 16;
            this.RectanglesListBox.Location = new System.Drawing.Point(13, 29);
            this.RectanglesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(357, 132);
            this.RectanglesListBox.TabIndex = 16;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.RemoveSelectedRectangleButton);
            this.Controls.Add(this.AddRectangleButton);
            this.Controls.Add(this.RectangleSelectedHeightTextBox);
            this.Controls.Add(this.RectangleSelectedHeightLabel);
            this.Controls.Add(this.RectangleSelectedWidthTextBox);
            this.Controls.Add(this.RectangleSelectedWidthLabel);
            this.Controls.Add(this.RectangleSelectedYTextBox);
            this.Controls.Add(this.RectangleSelectedYLabel);
            this.Controls.Add(this.RectangleSelectedXTextBox);
            this.Controls.Add(this.RectangleSelectedXLabel);
            this.Controls.Add(this.RectangleSelectedIdLabel);
            this.Controls.Add(this.RectangleSelectedIdTextBox);
            this.Controls.Add(this.SelectedRectangleLabel);
            this.Controls.Add(this.CanvasPanel);
            this.Controls.Add(this.RectanglesLabel);
            this.Controls.Add(this.RectanglesListBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(883, 495);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveSelectedRectangleButton;
        private System.Windows.Forms.Button AddRectangleButton;
        private System.Windows.Forms.TextBox RectangleSelectedHeightTextBox;
        private System.Windows.Forms.Label RectangleSelectedHeightLabel;
        private System.Windows.Forms.TextBox RectangleSelectedWidthTextBox;
        private System.Windows.Forms.Label RectangleSelectedWidthLabel;
        private System.Windows.Forms.TextBox RectangleSelectedYTextBox;
        private System.Windows.Forms.Label RectangleSelectedYLabel;
        private System.Windows.Forms.TextBox RectangleSelectedXTextBox;
        private System.Windows.Forms.Label RectangleSelectedXLabel;
        private System.Windows.Forms.Label RectangleSelectedIdLabel;
        private System.Windows.Forms.TextBox RectangleSelectedIdTextBox;
        private System.Windows.Forms.Label SelectedRectangleLabel;
        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.Label RectanglesLabel;
        private System.Windows.Forms.ListBox RectanglesListBox;
    }
}
