namespace Movie_Management_System
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtMovieID = new TextBox();
            txtTitle = new TextBox();
            txtGenre = new TextBox();
            txtDirector = new TextBox();
            txtYear = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            btnFirst = new Button();
            btnPrev = new Button();
            btnLast = new Button();
            btnNext = new Button();
            btnViewAll = new Button();
            SuspendLayout();
          
            txtMovieID.Location = new Point(654, 96);
            txtMovieID.Name = "txtMovieID";
            txtMovieID.PlaceholderText = "Enter Movie ID";
            txtMovieID.Size = new Size(150, 31);
            txtMovieID.TabIndex = 0;
         
            txtTitle.Location = new Point(654, 148);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Enter Movie Title";
            txtTitle.Size = new Size(150, 31);
            txtTitle.TabIndex = 1;
       
            txtGenre.Location = new Point(654, 198);
            txtGenre.Name = "txtGenre";
            txtGenre.PlaceholderText = "Enter Movie Genre";
            txtGenre.Size = new Size(150, 31);
            txtGenre.TabIndex = 2;
           
            txtDirector.Location = new Point(654, 330);
            txtDirector.Name = "txtDirector";
            txtDirector.PlaceholderText = "Enter Movie Director";
            txtDirector.Size = new Size(174, 31);
            txtDirector.TabIndex = 3;
          
            txtYear.Location = new Point(654, 263);
            txtYear.Name = "txtYear";
            txtYear.PlaceholderText = "Enter Release Year";
            txtYear.Size = new Size(150, 31);
            txtYear.TabIndex = 4;
         
            btnAdd.Location = new Point(55, 529);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            
            btnUpdate.Location = new Point(224, 529);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
        
            btnDelete.Location = new Point(409, 529);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
          
            btnSave.Location = new Point(592, 529);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
          
            btnLoad.Location = new Point(810, 529);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 9;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
         
            btnFirst.Location = new Point(342, 96);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(203, 34);
            btnFirst.TabIndex = 10;
            btnFirst.Text = "Go to First Movie";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
           
            btnPrev.Location = new Point(342, 214);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(203, 34);
            btnPrev.TabIndex = 11;
            btnPrev.Text = "Go to Previous Movie";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
           
            btnLast.Location = new Point(1007, 94);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(250, 34);
            btnLast.TabIndex = 12;
            btnLast.Text = "Go to Last Movie";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
           
            btnNext.Location = new Point(1007, 214);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(227, 34);
            btnNext.TabIndex = 13;
            btnNext.Text = "Go to Next Movie";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
          
            btnViewAll.Location = new Point(1061, 402);
            btnViewAll.Name = "btnViewAll";
            btnViewAll.Size = new Size(112, 34);
            btnViewAll.TabIndex = 14;
            btnViewAll.Text = "View";
            btnViewAll.UseVisualStyleBackColor = true;
            btnViewAll.Click += btnViewAll_Click;
            
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1345, 620);
            Controls.Add(btnViewAll);
            Controls.Add(btnNext);
            Controls.Add(btnLast);
            Controls.Add(btnPrev);
            Controls.Add(btnFirst);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtYear);
            Controls.Add(txtDirector);
            Controls.Add(txtGenre);
            Controls.Add(txtTitle);
            Controls.Add(txtMovieID);
            Name = "Form1";
            Text = "Movie Management System";
            ResumeLayout(false);
            PerformLayout();
        }


        private TextBox txtMovieID;
        private TextBox txtTitle;
        private TextBox txtGenre;
        private TextBox txtDirector;
        private TextBox txtYear;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSave;
        private Button btnLoad;
        private Button btnFirst;
        private Button btnPrev;
        private Button btnLast;
        private Button btnNext;
        private Button btnViewAll;
    
    }
}
#endregion