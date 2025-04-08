namespace FlappyBird
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
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox_Bird = new System.Windows.Forms.PictureBox();
            this.pictureBox_pipeUp = new System.Windows.Forms.PictureBox();
            this.pictureBox_pipeDown = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox_Ground = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ground)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Bird
            // 
            this.pictureBox_Bird.Image = global::FlappyBird.Properties.Resources.imgbin_flappy_bird_blue_minecraft_png1;
            this.pictureBox_Bird.Location = new System.Drawing.Point(115, 317);
            this.pictureBox_Bird.Name = "pictureBox_Bird";
            this.pictureBox_Bird.Size = new System.Drawing.Size(78, 58);
            this.pictureBox_Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Bird.TabIndex = 2;
            this.pictureBox_Bird.TabStop = false;
            // 
            // pictureBox_pipeUp
            // 
            this.pictureBox_pipeUp.Image = global::FlappyBird.Properties.Resources.imgbin_mario_pipe_upsidedown_png;
            this.pictureBox_pipeUp.Location = new System.Drawing.Point(1657, -389);
            this.pictureBox_pipeUp.Name = "pictureBox_pipeUp";
            this.pictureBox_pipeUp.Size = new System.Drawing.Size(124, 600);
            this.pictureBox_pipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_pipeUp.TabIndex = 1;
            this.pictureBox_pipeUp.TabStop = false;
            this.pictureBox_pipeUp.Click += new System.EventHandler(this.pictureBox_pipeUp_Click);
            // 
            // pictureBox_pipeDown
            // 
            this.pictureBox_pipeDown.Image = global::FlappyBird.Properties.Resources.imgbin_mario_pipe_png;
            this.pictureBox_pipeDown.Location = new System.Drawing.Point(1657, 421);
            this.pictureBox_pipeDown.Name = "pictureBox_pipeDown";
            this.pictureBox_pipeDown.Size = new System.Drawing.Size(124, 766);
            this.pictureBox_pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_pipeDown.TabIndex = 0;
            this.pictureBox_pipeDown.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // simpleButton1
            // 
            this.simpleButton1.AllowFocus = false;
            this.simpleButton1.Location = new System.Drawing.Point(12, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton1.Size = new System.Drawing.Size(103, 40);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Start";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            this.simpleButton1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.simpleButton1_MouseDoubleClick);
            // 
            // pictureBox_Ground
            // 
            this.pictureBox_Ground.Image = global::FlappyBird.Properties.Resources.kindpng_1153893__1_;
            this.pictureBox_Ground.Location = new System.Drawing.Point(0, 606);
            this.pictureBox_Ground.Name = "pictureBox_Ground";
            this.pictureBox_Ground.Size = new System.Drawing.Size(612, 54);
            this.pictureBox_Ground.TabIndex = 4;
            this.pictureBox_Ground.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(140, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 103);
            this.button1.TabIndex = 5;
            this.button1.Text = "Game Over";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 642);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox_Ground);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.pictureBox_Bird);
            this.Controls.Add(this.pictureBox_pipeUp);
            this.Controls.Add(this.pictureBox_pipeDown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_pipeDown;
        private System.Windows.Forms.PictureBox pictureBox_pipeUp;
        private System.Windows.Forms.PictureBox pictureBox_Bird;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.PictureBox pictureBox_Ground;
        private System.Windows.Forms.Button button1;
    }
}

