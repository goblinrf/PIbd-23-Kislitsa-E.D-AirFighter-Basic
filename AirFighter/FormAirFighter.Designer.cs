namespace ProjectAirFighter
{
    partial class FormAirFighter
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
            this.pictureBoxAirFighter = new System.Windows.Forms.PictureBox();
            this.ButtonCreateAirFighter = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirFighter)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAirFighter
            // 
            this.pictureBoxAirFighter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAirFighter.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAirFighter.Name = "pictureBoxAirFighter";
            this.pictureBoxAirFighter.Size = new System.Drawing.Size(882, 453);
            this.pictureBoxAirFighter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxAirFighter.TabIndex = 0;
            this.pictureBoxAirFighter.TabStop = false;
            // 
            // ButtonCreateAirFighter
            // 
            this.ButtonCreateAirFighter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonCreateAirFighter.Location = new System.Drawing.Point(0, 424);
            this.ButtonCreateAirFighter.Name = "ButtonCreateAirFighter";
            this.ButtonCreateAirFighter.Size = new System.Drawing.Size(94, 29);
            this.ButtonCreateAirFighter.TabIndex = 1;
            this.ButtonCreateAirFighter.Text = "Создать";
            this.ButtonCreateAirFighter.UseVisualStyleBackColor = true;
            this.ButtonCreateAirFighter.Click += new System.EventHandler(this.ButtonCreateAirFighter_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::AirFighter.Properties.Resources.kisspng_up_arrow_computer_icons_arrow_down_clip_art_5af6157c473cb4_0747815015260767962918;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(816, 387);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::AirFighter.Properties.Resources.png_clipart_computer_icons_graphics_arrow_symbol_arrow_angle_desktop_wallpaper;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(780, 424);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::AirFighter.Properties.Resources.png_clipart_computer_icons_uma_musume_pretty_derby_fate_grand_order_saber_kemono_friends_three_arrow_game_angle;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(816, 424);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::AirFighter.Properties.Resources.png_transparent_grammatical_person_paper_narration_direzione_didattica_statale_gestione_scuola_elementare_copy_print_right_arrow_miscellaneous_game_angle;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(852, 423);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // FormAirFighter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.ButtonCreateAirFighter);
            this.Controls.Add(this.pictureBoxAirFighter);
            this.Name = "FormAirFighter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAirFighter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirFighter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxAirFighter;
        private Button ButtonCreateAirFighter;
        private Button buttonUp;
        private Button buttonLeft;
        private Button buttonDown;
        private Button buttonRight;
    }
}