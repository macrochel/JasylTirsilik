namespace Loader
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.places = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.categorize = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.recomendations = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.items = new System.Windows.Forms.ComboBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statistics = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.head = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.BorderRadius = 10;
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(201)))), ((int)(((byte)(61)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(335, 5);
            this.siticoneControlBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(60, 36);
            this.siticoneControlBox2.TabIndex = 50;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BorderRadius = 10;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(201)))), ((int)(((byte)(61)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(397, 5);
            this.siticoneControlBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(60, 36);
            this.siticoneControlBox1.TabIndex = 51;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // places
            // 
            this.places.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.places.BorderThickness = 1;
            this.places.CheckedState.Parent = this.places;
            this.places.CustomImages.Parent = this.places;
            this.places.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.places.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.places.ForeColor = System.Drawing.Color.White;
            this.places.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.places.HoveredState.Parent = this.places;
            this.places.Location = new System.Drawing.Point(16, 380);
            this.places.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.places.Name = "places";
            this.places.ShadowDecoration.Parent = this.places;
            this.places.Size = new System.Drawing.Size(421, 33);
            this.places.TabIndex = 60;
            this.places.Text = "Узнать места сбора";
            this.places.Click += new System.EventHandler(this.places_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // categorize
            // 
            this.categorize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.categorize.BorderThickness = 1;
            this.categorize.CheckedState.Parent = this.categorize;
            this.categorize.CustomImages.Parent = this.categorize;
            this.categorize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.categorize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorize.ForeColor = System.Drawing.Color.White;
            this.categorize.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.categorize.HoveredState.Parent = this.categorize;
            this.categorize.Location = new System.Drawing.Point(16, 299);
            this.categorize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.categorize.Name = "categorize";
            this.categorize.ShadowDecoration.Parent = this.categorize;
            this.categorize.Size = new System.Drawing.Size(421, 33);
            this.categorize.TabIndex = 62;
            this.categorize.Text = "Категоризация сырья";
            this.categorize.Click += new System.EventHandler(this.categorize_Click);
            // 
            // recomendations
            // 
            this.recomendations.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.recomendations.BorderThickness = 1;
            this.recomendations.CheckedState.Parent = this.recomendations;
            this.recomendations.CustomImages.Parent = this.recomendations;
            this.recomendations.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.recomendations.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recomendations.ForeColor = System.Drawing.Color.White;
            this.recomendations.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.recomendations.HoveredState.Parent = this.recomendations;
            this.recomendations.Location = new System.Drawing.Point(16, 340);
            this.recomendations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.recomendations.Name = "recomendations";
            this.recomendations.ShadowDecoration.Parent = this.recomendations;
            this.recomendations.Size = new System.Drawing.Size(421, 33);
            this.recomendations.TabIndex = 63;
            this.recomendations.Text = "Получить рекомендации";
            this.recomendations.Click += new System.EventHandler(this.recomendations_Click);
            // 
            // items
            // 
            this.items.BackColor = System.Drawing.SystemColors.Window;
            this.items.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.items.FormattingEnabled = true;
            this.items.Items.AddRange(new object[] {
            "Пластик",
            "Макулатура",
            "Металл",
            "Стекло"});
            this.items.Location = new System.Drawing.Point(16, 90);
            this.items.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(424, 24);
            this.items.TabIndex = 65;
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.Window;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output.Location = new System.Drawing.Point(4, 4);
            this.output.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(417, 116);
            this.output.TabIndex = 66;
            this.output.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.output);
            this.panel1.Location = new System.Drawing.Point(16, 142);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 123);
            this.panel1.TabIndex = 67;
            // 
            // statistics
            // 
            this.statistics.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.statistics.BorderThickness = 1;
            this.statistics.CheckedState.Parent = this.statistics;
            this.statistics.CustomImages.Parent = this.statistics;
            this.statistics.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.statistics.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistics.ForeColor = System.Drawing.Color.White;
            this.statistics.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.statistics.HoveredState.Parent = this.statistics;
            this.statistics.Location = new System.Drawing.Point(16, 421);
            this.statistics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statistics.Name = "statistics";
            this.statistics.ShadowDecoration.Parent = this.statistics;
            this.statistics.Size = new System.Drawing.Size(421, 33);
            this.statistics.TabIndex = 69;
            this.statistics.Text = "Статистика моих сборов";
            this.statistics.Click += new System.EventHandler(this.statistics_Click);
            // 
            // head
            // 
            this.head.AutoSize = true;
            this.head.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.head.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(201)))), ((int)(((byte)(61)))));
            this.head.Location = new System.Drawing.Point(16, 66);
            this.head.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(0, 20);
            this.head.TabIndex = 70;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 470);
            this.Controls.Add(this.head);
            this.Controls.Add(this.statistics);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.items);
            this.Controls.Add(this.recomendations);
            this.Controls.Add(this.categorize);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.places);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.siticoneControlBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private Siticone.UI.WinForms.SiticoneRoundedButton places;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Siticone.UI.WinForms.SiticoneRoundedButton recomendations;
        private Siticone.UI.WinForms.SiticoneRoundedButton categorize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.ComboBox items;
        private Siticone.UI.WinForms.SiticoneRoundedButton statistics;
        private System.Windows.Forms.Label head;
    }
}