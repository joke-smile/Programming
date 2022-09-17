
namespace Programming.View.Controls
{
    partial class RectanglesControl
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
            this.RectangleIdLabel = new System.Windows.Forms.Label();
            this.RectangleIdTextBox = new System.Windows.Forms.TextBox();
            this.RectangleYLabel = new System.Windows.Forms.Label();
            this.RectangleYTextBox = new System.Windows.Forms.TextBox();
            this.RectangleXLabel = new System.Windows.Forms.Label();
            this.RectangleXTextBox = new System.Windows.Forms.TextBox();
            this.RectangleFindButton = new System.Windows.Forms.Button();
            this.RectangleColorLabel = new System.Windows.Forms.Label();
            this.RectangleWidthLabel = new System.Windows.Forms.Label();
            this.RectangleHeightLabel = new System.Windows.Forms.Label();
            this.RectangleColorTextBox = new System.Windows.Forms.TextBox();
            this.RectangleWidthTextBox = new System.Windows.Forms.TextBox();
            this.RectangleHeightTextBox = new System.Windows.Forms.TextBox();
            this.RectangleListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RectangleIdLabel
            // 
            this.RectangleIdLabel.AutoSize = true;
            this.RectangleIdLabel.Location = new System.Drawing.Point(190, 269);
            this.RectangleIdLabel.Name = "RectangleIdLabel";
            this.RectangleIdLabel.Size = new System.Drawing.Size(19, 13);
            this.RectangleIdLabel.TabIndex = 11;
            this.RectangleIdLabel.Text = "Id:";
            // 
            // RectangleIdTextBox
            // 
            this.RectangleIdTextBox.Enabled = false;
            this.RectangleIdTextBox.Location = new System.Drawing.Point(191, 286);
            this.RectangleIdTextBox.Name = "RectangleIdTextBox";
            this.RectangleIdTextBox.ReadOnly = true;
            this.RectangleIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectangleIdTextBox.TabIndex = 10;
            // 
            // RectangleYLabel
            // 
            this.RectangleYLabel.AutoSize = true;
            this.RectangleYLabel.Location = new System.Drawing.Point(190, 218);
            this.RectangleYLabel.Name = "RectangleYLabel";
            this.RectangleYLabel.Size = new System.Drawing.Size(17, 13);
            this.RectangleYLabel.TabIndex = 9;
            this.RectangleYLabel.Text = "Y:";
            // 
            // RectangleYTextBox
            // 
            this.RectangleYTextBox.Enabled = false;
            this.RectangleYTextBox.Location = new System.Drawing.Point(191, 235);
            this.RectangleYTextBox.Name = "RectangleYTextBox";
            this.RectangleYTextBox.ReadOnly = true;
            this.RectangleYTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectangleYTextBox.TabIndex = 8;
            // 
            // RectangleXLabel
            // 
            this.RectangleXLabel.AutoSize = true;
            this.RectangleXLabel.Location = new System.Drawing.Point(190, 169);
            this.RectangleXLabel.Name = "RectangleXLabel";
            this.RectangleXLabel.Size = new System.Drawing.Size(17, 13);
            this.RectangleXLabel.TabIndex = 7;
            this.RectangleXLabel.Text = "X:";
            // 
            // RectangleXTextBox
            // 
            this.RectangleXTextBox.Enabled = false;
            this.RectangleXTextBox.Location = new System.Drawing.Point(191, 186);
            this.RectangleXTextBox.Name = "RectangleXTextBox";
            this.RectangleXTextBox.ReadOnly = true;
            this.RectangleXTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectangleXTextBox.TabIndex = 6;
            // 
            // RectangleFindButton
            // 
            this.RectangleFindButton.Location = new System.Drawing.Point(191, 325);
            this.RectangleFindButton.Name = "RectangleFindButton";
            this.RectangleFindButton.Size = new System.Drawing.Size(100, 23);
            this.RectangleFindButton.TabIndex = 1;
            this.RectangleFindButton.Text = "Find";
            this.RectangleFindButton.UseVisualStyleBackColor = true;
            this.RectangleFindButton.Click += new System.EventHandler(this.FindRectangleButton_Click);
            // 
            // RectangleColorLabel
            // 
            this.RectangleColorLabel.AutoSize = true;
            this.RectangleColorLabel.Location = new System.Drawing.Point(190, 119);
            this.RectangleColorLabel.Name = "RectangleColorLabel";
            this.RectangleColorLabel.Size = new System.Drawing.Size(34, 13);
            this.RectangleColorLabel.TabIndex = 5;
            this.RectangleColorLabel.Text = "Color:";
            // 
            // RectangleWidthLabel
            // 
            this.RectangleWidthLabel.AutoSize = true;
            this.RectangleWidthLabel.Location = new System.Drawing.Point(190, 71);
            this.RectangleWidthLabel.Name = "RectangleWidthLabel";
            this.RectangleWidthLabel.Size = new System.Drawing.Size(38, 13);
            this.RectangleWidthLabel.TabIndex = 4;
            this.RectangleWidthLabel.Text = "Width:";
            // 
            // RectangleHeightLabel
            // 
            this.RectangleHeightLabel.AutoSize = true;
            this.RectangleHeightLabel.Location = new System.Drawing.Point(190, 22);
            this.RectangleHeightLabel.Name = "RectangleHeightLabel";
            this.RectangleHeightLabel.Size = new System.Drawing.Size(41, 13);
            this.RectangleHeightLabel.TabIndex = 1;
            this.RectangleHeightLabel.Text = "Height:";
            // 
            // RectangleColorTextBox
            // 
            this.RectangleColorTextBox.Location = new System.Drawing.Point(191, 136);
            this.RectangleColorTextBox.Name = "RectangleColorTextBox";
            this.RectangleColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectangleColorTextBox.TabIndex = 3;
            this.RectangleColorTextBox.TextChanged += new System.EventHandler(this.ColorRectangleTextBox_TextChanged);
            // 
            // RectangleWidthTextBox
            // 
            this.RectangleWidthTextBox.Location = new System.Drawing.Point(191, 88);
            this.RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            this.RectangleWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectangleWidthTextBox.TabIndex = 2;
            this.RectangleWidthTextBox.TextChanged += new System.EventHandler(this.WidthRectangleTextBox_TextChanged);
            // 
            // RectangleHeightTextBox
            // 
            this.RectangleHeightTextBox.Location = new System.Drawing.Point(191, 39);
            this.RectangleHeightTextBox.Name = "RectangleHeightTextBox";
            this.RectangleHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectangleHeightTextBox.TabIndex = 1;
            this.RectangleHeightTextBox.TextChanged += new System.EventHandler(this.HeightRectangleTextBox_TextChanged);
            // 
            // RectangleListBox
            // 
            this.RectangleListBox.FormattingEnabled = true;
            this.RectangleListBox.Location = new System.Drawing.Point(7, 19);
            this.RectangleListBox.Name = "RectangleListBox";
            this.RectangleListBox.Size = new System.Drawing.Size(179, 329);
            this.RectangleListBox.TabIndex = 0;
            this.RectangleListBox.SelectedIndexChanged += new System.EventHandler(this.RectangleListBox_SelectedIndexChanged);
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RectangleFindButton);
            this.Controls.Add(this.RectangleIdTextBox);
            this.Controls.Add(this.RectangleIdLabel);
            this.Controls.Add(this.RectangleListBox);
            this.Controls.Add(this.RectangleYTextBox);
            this.Controls.Add(this.RectangleYLabel);
            this.Controls.Add(this.RectangleHeightLabel);
            this.Controls.Add(this.RectangleHeightTextBox);
            this.Controls.Add(this.RectangleXTextBox);
            this.Controls.Add(this.RectangleXLabel);
            this.Controls.Add(this.RectangleWidthLabel);
            this.Controls.Add(this.RectangleWidthTextBox);
            this.Controls.Add(this.RectangleColorLabel);
            this.Controls.Add(this.RectangleColorTextBox);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(316, 392);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label RectangleIdLabel;
        private System.Windows.Forms.TextBox RectangleIdTextBox;
        private System.Windows.Forms.Label RectangleYLabel;
        private System.Windows.Forms.TextBox RectangleYTextBox;
        private System.Windows.Forms.Label RectangleXLabel;
        private System.Windows.Forms.TextBox RectangleXTextBox;
        private System.Windows.Forms.Button RectangleFindButton;
        private System.Windows.Forms.Label RectangleColorLabel;
        private System.Windows.Forms.Label RectangleWidthLabel;
        private System.Windows.Forms.TextBox RectangleColorTextBox;
        private System.Windows.Forms.TextBox RectangleWidthTextBox;
        private System.Windows.Forms.TextBox RectangleHeightTextBox;
        private System.Windows.Forms.Label RectangleHeightLabel;
        private System.Windows.Forms.ListBox RectangleListBox;
    }
}
