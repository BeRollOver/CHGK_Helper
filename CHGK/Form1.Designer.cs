namespace CHGK
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.sec60 = new System.Windows.Forms.Button();
            this.zn = new System.Windows.Forms.Button();
            this.tl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boom = new System.Windows.Forms.Button();
            this.bigben = new System.Windows.Forms.Button();
            this.sec20 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sec60
            // 
            this.sec60.Location = new System.Drawing.Point(12, 12);
            this.sec60.Name = "sec60";
            this.sec60.Size = new System.Drawing.Size(129, 52);
            this.sec60.TabIndex = 0;
            this.sec60.Text = "60 sec";
            this.sec60.UseVisualStyleBackColor = true;
            this.sec60.Click += new System.EventHandler(this.sec60_Click);
            // 
            // zn
            // 
            this.zn.Location = new System.Drawing.Point(12, 282);
            this.zn.Name = "zn";
            this.zn.Size = new System.Drawing.Size(129, 53);
            this.zn.TabIndex = 1;
            this.zn.Text = "Знатоки";
            this.zn.UseVisualStyleBackColor = true;
            this.zn.Click += new System.EventHandler(this.zn_Click);
            // 
            // tl
            // 
            this.tl.Location = new System.Drawing.Point(147, 282);
            this.tl.Name = "tl";
            this.tl.Size = new System.Drawing.Size(126, 53);
            this.tl.TabIndex = 1;
            this.tl.Text = "Телезрители";
            this.tl.UseVisualStyleBackColor = true;
            this.tl.Click += new System.EventHandler(this.tl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 153);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            this.label1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.label2.Location = new System.Drawing.Point(147, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 153);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            this.label2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label2_Click);
            // 
            // boom
            // 
            this.boom.Location = new System.Drawing.Point(12, 71);
            this.boom.Name = "boom";
            this.boom.Size = new System.Drawing.Size(129, 52);
            this.boom.TabIndex = 3;
            this.boom.Text = "Гонг";
            this.boom.UseVisualStyleBackColor = true;
            this.boom.Click += new System.EventHandler(this.gong_Click);
            // 
            // bigben
            // 
            this.bigben.Location = new System.Drawing.Point(147, 71);
            this.bigben.Name = "bigben";
            this.bigben.Size = new System.Drawing.Size(126, 52);
            this.bigben.TabIndex = 4;
            this.bigben.Text = "Tea";
            this.bigben.UseVisualStyleBackColor = true;
            this.bigben.Click += new System.EventHandler(this.tea_Click);
            // 
            // sec20
            // 
            this.sec20.Location = new System.Drawing.Point(147, 12);
            this.sec20.Name = "sec20";
            this.sec20.Size = new System.Drawing.Size(126, 52);
            this.sec20.TabIndex = 0;
            this.sec20.Text = "20 sec";
            this.sec20.UseVisualStyleBackColor = true;
            this.sec20.Click += new System.EventHandler(this.sec20_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 351);
            this.Controls.Add(this.bigben);
            this.Controls.Add(this.boom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tl);
            this.Controls.Add(this.zn);
            this.Controls.Add(this.sec20);
            this.Controls.Add(this.sec60);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sec60;
        private System.Windows.Forms.Button zn;
        private System.Windows.Forms.Button tl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boom;
        private System.Windows.Forms.Button bigben;
        private System.Windows.Forms.Button sec20;
    }
}

