namespace Lab2_1
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelC2 = new System.Windows.Forms.Label();
            this.labelC1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelC8 = new System.Windows.Forms.Panel();
            this.panelC7 = new System.Windows.Forms.Panel();
            this.panelC6 = new System.Windows.Forms.Panel();
            this.panelC5 = new System.Windows.Forms.Panel();
            this.panelC4 = new System.Windows.Forms.Panel();
            this.panelC3 = new System.Windows.Forms.Panel();
            this.panelC2 = new System.Windows.Forms.Panel();
            this.panelC1 = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 124);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 234);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип судна";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 93);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cat";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boat";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.labelC2);
            this.panel1.Controls.Add(this.labelC1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(195, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 367);
            this.panel1.TabIndex = 2;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelC2
            // 
            this.labelC2.AllowDrop = true;
            this.labelC2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelC2.Location = new System.Drawing.Point(46, 251);
            this.labelC2.Name = "labelC2";
            this.labelC2.Size = new System.Drawing.Size(149, 93);
            this.labelC2.TabIndex = 2;
            this.labelC2.Text = "Доп. цвет";
            this.labelC2.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelC2_DragDrop);
            this.labelC2.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelC1_DragEnter);
            // 
            // labelC1
            // 
            this.labelC1.AllowDrop = true;
            this.labelC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelC1.Location = new System.Drawing.Point(46, 149);
            this.labelC1.Name = "labelC1";
            this.labelC1.Size = new System.Drawing.Size(149, 85);
            this.labelC1.TabIndex = 1;
            this.labelC1.Text = "Основной цвет";
            this.labelC1.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelC1_DragDrop);
            this.labelC1.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelC1_DragEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelC8);
            this.groupBox2.Controls.Add(this.panelC7);
            this.groupBox2.Controls.Add(this.panelC6);
            this.groupBox2.Controls.Add(this.panelC5);
            this.groupBox2.Controls.Add(this.panelC4);
            this.groupBox2.Controls.Add(this.panelC3);
            this.groupBox2.Controls.Add(this.panelC2);
            this.groupBox2.Controls.Add(this.panelC1);
            this.groupBox2.Location = new System.Drawing.Point(460, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 365);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвета";
            // 
            // panelC8
            // 
            this.panelC8.BackColor = System.Drawing.Color.Gray;
            this.panelC8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelC8.Location = new System.Drawing.Point(112, 291);
            this.panelC8.Name = "panelC8";
            this.panelC8.Size = new System.Drawing.Size(61, 53);
            this.panelC8.TabIndex = 2;
            // 
            // panelC7
            // 
            this.panelC7.BackColor = System.Drawing.Color.Coral;
            this.panelC7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelC7.Location = new System.Drawing.Point(24, 291);
            this.panelC7.Name = "panelC7";
            this.panelC7.Size = new System.Drawing.Size(61, 53);
            this.panelC7.TabIndex = 3;
            // 
            // panelC6
            // 
            this.panelC6.BackColor = System.Drawing.Color.Blue;
            this.panelC6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelC6.Location = new System.Drawing.Point(112, 203);
            this.panelC6.Name = "panelC6";
            this.panelC6.Size = new System.Drawing.Size(61, 53);
            this.panelC6.TabIndex = 1;
            // 
            // panelC5
            // 
            this.panelC5.BackColor = System.Drawing.Color.Yellow;
            this.panelC5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelC5.Location = new System.Drawing.Point(24, 203);
            this.panelC5.Name = "panelC5";
            this.panelC5.Size = new System.Drawing.Size(61, 53);
            this.panelC5.TabIndex = 1;
            // 
            // panelC4
            // 
            this.panelC4.BackColor = System.Drawing.Color.Red;
            this.panelC4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelC4.Location = new System.Drawing.Point(112, 117);
            this.panelC4.Name = "panelC4";
            this.panelC4.Size = new System.Drawing.Size(61, 53);
            this.panelC4.TabIndex = 1;
            // 
            // panelC3
            // 
            this.panelC3.BackColor = System.Drawing.Color.Green;
            this.panelC3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelC3.Location = new System.Drawing.Point(24, 117);
            this.panelC3.Name = "panelC3";
            this.panelC3.Size = new System.Drawing.Size(61, 53);
            this.panelC3.TabIndex = 2;
            // 
            // panelC2
            // 
            this.panelC2.BackColor = System.Drawing.Color.White;
            this.panelC2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelC2.Location = new System.Drawing.Point(112, 31);
            this.panelC2.Name = "panelC2";
            this.panelC2.Size = new System.Drawing.Size(61, 53);
            this.panelC2.TabIndex = 1;
            // 
            // panelC1
            // 
            this.panelC1.BackColor = System.Drawing.Color.Black;
            this.panelC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelC1.Location = new System.Drawing.Point(24, 31);
            this.panelC1.Name = "panelC1";
            this.panelC1.Size = new System.Drawing.Size(61, 53);
            this.panelC1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(40, 277);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(56, 324);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Отмена";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 400);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelC2;
        private System.Windows.Forms.Label labelC1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Panel panelC6;
        private System.Windows.Forms.Panel panelC5;
        private System.Windows.Forms.Panel panelC4;
        private System.Windows.Forms.Panel panelC3;
        private System.Windows.Forms.Panel panelC2;
        private System.Windows.Forms.Panel panelC1;
        private System.Windows.Forms.Panel panelC8;
        private System.Windows.Forms.Panel panelC7;
    }
}