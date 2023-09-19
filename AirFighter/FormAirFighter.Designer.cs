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
            pictureBoxAirFighter = new PictureBox();
            ButtonCreateAirFighter = new Button();
            buttonUp = new Button();
            buttonLeft = new Button();
            buttonDown = new Button();
            buttonRight = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAirFighter).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAirFighter
            // 
            pictureBoxAirFighter.Dock = DockStyle.Fill;
            pictureBoxAirFighter.Location = new Point(0, 0);
            pictureBoxAirFighter.Margin = new Padding(3, 2, 3, 2);
            pictureBoxAirFighter.Name = "pictureBoxAirFighter";
            pictureBoxAirFighter.Size = new Size(869, 422);
            pictureBoxAirFighter.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxAirFighter.TabIndex = 0;
            pictureBoxAirFighter.TabStop = false;
            // 
            // ButtonCreateAirFighter
            // 
            ButtonCreateAirFighter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonCreateAirFighter.Location = new Point(0, 400);
            ButtonCreateAirFighter.Margin = new Padding(3, 2, 3, 2);
            ButtonCreateAirFighter.Name = "ButtonCreateAirFighter";
            ButtonCreateAirFighter.Size = new Size(82, 22);
            ButtonCreateAirFighter.TabIndex = 1;
            ButtonCreateAirFighter.Text = "Создать";
            ButtonCreateAirFighter.UseVisualStyleBackColor = true;
            ButtonCreateAirFighter.Click += ButtonCreateAirFighter_Click;
            // 
            // buttonUp
            // 
            buttonUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUp.BackgroundImage = AirFighter.Properties.Resources.kisspng_up_arrow_computer_icons_arrow_down_clip_art_5af6157c473cb4_0747815015260767962918;
            buttonUp.BackgroundImageLayout = ImageLayout.Zoom;
            buttonUp.Location = new Point(811, 372);
            buttonUp.Margin = new Padding(3, 2, 3, 2);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(26, 22);
            buttonUp.TabIndex = 2;
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += buttonMove_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonLeft.BackgroundImage = AirFighter.Properties.Resources.png_clipart_computer_icons_graphics_arrow_symbol_arrow_angle_desktop_wallpaper;
            buttonLeft.BackgroundImageLayout = ImageLayout.Zoom;
            buttonLeft.Location = new Point(779, 400);
            buttonLeft.Margin = new Padding(3, 2, 3, 2);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(26, 22);
            buttonLeft.TabIndex = 3;
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += buttonMove_Click;
            // 
            // buttonDown
            // 
            buttonDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDown.BackgroundImage = AirFighter.Properties.Resources.png_clipart_computer_icons_uma_musume_pretty_derby_fate_grand_order_saber_kemono_friends_three_arrow_game_angle;
            buttonDown.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDown.Location = new Point(811, 400);
            buttonDown.Margin = new Padding(3, 2, 3, 2);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(26, 22);
            buttonDown.TabIndex = 4;
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += buttonMove_Click;
            // 
            // buttonRight
            // 
            buttonRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRight.BackgroundImage = AirFighter.Properties.Resources.png_transparent_grammatical_person_paper_narration_direzione_didattica_statale_gestione_scuola_elementare_copy_print_right_arrow_miscellaneous_game_angle;
            buttonRight.BackgroundImageLayout = ImageLayout.Zoom;
            buttonRight.Location = new Point(843, 399);
            buttonRight.Margin = new Padding(3, 2, 3, 2);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(26, 22);
            buttonRight.TabIndex = 5;
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += buttonMove_Click;
            // 
            // FormAirFighter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 422);
            Controls.Add(buttonRight);
            Controls.Add(buttonDown);
            Controls.Add(buttonLeft);
            Controls.Add(buttonUp);
            Controls.Add(ButtonCreateAirFighter);
            Controls.Add(pictureBoxAirFighter);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAirFighter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAirFighter";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAirFighter).EndInit();
            ResumeLayout(false);
            PerformLayout();
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