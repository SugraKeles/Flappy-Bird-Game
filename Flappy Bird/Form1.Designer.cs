namespace Flappy_Bird
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
            this.Flappybird_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Flying_timer1 = new System.Windows.Forms.Timer(this.components);
            this.Falldown_timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pipes_timer1 = new System.Windows.Forms.Timer(this.components);
            this.GameOver_label1 = new System.Windows.Forms.Label();
            this.NewGame_label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Flappybird_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Flappybird_pictureBox1
            // 
            this.Flappybird_pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.Flappybird_pictureBox1.BackgroundImage = global::Flappy_Bird.Properties.Resources.flappy1;
            this.Flappybird_pictureBox1.Location = new System.Drawing.Point(120, 280);
            this.Flappybird_pictureBox1.Name = "Flappybird_pictureBox1";
            this.Flappybird_pictureBox1.Size = new System.Drawing.Size(180, 125);
            this.Flappybird_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flappybird_pictureBox1.TabIndex = 0;
            this.Flappybird_pictureBox1.TabStop = false;
            this.Flappybird_pictureBox1.Click += new System.EventHandler(this.Flappybird_pictureBox1_Click);
            // 
            // Flying_timer1
            // 
            this.Flying_timer1.Enabled = true;
            this.Flying_timer1.Tick += new System.EventHandler(this.Flying_timer1_Tick_1);
            // 
            // Falldown_timer1
            // 
            this.Falldown_timer1.Enabled = true;
            this.Falldown_timer1.Tick += new System.EventHandler(this.Falldown_timer1_Tick);
            // 
            // Pipes_timer1
            // 
            this.Pipes_timer1.Enabled = true;
            this.Pipes_timer1.Interval = 50;
            this.Pipes_timer1.Tick += new System.EventHandler(this.Pipes_timer1_Tick);
            // 
            // GameOver_label1
            // 
            this.GameOver_label1.AutoSize = true;
            this.GameOver_label1.BackColor = System.Drawing.Color.White;
            this.GameOver_label1.Font = new System.Drawing.Font("Onyx", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOver_label1.ForeColor = System.Drawing.Color.Black;
            this.GameOver_label1.Location = new System.Drawing.Point(418, 263);
            this.GameOver_label1.Name = "GameOver_label1";
            this.GameOver_label1.Size = new System.Drawing.Size(201, 67);
            this.GameOver_label1.TabIndex = 1;
            this.GameOver_label1.Text = "GAME OVER";
            this.GameOver_label1.Visible = false;
            // 
            // NewGame_label1
            // 
            this.NewGame_label1.AutoSize = true;
            this.NewGame_label1.BackColor = System.Drawing.Color.Violet;
            this.NewGame_label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewGame_label1.Font = new System.Drawing.Font("Onyx", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGame_label1.ForeColor = System.Drawing.Color.White;
            this.NewGame_label1.Location = new System.Drawing.Point(425, 345);
            this.NewGame_label1.Name = "NewGame_label1";
            this.NewGame_label1.Size = new System.Drawing.Size(190, 69);
            this.NewGame_label1.TabIndex = 2;
            this.NewGame_label1.Text = "NEW GAME";
            this.NewGame_label1.Visible = false;
            this.NewGame_label1.Click += new System.EventHandler(this.NewGame_label1_Click_1);
            this.NewGame_label1.MouseLeave += new System.EventHandler(this.NewGame_label1_MouseLeave_1);
            this.NewGame_label1.MouseHover += new System.EventHandler(this.NewGame_label1_MouseHover_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(217)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(997, 753);
            this.Controls.Add(this.NewGame_label1);
            this.Controls.Add(this.GameOver_label1);
            this.Controls.Add(this.Flappybird_pictureBox1);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            ((System.ComponentModel.ISupportInitialize)(this.Flappybird_pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Flappybird_pictureBox1;
        private System.Windows.Forms.Timer Flying_timer1;
        private System.Windows.Forms.Timer Falldown_timer1;
        private System.Windows.Forms.Timer Pipes_timer1;
        private System.Windows.Forms.Label GameOver_label1;
        private System.Windows.Forms.Label NewGame_label1;
    }
}

