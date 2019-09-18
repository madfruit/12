namespace WinForms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelx = new System.Windows.Forms.Label();
            this.labely = new System.Windows.Forms.Label();
            this.labelz = new System.Windows.Forms.Label();
            this.labelr = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.buttoncompute = new System.Windows.Forms.Button();
            this.textBoxx = new System.Windows.Forms.TextBox();
            this.textBoxy = new System.Windows.Forms.TextBox();
            this.textBoxz = new System.Windows.Forms.TextBox();
            this.textBoxr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.BackColor = System.Drawing.Color.Green;
            this.labelx.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelx.Location = new System.Drawing.Point(28, 27);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(18, 23);
            this.labelx.TabIndex = 0;
            this.labelx.Text = "x";
            // 
            // labely
            // 
            this.labely.AutoSize = true;
            this.labely.BackColor = System.Drawing.Color.Green;
            this.labely.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labely.Location = new System.Drawing.Point(28, 69);
            this.labely.Name = "labely";
            this.labely.Size = new System.Drawing.Size(17, 23);
            this.labely.TabIndex = 1;
            this.labely.Text = "y";
            // 
            // labelz
            // 
            this.labelz.AutoSize = true;
            this.labelz.BackColor = System.Drawing.Color.Green;
            this.labelz.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelz.Location = new System.Drawing.Point(28, 118);
            this.labelz.Name = "labelz";
            this.labelz.Size = new System.Drawing.Size(18, 23);
            this.labelz.TabIndex = 2;
            this.labelz.Text = "z";
            // 
            // labelr
            // 
            this.labelr.AutoSize = true;
            this.labelr.BackColor = System.Drawing.Color.Green;
            this.labelr.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelr.Location = new System.Drawing.Point(28, 231);
            this.labelr.Name = "labelr";
            this.labelr.Size = new System.Drawing.Size(15, 23);
            this.labelr.TabIndex = 3;
            this.labelr.Text = "r";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(587, 529);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(185, 23);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Федченков І.Ю, ІПЗ-19-1";
            // 
            // buttoncompute
            // 
            this.buttoncompute.BackColor = System.Drawing.Color.LightBlue;
            this.buttoncompute.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttoncompute.Location = new System.Drawing.Point(96, 166);
            this.buttoncompute.Name = "buttoncompute";
            this.buttoncompute.Size = new System.Drawing.Size(181, 46);
            this.buttoncompute.TabIndex = 5;
            this.buttoncompute.Text = "Обчислити";
            this.buttoncompute.UseVisualStyleBackColor = false;
            this.buttoncompute.Click += new System.EventHandler(this.buttoncompute_Click);
            // 
            // textBoxx
            // 
            this.textBoxx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxx.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxx.Location = new System.Drawing.Point(83, 24);
            this.textBoxx.Name = "textBoxx";
            this.textBoxx.Size = new System.Drawing.Size(206, 29);
            this.textBoxx.TabIndex = 9;
            // 
            // textBoxy
            // 
            this.textBoxy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxy.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxy.Location = new System.Drawing.Point(83, 66);
            this.textBoxy.Name = "textBoxy";
            this.textBoxy.Size = new System.Drawing.Size(206, 29);
            this.textBoxy.TabIndex = 10;
            // 
            // textBoxz
            // 
            this.textBoxz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxz.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxz.Location = new System.Drawing.Point(83, 118);
            this.textBoxz.Name = "textBoxz";
            this.textBoxz.Size = new System.Drawing.Size(206, 29);
            this.textBoxz.TabIndex = 11;
            // 
            // textBoxr
            // 
            this.textBoxr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxr.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxr.Location = new System.Drawing.Point(83, 228);
            this.textBoxr.Name = "textBoxr";
            this.textBoxr.Size = new System.Drawing.Size(206, 29);
            this.textBoxr.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.textBoxr);
            this.Controls.Add(this.textBoxz);
            this.Controls.Add(this.textBoxy);
            this.Controls.Add(this.textBoxx);
            this.Controls.Add(this.buttoncompute);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelr);
            this.Controls.Add(this.labelz);
            this.Controls.Add(this.labely);
            this.Controls.Add(this.labelx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практична робота №2. Завдання 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Label labely;
        private System.Windows.Forms.Label labelz;
        private System.Windows.Forms.Label labelr;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button buttoncompute;
        private System.Windows.Forms.TextBox textBoxx;
        private System.Windows.Forms.TextBox textBoxy;
        private System.Windows.Forms.TextBox textBoxz;
        private System.Windows.Forms.TextBox textBoxr;
    }
}

