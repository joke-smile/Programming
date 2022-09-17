
namespace Programming.View.Controls
{
    partial class MoviesControl
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
            this.MovieDurationLabel = new System.Windows.Forms.Label();
            this.MovieDurationMinutesTextBox = new System.Windows.Forms.TextBox();
            this.MovieReleaseYearLabel = new System.Windows.Forms.Label();
            this.MovieReleaseYearTextBox = new System.Windows.Forms.TextBox();
            this.MovieFindButton = new System.Windows.Forms.Button();
            this.MovieRatingLabel = new System.Windows.Forms.Label();
            this.MovieGenreLabel = new System.Windows.Forms.Label();
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.MovieRatingTextBox = new System.Windows.Forms.TextBox();
            this.MovieGenreTextBox = new System.Windows.Forms.TextBox();
            this.MovieTitleTextBox = new System.Windows.Forms.TextBox();
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // MovieDurationLabel
            // 
            this.MovieDurationLabel.AutoSize = true;
            this.MovieDurationLabel.Location = new System.Drawing.Point(190, 218);
            this.MovieDurationLabel.Name = "MovieDurationLabel";
            this.MovieDurationLabel.Size = new System.Drawing.Size(50, 13);
            this.MovieDurationLabel.TabIndex = 9;
            this.MovieDurationLabel.Text = "Duration:";
            // 
            // MovieDurationMinutesTextBox
            // 
            this.MovieDurationMinutesTextBox.Location = new System.Drawing.Point(191, 235);
            this.MovieDurationMinutesTextBox.Name = "MovieDurationMinutesTextBox";
            this.MovieDurationMinutesTextBox.Size = new System.Drawing.Size(100, 20);
            this.MovieDurationMinutesTextBox.TabIndex = 8;
            this.MovieDurationMinutesTextBox.TextChanged += new System.EventHandler(this.DurationMinutesMovieTextBox_TextChanged);
            // 
            // MovieReleaseYearLabel
            // 
            this.MovieReleaseYearLabel.AutoSize = true;
            this.MovieReleaseYearLabel.Location = new System.Drawing.Point(190, 169);
            this.MovieReleaseYearLabel.Name = "MovieReleaseYearLabel";
            this.MovieReleaseYearLabel.Size = new System.Drawing.Size(72, 13);
            this.MovieReleaseYearLabel.TabIndex = 7;
            this.MovieReleaseYearLabel.Text = "Release year:";
            // 
            // MovieReleaseYearTextBox
            // 
            this.MovieReleaseYearTextBox.Location = new System.Drawing.Point(191, 186);
            this.MovieReleaseYearTextBox.Name = "MovieReleaseYearTextBox";
            this.MovieReleaseYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.MovieReleaseYearTextBox.TabIndex = 6;
            this.MovieReleaseYearTextBox.TextChanged += new System.EventHandler(this.ReleaseYearMovieTextBox_TextChanged);
            // 
            // MovieFindButton
            // 
            this.MovieFindButton.Location = new System.Drawing.Point(191, 325);
            this.MovieFindButton.Name = "MovieFindButton";
            this.MovieFindButton.Size = new System.Drawing.Size(100, 23);
            this.MovieFindButton.TabIndex = 1;
            this.MovieFindButton.Text = "Find";
            this.MovieFindButton.UseVisualStyleBackColor = true;
            this.MovieFindButton.Click += new System.EventHandler(this.FindMovieButton_Click);
            // 
            // MovieRatingLabel
            // 
            this.MovieRatingLabel.AutoSize = true;
            this.MovieRatingLabel.Location = new System.Drawing.Point(190, 119);
            this.MovieRatingLabel.Name = "MovieRatingLabel";
            this.MovieRatingLabel.Size = new System.Drawing.Size(41, 13);
            this.MovieRatingLabel.TabIndex = 5;
            this.MovieRatingLabel.Text = "Rating:";
            // 
            // MovieGenreLabel
            // 
            this.MovieGenreLabel.AutoSize = true;
            this.MovieGenreLabel.Location = new System.Drawing.Point(190, 71);
            this.MovieGenreLabel.Name = "MovieGenreLabel";
            this.MovieGenreLabel.Size = new System.Drawing.Size(39, 13);
            this.MovieGenreLabel.TabIndex = 4;
            this.MovieGenreLabel.Text = "Genre:";
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Location = new System.Drawing.Point(190, 22);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(30, 13);
            this.MovieTitleLabel.TabIndex = 1;
            this.MovieTitleLabel.Text = "Title:";
            // 
            // MovieRatingTextBox
            // 
            this.MovieRatingTextBox.Location = new System.Drawing.Point(191, 136);
            this.MovieRatingTextBox.Name = "MovieRatingTextBox";
            this.MovieRatingTextBox.Size = new System.Drawing.Size(100, 20);
            this.MovieRatingTextBox.TabIndex = 3;
            this.MovieRatingTextBox.TextChanged += new System.EventHandler(this.RatingMovieTextBox_TextChanged);
            // 
            // MovieGenreTextBox
            // 
            this.MovieGenreTextBox.Location = new System.Drawing.Point(191, 88);
            this.MovieGenreTextBox.Name = "MovieGenreTextBox";
            this.MovieGenreTextBox.Size = new System.Drawing.Size(100, 20);
            this.MovieGenreTextBox.TabIndex = 2;
            this.MovieGenreTextBox.TextChanged += new System.EventHandler(this.GenreMovieTextBox_TextChanged);
            // 
            // MovieTitleTextBox
            // 
            this.MovieTitleTextBox.Location = new System.Drawing.Point(191, 39);
            this.MovieTitleTextBox.Name = "MovieTitleTextBox";
            this.MovieTitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.MovieTitleTextBox.TabIndex = 1;
            this.MovieTitleTextBox.TextChanged += new System.EventHandler(this.TitleMovieTextBox_TextChanged);
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.Location = new System.Drawing.Point(7, 19);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(179, 329);
            this.MovieListBox.TabIndex = 0;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MovieFindButton);
            this.Controls.Add(this.MovieDurationMinutesTextBox);
            this.Controls.Add(this.MovieDurationLabel);
            this.Controls.Add(this.MovieListBox);
            this.Controls.Add(this.MovieReleaseYearTextBox);
            this.Controls.Add(this.MovieReleaseYearLabel);
            this.Controls.Add(this.MovieTitleLabel);
            this.Controls.Add(this.MovieTitleTextBox);
            this.Controls.Add(this.MovieGenreLabel);
            this.Controls.Add(this.MovieRatingTextBox);
            this.Controls.Add(this.MovieRatingLabel);
            this.Controls.Add(this.MovieGenreTextBox);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(316, 392);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MovieDurationLabel;
        private System.Windows.Forms.TextBox MovieDurationMinutesTextBox;
        private System.Windows.Forms.Label MovieReleaseYearLabel;
        private System.Windows.Forms.TextBox MovieReleaseYearTextBox;
        private System.Windows.Forms.Button MovieFindButton;
        private System.Windows.Forms.Label MovieRatingLabel;
        private System.Windows.Forms.Label MovieGenreLabel;
        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.TextBox MovieRatingTextBox;
        private System.Windows.Forms.TextBox MovieGenreTextBox;
        private System.Windows.Forms.TextBox MovieTitleTextBox;
        private System.Windows.Forms.ListBox MovieListBox;
    }
}
