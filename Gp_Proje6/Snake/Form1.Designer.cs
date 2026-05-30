
namespace Snake
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerYilan = new System.Windows.Forms.Timer(this.components);
            this.lbSkor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMesaj = new System.Windows.Forms.Label();
            this.lbSure = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerGecenSure = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 0;
            // 
            // timerYilan
            // 
            this.timerYilan.Tick += new System.EventHandler(this.timerYilan_Tick);
            // 
            // lbSkor
            // 
            this.lbSkor.AutoSize = true;
            this.lbSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSkor.Location = new System.Drawing.Point(473, 516);
            this.lbSkor.Name = "lbSkor";
            this.lbSkor.Size = new System.Drawing.Size(16, 16);
            this.lbSkor.TabIndex = 1;
            this.lbSkor.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(423, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Skor:";
            // 
            // lbMesaj
            // 
            this.lbMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbMesaj.Location = new System.Drawing.Point(0, 550);
            this.lbMesaj.Name = "lbMesaj";
            this.lbMesaj.Size = new System.Drawing.Size(500, 31);
            this.lbMesaj.TabIndex = 1;
            this.lbMesaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSure
            // 
            this.lbSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSure.Location = new System.Drawing.Point(62, 516);
            this.lbSure.Name = "lbSure";
            this.lbSure.Size = new System.Drawing.Size(50, 16);
            this.lbSure.TabIndex = 1;
            this.lbSure.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 516);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Süre:";
            // 
            // timerGecenSure
            // 
            this.timerGecenSure.Interval = 1000;
            this.timerGecenSure.Tick += new System.EventHandler(this.timerGecenSure_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 589);
            this.Controls.Add(this.lbMesaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbSure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSkor);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerYilan;
        private System.Windows.Forms.Label lbSkor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMesaj;
        private System.Windows.Forms.Label lbSure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerGecenSure;
    }
}

