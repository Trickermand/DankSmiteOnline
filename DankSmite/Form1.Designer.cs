//#define Live
using System.Drawing;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace DankSmite
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
            this.button1 = new System.Windows.Forms.Button();
            this.ItemLabel1 = new System.Windows.Forms.Label();
            this.ItemLabel2 = new System.Windows.Forms.Label();
            this.ItemLabel3 = new System.Windows.Forms.Label();
            this.ItemLabel4 = new System.Windows.Forms.Label();
            this.ItemLabel5 = new System.Windows.Forms.Label();
            this.ItemLabel6 = new System.Windows.Forms.Label();
            this.RelicLabel2 = new System.Windows.Forms.Label();
            this.RelicLabel1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GodPicture = new System.Windows.Forms.PictureBox();
            this.ItemPicture1 = new System.Windows.Forms.PictureBox();
            this.ItemPicture2 = new System.Windows.Forms.PictureBox();
            this.ItemPicture3 = new System.Windows.Forms.PictureBox();
            this.ItemPicture4 = new System.Windows.Forms.PictureBox();
            this.ItemPicture5 = new System.Windows.Forms.PictureBox();
            this.ItemPicture6 = new System.Windows.Forms.PictureBox();
            this.RelicPicture1 = new System.Windows.Forms.PictureBox();
            this.RelicPicture2 = new System.Windows.Forms.PictureBox();
            this.RerollLabel = new System.Windows.Forms.Label();
            this.RerollNumber = new System.Windows.Forms.Label();
            this.TextInput = new System.Windows.Forms.TextBox();
            this.StarterItemPicture = new System.Windows.Forms.PictureBox();
            this.StarterItemLabel = new System.Windows.Forms.Label();
            this.CurrentItemNameLabel = new System.Windows.Forms.Label();
            this.GodLabel = new System.Windows.Forms.Label();
            this.CreditsButon = new System.Windows.Forms.Button();
            this.GeneralTextBox = new System.Windows.Forms.Label();
            this.WelcomeButton = new System.Windows.Forms.Button();
            this.MageCheckBox = new System.Windows.Forms.CheckBox();
            this.GuardianCheckBox = new System.Windows.Forms.CheckBox();
            this.HunterCheckBox = new System.Windows.Forms.CheckBox();
            this.WarriorCheckBox = new System.Windows.Forms.CheckBox();
            this.AssassinCheckBox = new System.Windows.Forms.CheckBox();
            this.DefenseCheckBox = new System.Windows.Forms.CheckBox();
            this.HybridCheckBox = new System.Windows.Forms.CheckBox();
            this.DamageCheckBox = new System.Windows.Forms.CheckBox();
            this.MagicalLabel = new System.Windows.Forms.Label();
            this.PhysicalLabel = new System.Windows.Forms.Label();
            this.ItemIntensityLabel = new System.Windows.Forms.Label();
            this.CheckBoxGroup = new System.Windows.Forms.GroupBox();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.DropDownMenu = new System.Windows.Forms.ComboBox();
            this.Settings = new System.Windows.Forms.ListBox();
            this.SettingsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GodPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelicPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelicPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StarterItemPicture)).BeginInit();
            this.CheckBoxGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("DejaVu Serif Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(534, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Build!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BuildButton);
            // 
            // ItemLabel1
            // 
            this.ItemLabel1.AutoSize = true;
            this.ItemLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ItemLabel1.Font = new System.Drawing.Font("Baskerville Old Face", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemLabel1.ForeColor = System.Drawing.Color.White;
            this.ItemLabel1.Image = global::DankSmite.Properties.Resources.FrameItem;
            this.ItemLabel1.Location = new System.Drawing.Point(578, 388);
            this.ItemLabel1.MinimumSize = new System.Drawing.Size(72, 29);
            this.ItemLabel1.Name = "ItemLabel1";
            this.ItemLabel1.Size = new System.Drawing.Size(72, 29);
            this.ItemLabel1.TabIndex = 1;
            this.ItemLabel1.Text = "Item 1";
            this.ItemLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ItemLabel1.Visible = false;
            // 
            // ItemLabel2
            // 
            this.ItemLabel2.AutoSize = true;
            this.ItemLabel2.BackColor = System.Drawing.Color.Transparent;
            this.ItemLabel2.Font = new System.Drawing.Font("Baskerville Old Face", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemLabel2.ForeColor = System.Drawing.Color.White;
            this.ItemLabel2.Image = ((System.Drawing.Image)(resources.GetObject("ItemLabel2.Image")));
            this.ItemLabel2.Location = new System.Drawing.Point(700, 388);
            this.ItemLabel2.MinimumSize = new System.Drawing.Size(72, 29);
            this.ItemLabel2.Name = "ItemLabel2";
            this.ItemLabel2.Size = new System.Drawing.Size(72, 29);
            this.ItemLabel2.TabIndex = 2;
            this.ItemLabel2.Text = "Item 2";
            this.ItemLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ItemLabel2.Visible = false;
            // 
            // ItemLabel3
            // 
            this.ItemLabel3.AutoSize = true;
            this.ItemLabel3.BackColor = System.Drawing.Color.Transparent;
            this.ItemLabel3.Font = new System.Drawing.Font("Baskerville Old Face", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemLabel3.ForeColor = System.Drawing.Color.White;
            this.ItemLabel3.Image = ((System.Drawing.Image)(resources.GetObject("ItemLabel3.Image")));
            this.ItemLabel3.Location = new System.Drawing.Point(822, 388);
            this.ItemLabel3.MinimumSize = new System.Drawing.Size(72, 29);
            this.ItemLabel3.Name = "ItemLabel3";
            this.ItemLabel3.Size = new System.Drawing.Size(72, 29);
            this.ItemLabel3.TabIndex = 3;
            this.ItemLabel3.Text = "Item 3";
            this.ItemLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ItemLabel3.Visible = false;
            // 
            // ItemLabel4
            // 
            this.ItemLabel4.AutoSize = true;
            this.ItemLabel4.BackColor = System.Drawing.Color.Transparent;
            this.ItemLabel4.Font = new System.Drawing.Font("Baskerville Old Face", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemLabel4.ForeColor = System.Drawing.Color.White;
            this.ItemLabel4.Image = ((System.Drawing.Image)(resources.GetObject("ItemLabel4.Image")));
            this.ItemLabel4.Location = new System.Drawing.Point(578, 521);
            this.ItemLabel4.MinimumSize = new System.Drawing.Size(72, 29);
            this.ItemLabel4.Name = "ItemLabel4";
            this.ItemLabel4.Size = new System.Drawing.Size(72, 29);
            this.ItemLabel4.TabIndex = 4;
            this.ItemLabel4.Text = "Item 4";
            this.ItemLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ItemLabel4.Visible = false;
            // 
            // ItemLabel5
            // 
            this.ItemLabel5.AutoSize = true;
            this.ItemLabel5.BackColor = System.Drawing.Color.Transparent;
            this.ItemLabel5.Font = new System.Drawing.Font("Baskerville Old Face", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemLabel5.ForeColor = System.Drawing.Color.White;
            this.ItemLabel5.Image = ((System.Drawing.Image)(resources.GetObject("ItemLabel5.Image")));
            this.ItemLabel5.Location = new System.Drawing.Point(700, 521);
            this.ItemLabel5.MinimumSize = new System.Drawing.Size(72, 29);
            this.ItemLabel5.Name = "ItemLabel5";
            this.ItemLabel5.Size = new System.Drawing.Size(72, 29);
            this.ItemLabel5.TabIndex = 5;
            this.ItemLabel5.Text = "Item 5";
            this.ItemLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ItemLabel5.Visible = false;
            // 
            // ItemLabel6
            // 
            this.ItemLabel6.AutoSize = true;
            this.ItemLabel6.BackColor = System.Drawing.Color.Transparent;
            this.ItemLabel6.Font = new System.Drawing.Font("Baskerville Old Face", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemLabel6.ForeColor = System.Drawing.Color.White;
            this.ItemLabel6.Image = ((System.Drawing.Image)(resources.GetObject("ItemLabel6.Image")));
            this.ItemLabel6.Location = new System.Drawing.Point(822, 521);
            this.ItemLabel6.MinimumSize = new System.Drawing.Size(72, 29);
            this.ItemLabel6.Name = "ItemLabel6";
            this.ItemLabel6.Size = new System.Drawing.Size(72, 29);
            this.ItemLabel6.TabIndex = 6;
            this.ItemLabel6.Text = "Item 6";
            this.ItemLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ItemLabel6.Visible = false;
            // 
            // RelicLabel2
            // 
            this.RelicLabel2.AutoSize = true;
            this.RelicLabel2.BackColor = System.Drawing.Color.Transparent;
            this.RelicLabel2.Font = new System.Drawing.Font("Baskerville Old Face", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelicLabel2.ForeColor = System.Drawing.Color.White;
            this.RelicLabel2.Image = ((System.Drawing.Image)(resources.GetObject("RelicLabel2.Image")));
            this.RelicLabel2.Location = new System.Drawing.Point(439, 521);
            this.RelicLabel2.MinimumSize = new System.Drawing.Size(76, 29);
            this.RelicLabel2.Name = "RelicLabel2";
            this.RelicLabel2.Size = new System.Drawing.Size(76, 29);
            this.RelicLabel2.TabIndex = 7;
            this.RelicLabel2.Text = "Relic 2";
            this.RelicLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RelicLabel2.Visible = false;
            // 
            // RelicLabel1
            // 
            this.RelicLabel1.AutoSize = true;
            this.RelicLabel1.BackColor = System.Drawing.Color.Transparent;
            this.RelicLabel1.Font = new System.Drawing.Font("Baskerville Old Face", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelicLabel1.ForeColor = System.Drawing.Color.White;
            this.RelicLabel1.Image = ((System.Drawing.Image)(resources.GetObject("RelicLabel1.Image")));
            this.RelicLabel1.Location = new System.Drawing.Point(321, 521);
            this.RelicLabel1.MinimumSize = new System.Drawing.Size(76, 29);
            this.RelicLabel1.Name = "RelicLabel1";
            this.RelicLabel1.Size = new System.Drawing.Size(76, 29);
            this.RelicLabel1.TabIndex = 8;
            this.RelicLabel1.Text = "Relic 1";
            this.RelicLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RelicLabel1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Baskerville Old Face", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(80, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "God";
            this.label9.Visible = false;
            // 
            // GodPicture
            // 
            this.GodPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GodPicture.Enabled = false;
            this.GodPicture.Location = new System.Drawing.Point(39, 85);
            this.GodPicture.Name = "GodPicture";
            this.GodPicture.Size = new System.Drawing.Size(128, 128);
            this.GodPicture.TabIndex = 17;
            this.GodPicture.TabStop = false;
            this.GodPicture.Visible = false;
            this.GodPicture.Click += new System.EventHandler(this.godPictureBox_Click);
            this.GodPicture.DoubleClick += new System.EventHandler(this.godPictureBox_Click);
            // 
            // ItemPicture1
            // 
            this.ItemPicture1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemPicture1.Enabled = false;
            this.ItemPicture1.Location = new System.Drawing.Point(567, 420);
            this.ItemPicture1.Name = "ItemPicture1";
            this.ItemPicture1.Size = new System.Drawing.Size(92, 92);
            this.ItemPicture1.TabIndex = 9;
            this.ItemPicture1.TabStop = false;
            this.ItemPicture1.Visible = false;
            this.ItemPicture1.Click += new System.EventHandler(this.ItemPicture1_Click);
            this.ItemPicture1.DoubleClick += new System.EventHandler(this.ItemPicture1_Click);
            this.ItemPicture1.MouseEnter += new System.EventHandler(this.pictureBox1_Hover);
            this.ItemPicture1.MouseLeave += new System.EventHandler(this.ClearLabels);
            // 
            // ItemPicture2
            // 
            this.ItemPicture2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemPicture2.Enabled = false;
            this.ItemPicture2.Location = new System.Drawing.Point(690, 420);
            this.ItemPicture2.Name = "ItemPicture2";
            this.ItemPicture2.Size = new System.Drawing.Size(92, 92);
            this.ItemPicture2.TabIndex = 22;
            this.ItemPicture2.TabStop = false;
            this.ItemPicture2.Visible = false;
            this.ItemPicture2.Click += new System.EventHandler(this.ItemPicture2_Click);
            this.ItemPicture2.DoubleClick += new System.EventHandler(this.ItemPicture2_Click);
            this.ItemPicture2.MouseEnter += new System.EventHandler(this.pictureBox2_Hover);
            this.ItemPicture2.MouseLeave += new System.EventHandler(this.ClearLabels);
            // 
            // ItemPicture3
            // 
            this.ItemPicture3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemPicture3.Enabled = false;
            this.ItemPicture3.Location = new System.Drawing.Point(813, 420);
            this.ItemPicture3.Name = "ItemPicture3";
            this.ItemPicture3.Size = new System.Drawing.Size(92, 92);
            this.ItemPicture3.TabIndex = 20;
            this.ItemPicture3.TabStop = false;
            this.ItemPicture3.Visible = false;
            this.ItemPicture3.Click += new System.EventHandler(this.ItemPicture3_Click);
            this.ItemPicture3.DoubleClick += new System.EventHandler(this.ItemPicture3_Click);
            this.ItemPicture3.MouseEnter += new System.EventHandler(this.pictureBox3_Hover);
            this.ItemPicture3.MouseLeave += new System.EventHandler(this.ClearLabels);
            // 
            // ItemPicture4
            // 
            this.ItemPicture4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemPicture4.Enabled = false;
            this.ItemPicture4.Location = new System.Drawing.Point(567, 553);
            this.ItemPicture4.Name = "ItemPicture4";
            this.ItemPicture4.Size = new System.Drawing.Size(92, 92);
            this.ItemPicture4.TabIndex = 23;
            this.ItemPicture4.TabStop = false;
            this.ItemPicture4.Visible = false;
            this.ItemPicture4.Click += new System.EventHandler(this.ItemPicture4_Click);
            this.ItemPicture4.DoubleClick += new System.EventHandler(this.ItemPicture4_Click);
            this.ItemPicture4.MouseEnter += new System.EventHandler(this.pictureBox4_Hover);
            this.ItemPicture4.MouseLeave += new System.EventHandler(this.ClearLabels);
            // 
            // ItemPicture5
            // 
            this.ItemPicture5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemPicture5.Enabled = false;
            this.ItemPicture5.Location = new System.Drawing.Point(690, 553);
            this.ItemPicture5.Name = "ItemPicture5";
            this.ItemPicture5.Size = new System.Drawing.Size(92, 92);
            this.ItemPicture5.TabIndex = 21;
            this.ItemPicture5.TabStop = false;
            this.ItemPicture5.Visible = false;
            this.ItemPicture5.Click += new System.EventHandler(this.ItemPicture5_Click);
            this.ItemPicture5.DoubleClick += new System.EventHandler(this.ItemPicture5_Click);
            this.ItemPicture5.MouseEnter += new System.EventHandler(this.pictureBox5_Hover);
            this.ItemPicture5.MouseLeave += new System.EventHandler(this.ClearLabels);
            // 
            // ItemPicture6
            // 
            this.ItemPicture6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemPicture6.Enabled = false;
            this.ItemPicture6.Location = new System.Drawing.Point(813, 553);
            this.ItemPicture6.Name = "ItemPicture6";
            this.ItemPicture6.Size = new System.Drawing.Size(92, 92);
            this.ItemPicture6.TabIndex = 19;
            this.ItemPicture6.TabStop = false;
            this.ItemPicture6.Visible = false;
            this.ItemPicture6.Click += new System.EventHandler(this.ItemPicture6_Click);
            this.ItemPicture6.DoubleClick += new System.EventHandler(this.ItemPicture6_Click);
            this.ItemPicture6.MouseEnter += new System.EventHandler(this.pictureBox6_Hover);
            this.ItemPicture6.MouseLeave += new System.EventHandler(this.ClearLabels);
            // 
            // RelicPicture1
            // 
            this.RelicPicture1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RelicPicture1.Enabled = false;
            this.RelicPicture1.Location = new System.Drawing.Point(310, 553);
            this.RelicPicture1.Name = "RelicPicture1";
            this.RelicPicture1.Size = new System.Drawing.Size(92, 92);
            this.RelicPicture1.TabIndex = 25;
            this.RelicPicture1.TabStop = false;
            this.RelicPicture1.Visible = false;
            this.RelicPicture1.Click += new System.EventHandler(this.RelicPicture1_Click);
            this.RelicPicture1.DoubleClick += new System.EventHandler(this.RelicPicture1_Click);
            this.RelicPicture1.MouseEnter += new System.EventHandler(this.Relic1_Hover);
            this.RelicPicture1.MouseLeave += new System.EventHandler(this.ClearLabels);
            // 
            // RelicPicture2
            // 
            this.RelicPicture2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RelicPicture2.Enabled = false;
            this.RelicPicture2.Location = new System.Drawing.Point(433, 553);
            this.RelicPicture2.Name = "RelicPicture2";
            this.RelicPicture2.Size = new System.Drawing.Size(92, 92);
            this.RelicPicture2.TabIndex = 24;
            this.RelicPicture2.TabStop = false;
            this.RelicPicture2.Visible = false;
            this.RelicPicture2.Click += new System.EventHandler(this.RelicPicture2_Click);
            this.RelicPicture2.DoubleClick += new System.EventHandler(this.RelicPicture2_Click);
            this.RelicPicture2.MouseEnter += new System.EventHandler(this.Relic2_Hover);
            this.RelicPicture2.MouseLeave += new System.EventHandler(this.ClearLabels);
            // 
            // RerollLabel
            // 
            this.RerollLabel.AutoSize = true;
            this.RerollLabel.BackColor = System.Drawing.Color.Transparent;
            this.RerollLabel.Font = new System.Drawing.Font("Baskerville Old Face", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RerollLabel.ForeColor = System.Drawing.Color.White;
            this.RerollLabel.Image = global::DankSmite.Properties.Resources.FrameRerollsUsed;
            this.RerollLabel.Location = new System.Drawing.Point(38, 243);
            this.RerollLabel.MinimumSize = new System.Drawing.Size(128, 29);
            this.RerollLabel.Name = "RerollLabel";
            this.RerollLabel.Size = new System.Drawing.Size(128, 29);
            this.RerollLabel.TabIndex = 36;
            this.RerollLabel.Text = "Rerolls Used";
            this.RerollLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RerollLabel.Visible = false;
            // 
            // RerollNumber
            // 
            this.RerollNumber.AutoSize = true;
            this.RerollNumber.BackColor = System.Drawing.Color.Transparent;
            this.RerollNumber.Font = new System.Drawing.Font("Baskerville Old Face", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RerollNumber.ForeColor = System.Drawing.Color.White;
            this.RerollNumber.Image = global::DankSmite.Properties.Resources.FrameRerollCounter;
            this.RerollNumber.Location = new System.Drawing.Point(53, 276);
            this.RerollNumber.MinimumSize = new System.Drawing.Size(102, 60);
            this.RerollNumber.Name = "RerollNumber";
            this.RerollNumber.Size = new System.Drawing.Size(102, 60);
            this.RerollNumber.TabIndex = 37;
            this.RerollNumber.Text = "0";
            this.RerollNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RerollNumber.Visible = false;
            // 
            // TextInput
            // 
            this.TextInput.BackColor = System.Drawing.Color.White;
            this.TextInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextInput.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextInput.Location = new System.Drawing.Point(747, 71);
            this.TextInput.MaxLength = 32;
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(165, 26);
            this.TextInput.TabIndex = 38;
            this.TextInput.Text = "God Name";
            this.TextInput.Click += new System.EventHandler(this.TextInput_Click);
            this.TextInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextInput_KeyPress);
            // 
            // StarterItemPicture
            // 
            this.StarterItemPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StarterItemPicture.Enabled = false;
            this.StarterItemPicture.Location = new System.Drawing.Point(370, 420);
            this.StarterItemPicture.Name = "StarterItemPicture";
            this.StarterItemPicture.Size = new System.Drawing.Size(92, 92);
            this.StarterItemPicture.TabIndex = 40;
            this.StarterItemPicture.TabStop = false;
            this.StarterItemPicture.Visible = false;
            this.StarterItemPicture.Click += new System.EventHandler(this.StarterItemPicture_Click);
            this.StarterItemPicture.DoubleClick += new System.EventHandler(this.StarterItemPicture_Click);
            this.StarterItemPicture.MouseEnter += new System.EventHandler(this.StarterItemPicture_Hover);
            this.StarterItemPicture.MouseLeave += new System.EventHandler(this.ClearLabels);
            // 
            // StarterItemLabel
            // 
            this.StarterItemLabel.AutoSize = true;
            this.StarterItemLabel.BackColor = System.Drawing.Color.Transparent;
            this.StarterItemLabel.Font = new System.Drawing.Font("Baskerville Old Face", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarterItemLabel.ForeColor = System.Drawing.Color.White;
            this.StarterItemLabel.Image = global::DankSmite.Properties.Resources.FrameStarterItem;
            this.StarterItemLabel.Location = new System.Drawing.Point(356, 388);
            this.StarterItemLabel.Margin = new System.Windows.Forms.Padding(0);
            this.StarterItemLabel.MinimumSize = new System.Drawing.Size(119, 29);
            this.StarterItemLabel.Name = "StarterItemLabel";
            this.StarterItemLabel.Size = new System.Drawing.Size(119, 29);
            this.StarterItemLabel.TabIndex = 41;
            this.StarterItemLabel.Text = "Starter Item";
            this.StarterItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StarterItemLabel.Visible = false;
            // 
            // CurrentItemNameLabel
            // 
            this.CurrentItemNameLabel.AutoSize = true;
            this.CurrentItemNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentItemNameLabel.Enabled = false;
            this.CurrentItemNameLabel.Font = new System.Drawing.Font("Baskerville Old Face", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentItemNameLabel.ForeColor = System.Drawing.Color.White;
            this.CurrentItemNameLabel.Image = global::DankSmite.Properties.Resources.FrameCurrentItemText;
            this.CurrentItemNameLabel.Location = new System.Drawing.Point(592, 349);
            this.CurrentItemNameLabel.MinimumSize = new System.Drawing.Size(289, 29);
            this.CurrentItemNameLabel.Name = "CurrentItemNameLabel";
            this.CurrentItemNameLabel.Size = new System.Drawing.Size(289, 29);
            this.CurrentItemNameLabel.TabIndex = 42;
            this.CurrentItemNameLabel.Text = " ";
            this.CurrentItemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CurrentItemNameLabel.Visible = false;
            // 
            // GodLabel
            // 
            this.GodLabel.AutoSize = true;
            this.GodLabel.BackColor = System.Drawing.Color.Transparent;
            this.GodLabel.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GodLabel.ForeColor = System.Drawing.Color.White;
            this.GodLabel.Image = global::DankSmite.Properties.Resources.FrameGodName;
            this.GodLabel.Location = new System.Drawing.Point(191, 130);
            this.GodLabel.MinimumSize = new System.Drawing.Size(276, 43);
            this.GodLabel.Name = "GodLabel";
            this.GodLabel.Size = new System.Drawing.Size(276, 43);
            this.GodLabel.TabIndex = 43;
            this.GodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GodLabel.Visible = false;
            // 
            // CreditsButon
            // 
            this.CreditsButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreditsButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditsButon.Location = new System.Drawing.Point(39, 622);
            this.CreditsButon.Name = "CreditsButon";
            this.CreditsButon.Size = new System.Drawing.Size(75, 23);
            this.CreditsButon.TabIndex = 44;
            this.CreditsButon.Text = "Credits";
            this.CreditsButon.UseVisualStyleBackColor = true;
            this.CreditsButon.Click += new System.EventHandler(this.CreditsButon_Click);
            // 
            // GeneralTextBox
            // 
            this.GeneralTextBox.AutoSize = true;
            this.GeneralTextBox.BackColor = System.Drawing.Color.Transparent;
            this.GeneralTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GeneralTextBox.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneralTextBox.ForeColor = System.Drawing.Color.White;
            this.GeneralTextBox.Image = global::DankSmite.Properties.Resources.FrameGeneralText;
            this.GeneralTextBox.Location = new System.Drawing.Point(188, 36);
            this.GeneralTextBox.MaximumSize = new System.Drawing.Size(300, 300);
            this.GeneralTextBox.MinimumSize = new System.Drawing.Size(300, 300);
            this.GeneralTextBox.Name = "GeneralTextBox";
            this.GeneralTextBox.Size = new System.Drawing.Size(300, 300);
            this.GeneralTextBox.TabIndex = 46;
            this.GeneralTextBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WelcomeButton
            // 
            this.WelcomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WelcomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeButton.Location = new System.Drawing.Point(39, 553);
            this.WelcomeButton.Name = "WelcomeButton";
            this.WelcomeButton.Size = new System.Drawing.Size(75, 23);
            this.WelcomeButton.TabIndex = 47;
            this.WelcomeButton.Text = "Welcome!";
            this.WelcomeButton.UseVisualStyleBackColor = true;
            this.WelcomeButton.Click += new System.EventHandler(this.WelcomeButton_Click);
            // 
            // MageCheckBox
            // 
            this.MageCheckBox.AutoSize = true;
            this.MageCheckBox.BackColor = System.Drawing.Color.SkyBlue;
            this.MageCheckBox.Checked = true;
            this.MageCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MageCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MageCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MageCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.MageCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.MageCheckBox.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MageCheckBox.Location = new System.Drawing.Point(6, 101);
            this.MageCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.MageCheckBox.Name = "MageCheckBox";
            this.MageCheckBox.Padding = new System.Windows.Forms.Padding(1);
            this.MageCheckBox.Size = new System.Drawing.Size(61, 20);
            this.MageCheckBox.TabIndex = 48;
            this.MageCheckBox.Text = "Mage";
            this.MageCheckBox.UseVisualStyleBackColor = false;
            // 
            // GuardianCheckBox
            // 
            this.GuardianCheckBox.AutoSize = true;
            this.GuardianCheckBox.BackColor = System.Drawing.Color.SkyBlue;
            this.GuardianCheckBox.Checked = true;
            this.GuardianCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GuardianCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardianCheckBox.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardianCheckBox.Location = new System.Drawing.Point(6, 72);
            this.GuardianCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.GuardianCheckBox.Name = "GuardianCheckBox";
            this.GuardianCheckBox.Padding = new System.Windows.Forms.Padding(1);
            this.GuardianCheckBox.Size = new System.Drawing.Size(87, 20);
            this.GuardianCheckBox.TabIndex = 49;
            this.GuardianCheckBox.Text = "Guardian";
            this.GuardianCheckBox.UseVisualStyleBackColor = false;
            // 
            // HunterCheckBox
            // 
            this.HunterCheckBox.AutoSize = true;
            this.HunterCheckBox.BackColor = System.Drawing.Color.SkyBlue;
            this.HunterCheckBox.Checked = true;
            this.HunterCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HunterCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HunterCheckBox.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HunterCheckBox.Location = new System.Drawing.Point(116, 72);
            this.HunterCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.HunterCheckBox.Name = "HunterCheckBox";
            this.HunterCheckBox.Padding = new System.Windows.Forms.Padding(1);
            this.HunterCheckBox.Size = new System.Drawing.Size(73, 20);
            this.HunterCheckBox.TabIndex = 50;
            this.HunterCheckBox.Text = "Hunter";
            this.HunterCheckBox.UseVisualStyleBackColor = false;
            // 
            // WarriorCheckBox
            // 
            this.WarriorCheckBox.AutoSize = true;
            this.WarriorCheckBox.BackColor = System.Drawing.Color.SkyBlue;
            this.WarriorCheckBox.Checked = true;
            this.WarriorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WarriorCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WarriorCheckBox.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarriorCheckBox.Location = new System.Drawing.Point(117, 128);
            this.WarriorCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.WarriorCheckBox.Name = "WarriorCheckBox";
            this.WarriorCheckBox.Padding = new System.Windows.Forms.Padding(1);
            this.WarriorCheckBox.Size = new System.Drawing.Size(80, 20);
            this.WarriorCheckBox.TabIndex = 51;
            this.WarriorCheckBox.Text = "Warrior";
            this.WarriorCheckBox.UseVisualStyleBackColor = false;
            // 
            // AssassinCheckBox
            // 
            this.AssassinCheckBox.AutoSize = true;
            this.AssassinCheckBox.BackColor = System.Drawing.Color.SkyBlue;
            this.AssassinCheckBox.Checked = true;
            this.AssassinCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AssassinCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AssassinCheckBox.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssassinCheckBox.Location = new System.Drawing.Point(117, 99);
            this.AssassinCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.AssassinCheckBox.Name = "AssassinCheckBox";
            this.AssassinCheckBox.Padding = new System.Windows.Forms.Padding(1);
            this.AssassinCheckBox.Size = new System.Drawing.Size(81, 20);
            this.AssassinCheckBox.TabIndex = 52;
            this.AssassinCheckBox.Text = "Assassin";
            this.AssassinCheckBox.UseVisualStyleBackColor = false;
            // 
            // DefenseCheckBox
            // 
            this.DefenseCheckBox.AutoSize = true;
            this.DefenseCheckBox.BackColor = System.Drawing.Color.SkyBlue;
            this.DefenseCheckBox.Checked = true;
            this.DefenseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefenseCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DefenseCheckBox.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefenseCheckBox.Location = new System.Drawing.Point(268, 132);
            this.DefenseCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.DefenseCheckBox.Name = "DefenseCheckBox";
            this.DefenseCheckBox.Padding = new System.Windows.Forms.Padding(1);
            this.DefenseCheckBox.Size = new System.Drawing.Size(79, 20);
            this.DefenseCheckBox.TabIndex = 55;
            this.DefenseCheckBox.Text = "Defense";
            this.DefenseCheckBox.UseVisualStyleBackColor = false;
            // 
            // HybridCheckBox
            // 
            this.HybridCheckBox.AutoSize = true;
            this.HybridCheckBox.BackColor = System.Drawing.Color.SkyBlue;
            this.HybridCheckBox.Checked = true;
            this.HybridCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HybridCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HybridCheckBox.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HybridCheckBox.Location = new System.Drawing.Point(268, 101);
            this.HybridCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.HybridCheckBox.Name = "HybridCheckBox";
            this.HybridCheckBox.Padding = new System.Windows.Forms.Padding(1);
            this.HybridCheckBox.Size = new System.Drawing.Size(72, 20);
            this.HybridCheckBox.TabIndex = 54;
            this.HybridCheckBox.Text = "Hybrid";
            this.HybridCheckBox.UseVisualStyleBackColor = false;
            // 
            // DamageCheckBox
            // 
            this.DamageCheckBox.AutoSize = true;
            this.DamageCheckBox.BackColor = System.Drawing.Color.SkyBlue;
            this.DamageCheckBox.Checked = true;
            this.DamageCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DamageCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DamageCheckBox.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DamageCheckBox.Location = new System.Drawing.Point(268, 72);
            this.DamageCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.DamageCheckBox.Name = "DamageCheckBox";
            this.DamageCheckBox.Padding = new System.Windows.Forms.Padding(1);
            this.DamageCheckBox.Size = new System.Drawing.Size(77, 20);
            this.DamageCheckBox.TabIndex = 53;
            this.DamageCheckBox.Text = "Damage";
            this.DamageCheckBox.UseVisualStyleBackColor = false;
            // 
            // MagicalLabel
            // 
            this.MagicalLabel.AutoSize = true;
            this.MagicalLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.MagicalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MagicalLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MagicalLabel.Font = new System.Drawing.Font("Baskerville Old Face", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MagicalLabel.ForeColor = System.Drawing.Color.Maroon;
            this.MagicalLabel.Location = new System.Drawing.Point(6, 35);
            this.MagicalLabel.Name = "MagicalLabel";
            this.MagicalLabel.Padding = new System.Windows.Forms.Padding(2);
            this.MagicalLabel.Size = new System.Drawing.Size(85, 29);
            this.MagicalLabel.TabIndex = 56;
            this.MagicalLabel.Text = "Magical";
            this.MagicalLabel.Click += new System.EventHandler(this.MagicalLabel_Click);
            this.MagicalLabel.DoubleClick += new System.EventHandler(this.MagicalLabel_Click);
            // 
            // PhysicalLabel
            // 
            this.PhysicalLabel.AutoSize = true;
            this.PhysicalLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.PhysicalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhysicalLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PhysicalLabel.Font = new System.Drawing.Font("Baskerville Old Face", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhysicalLabel.ForeColor = System.Drawing.Color.Maroon;
            this.PhysicalLabel.Location = new System.Drawing.Point(117, 36);
            this.PhysicalLabel.Name = "PhysicalLabel";
            this.PhysicalLabel.Padding = new System.Windows.Forms.Padding(2);
            this.PhysicalLabel.Size = new System.Drawing.Size(88, 29);
            this.PhysicalLabel.TabIndex = 57;
            this.PhysicalLabel.Text = "Physical";
            this.PhysicalLabel.Click += new System.EventHandler(this.PhysicalLabel_Click);
            this.PhysicalLabel.DoubleClick += new System.EventHandler(this.PhysicalLabel_Click);
            // 
            // ItemIntensityLabel
            // 
            this.ItemIntensityLabel.AutoSize = true;
            this.ItemIntensityLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.ItemIntensityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemIntensityLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemIntensityLabel.Font = new System.Drawing.Font("Baskerville Old Face", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemIntensityLabel.ForeColor = System.Drawing.Color.Maroon;
            this.ItemIntensityLabel.Location = new System.Drawing.Point(270, 35);
            this.ItemIntensityLabel.Name = "ItemIntensityLabel";
            this.ItemIntensityLabel.Padding = new System.Windows.Forms.Padding(2);
            this.ItemIntensityLabel.Size = new System.Drawing.Size(108, 29);
            this.ItemIntensityLabel.TabIndex = 58;
            this.ItemIntensityLabel.Text = "Item Type";
            this.ItemIntensityLabel.Click += new System.EventHandler(this.ItemIntensityLabel_Click);
            this.ItemIntensityLabel.DoubleClick += new System.EventHandler(this.ItemIntensityLabel_Click);
            // 
            // CheckBoxGroup
            // 
            this.CheckBoxGroup.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxGroup.Controls.Add(this.MagicalLabel);
            this.CheckBoxGroup.Controls.Add(this.MageCheckBox);
            this.CheckBoxGroup.Controls.Add(this.ItemIntensityLabel);
            this.CheckBoxGroup.Controls.Add(this.GuardianCheckBox);
            this.CheckBoxGroup.Controls.Add(this.PhysicalLabel);
            this.CheckBoxGroup.Controls.Add(this.HunterCheckBox);
            this.CheckBoxGroup.Controls.Add(this.WarriorCheckBox);
            this.CheckBoxGroup.Controls.Add(this.DefenseCheckBox);
            this.CheckBoxGroup.Controls.Add(this.AssassinCheckBox);
            this.CheckBoxGroup.Controls.Add(this.HybridCheckBox);
            this.CheckBoxGroup.Controls.Add(this.DamageCheckBox);
            this.CheckBoxGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxGroup.Font = new System.Drawing.Font("Helonia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxGroup.Location = new System.Drawing.Point(508, 121);
            this.CheckBoxGroup.Name = "CheckBoxGroup";
            this.CheckBoxGroup.Size = new System.Drawing.Size(424, 188);
            this.CheckBoxGroup.TabIndex = 60;
            this.CheckBoxGroup.TabStop = false;
            this.CheckBoxGroup.Text = "Specify your dankness with these boxes!";
            // 
            // DetailsButton
            // 
            this.DetailsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsButton.Location = new System.Drawing.Point(39, 587);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(75, 23);
            this.DetailsButton.TabIndex = 61;
            this.DetailsButton.Text = "Details";
            this.DetailsButton.UseVisualStyleBackColor = true;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // DropDownMenu
            // 
            this.DropDownMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DropDownMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropDownMenu.FormattingEnabled = true;
            this.DropDownMenu.Location = new System.Drawing.Point(747, 23);
            this.DropDownMenu.Name = "DropDownMenu";
            this.DropDownMenu.Size = new System.Drawing.Size(165, 23);
            this.DropDownMenu.TabIndex = 62;
            this.DropDownMenu.SelectedIndexChanged += new System.EventHandler(this.DropDownMenu_SelectedIndexChanged);
            this.DropDownMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DropDownMenu_KeyPress);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.DimGray;
            this.Settings.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.Gainsboro;
            this.Settings.FormattingEnabled = true;
            this.Settings.ItemHeight = 24;
            this.Settings.Items.AddRange(new object[] {
            "Standard",
            "Joust",
            "Assault",
            "Siege",
            "Conquest",
            "Clash"});
            this.Settings.Location = new System.Drawing.Point(36, 397);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(124, 148);
            this.Settings.TabIndex = 63;
            this.Settings.SelectedIndexChanged += new System.EventHandler(this.Settings_SelectedIndexChanged);
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsLabel.Font = new System.Drawing.Font("Baskerville Old Face", 13F, System.Drawing.FontStyle.Bold);
            this.SettingsLabel.ForeColor = System.Drawing.Color.White;
            this.SettingsLabel.Image = global::DankSmite.Properties.Resources.FrameStarterItem;
            this.SettingsLabel.Location = new System.Drawing.Point(38, 365);
            this.SettingsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsLabel.MinimumSize = new System.Drawing.Size(119, 29);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(119, 29);
            this.SettingsLabel.TabIndex = 64;
            this.SettingsLabel.Text = "Backgrounds";
            this.SettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::DankSmite.Properties.Resources.NewDankSmiteBrackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.SettingsLabel);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.DropDownMenu);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.CheckBoxGroup);
            this.Controls.Add(this.WelcomeButton);
            this.Controls.Add(this.GeneralTextBox);
            this.Controls.Add(this.CreditsButon);
            this.Controls.Add(this.GodLabel);
            this.Controls.Add(this.CurrentItemNameLabel);
            this.Controls.Add(this.StarterItemLabel);
            this.Controls.Add(this.StarterItemPicture);
            this.Controls.Add(this.TextInput);
            this.Controls.Add(this.RerollNumber);
            this.Controls.Add(this.RerollLabel);
            this.Controls.Add(this.RelicPicture1);
            this.Controls.Add(this.RelicPicture2);
            this.Controls.Add(this.ItemPicture4);
            this.Controls.Add(this.ItemPicture2);
            this.Controls.Add(this.ItemPicture5);
            this.Controls.Add(this.ItemPicture3);
            this.Controls.Add(this.ItemPicture6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GodPicture);
            this.Controls.Add(this.ItemPicture1);
            this.Controls.Add(this.RelicLabel1);
            this.Controls.Add(this.RelicLabel2);
            this.Controls.Add(this.ItemLabel6);
            this.Controls.Add(this.ItemLabel5);
            this.Controls.Add(this.ItemLabel4);
            this.Controls.Add(this.ItemLabel3);
            this.Controls.Add(this.ItemLabel2);
            this.Controls.Add(this.ItemLabel1);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(500, 150);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 720);
            this.MinimumSize = new System.Drawing.Size(960, 720);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dank Smite";
            ((System.ComponentModel.ISupportInitialize)(this.GodPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelicPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelicPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StarterItemPicture)).EndInit();
            this.CheckBoxGroup.ResumeLayout(false);
            this.CheckBoxGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ItemLabel1;
        private System.Windows.Forms.Label ItemLabel2;
        private System.Windows.Forms.Label ItemLabel3;
        private System.Windows.Forms.Label ItemLabel4;
        private System.Windows.Forms.Label ItemLabel5;
        private System.Windows.Forms.Label ItemLabel6;
        private System.Windows.Forms.Label RelicLabel2;
        private System.Windows.Forms.Label RelicLabel1;
        private System.Windows.Forms.PictureBox ItemPicture1;
        private System.Windows.Forms.PictureBox GodPicture;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox ItemPicture6;
        private System.Windows.Forms.PictureBox ItemPicture3;
        private System.Windows.Forms.PictureBox ItemPicture5;
        private System.Windows.Forms.PictureBox ItemPicture2;
        private System.Windows.Forms.PictureBox ItemPicture4;
        private System.Windows.Forms.PictureBox RelicPicture2;
        private System.Windows.Forms.PictureBox RelicPicture1;
        private System.Windows.Forms.Label RerollLabel;
        private System.Windows.Forms.Label RerollNumber;
        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.PictureBox StarterItemPicture;
        private System.Windows.Forms.Label StarterItemLabel;
        private System.Windows.Forms.Label CurrentItemNameLabel;
        private System.Windows.Forms.Label GodLabel;
        private System.Windows.Forms.Button CreditsButon;
        private System.Windows.Forms.Label GeneralTextBox;
        private System.Windows.Forms.Button WelcomeButton;
        private System.Windows.Forms.CheckBox MageCheckBox;
        private System.Windows.Forms.CheckBox GuardianCheckBox;
        private System.Windows.Forms.CheckBox HunterCheckBox;
        private System.Windows.Forms.CheckBox WarriorCheckBox;
        private System.Windows.Forms.CheckBox AssassinCheckBox;
        private System.Windows.Forms.CheckBox DefenseCheckBox;
        private System.Windows.Forms.CheckBox HybridCheckBox;
        private System.Windows.Forms.CheckBox DamageCheckBox;
        private System.Windows.Forms.Label MagicalLabel;
        private System.Windows.Forms.Label PhysicalLabel;
        private System.Windows.Forms.Label ItemIntensityLabel;
        private System.Windows.Forms.GroupBox CheckBoxGroup;
        private System.Windows.Forms.Button DetailsButton;
        private System.Windows.Forms.ComboBox DropDownMenu;
        private System.Windows.Forms.ListBox Settings;
        private System.Windows.Forms.Label SettingsLabel;
    }
}

