
namespace AssignmentA010
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TableName = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.tableTextBox = new System.Windows.Forms.TextBox();
            this.tableComboBox = new System.Windows.Forms.ComboBox();
            this.formatComboBox = new System.Windows.Forms.ComboBox();
            this.formatType = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1361, 125);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TableName
            // 
            this.TableName.AutoSize = true;
            this.TableName.BackColor = System.Drawing.Color.Silver;
            this.TableName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableName.Location = new System.Drawing.Point(538, 209);
            this.TableName.Name = "TableName";
            this.TableName.Size = new System.Drawing.Size(529, 39);
            this.TableName.TabIndex = 1;
            this.TableName.Text = "Choose the table name from the DB";
            this.TableName.Click += new System.EventHandler(this.TableName_Click);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.submitButton.Location = new System.Drawing.Point(390, 573);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(192, 54);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableTextBox
            // 
            this.tableTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableTextBox.Location = new System.Drawing.Point(333, 284);
            this.tableTextBox.Name = "tableTextBox";
            this.tableTextBox.Size = new System.Drawing.Size(112, 26);
            this.tableTextBox.TabIndex = 5;
            this.tableTextBox.Text = "Table Name :";
            // 
            // tableComboBox
            // 
            this.tableComboBox.FormattingEnabled = true;
            this.tableComboBox.Location = new System.Drawing.Point(538, 284);
            this.tableComboBox.Name = "tableComboBox";
            this.tableComboBox.Size = new System.Drawing.Size(529, 28);
            this.tableComboBox.TabIndex = 6;
            // 
            // formatComboBox
            // 
            this.formatComboBox.FormattingEnabled = true;
            this.formatComboBox.Items.AddRange(new object[] {
            "CSV Format",
            "Excel File",
            "Both"});
            this.formatComboBox.Location = new System.Drawing.Point(538, 465);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.Size = new System.Drawing.Size(429, 28);
            this.formatComboBox.TabIndex = 7;
            // 
            // formatType
            // 
            this.formatType.AutoSize = true;
            this.formatType.BackColor = System.Drawing.Color.Silver;
            this.formatType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.formatType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatType.Location = new System.Drawing.Point(538, 404);
            this.formatType.Name = "formatType";
            this.formatType.Size = new System.Drawing.Size(429, 39);
            this.formatType.TabIndex = 8;
            this.formatType.Text = "Choose target output format:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(343, 465);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Format Type :";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(802, 573);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(192, 54);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1357, 698);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.formatType);
            this.Controls.Add(this.formatComboBox);
            this.Controls.Add(this.tableComboBox);
            this.Controls.Add(this.tableTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.TableName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Data Export";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TableName;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox tableTextBox;
        private System.Windows.Forms.ComboBox tableComboBox;
        private System.Windows.Forms.ComboBox formatComboBox;
        private System.Windows.Forms.Label formatType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button exitButton;
    }
}

