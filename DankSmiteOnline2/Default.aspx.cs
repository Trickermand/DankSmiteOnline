using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Drawing;

using gaiController;
using System.Reflection;
using DankSmite.Properties;

namespace DankSmiteOnline2
{
    public partial class _Default : Page
    {




        //public List<string> AllActualGods = godCol.retrieveAllGodNames();

        ////public Form1()
        ////{

        ////}

        string SmiteVersion = "5.5";

        public static bool CredsFlag = false;
        public static bool WelcomeFlag = false;
        public static bool DetailsFlag = false;
        public static bool FirstDropDown = true;
        public static bool first = true;
        //public static bool clickedRebuild = true;

        public static bool firstLoad = true;


        static Item[] _build = new Item[9] {
            new Item("","",false, false, false),
            new Item("","",false, false, false),
            new Item("","",false, false, false),
            new Item("","",false, false, false),
            new Item("","",false, false, false),
            new Item("","",false, false, false),
            new Item("","",false, false, false),
            new Item("","",false, false, false),
            new Item("","",false, false, false)
        };

        static God _god = new God("", "");
        static List<God> legalGods;
        static List<Item> legalItems;
        static List<Item> legalBoots;
        static List<Item> legalRelics;
        static List<Item> legalStarters;
        static GodCollector godCol = new GodCollector();
        static ItemCollector itemCol = new ItemCollector();
        private Random rnd = new Random();

        public static Item[] Build
        {
            get { return _build; }
            set { _build = value; }
        }
        public static God God
        {
            get { return _god; }
            set { _god = value; }
        }
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (firstLoad)
            {
                //InitializeComponent();
                WelcomeButton_Click(null, null);
                Page.Title = "DankSmite " + Assembly.GetExecutingAssembly().GetName().Version.ToString(2);

                #region Dropdown
                //foreach (string GodName in AllActualGods)
                //{
                //    this.DropDownMenu.Items.Add(GodName);
                //}
                //this.DropDownMenu.SelectedIndex = 0;
                #endregion

                legalBoots = itemCol.retrieveLegalBoots(true, true, true, "m");
                legalItems = itemCol.retrieveLegalItems(true, true, true, "m");
                legalRelics = itemCol.retrieveLegalRelics(true, true, true, "m");
                legalStarters = itemCol.retrieveLegalStarters(true, true, true, "m");
                firstLoad = false;
            }
            else
            {
                Page.Title = "DankSmite " + Assembly.GetExecutingAssembly().GetName().Version.ToString(2);

            }
        }


        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    name = "Other stuff";
        //    //InitializeComponent();
        //    //WelcomeButton_Click(null, null);
        //    Page.Title = "DankSmite " + Assembly.GetExecutingAssembly().GetName().Version.ToString(2);

        //    #region Dropdown
        //    //foreach (string GodName in AllActualGods)
        //    //{
        //    //    this.DropDownMenu.Items.Add(GodName);
        //    //}
        //    //this.DropDownMenu.SelectedIndex = 0;
        //    #endregion

        //    //legalBoots = itemCol.retrieveLegalBoots(true, true, true, "m");
        //    //legalItems = itemCol.retrieveLegalItems(true, true, true, "m");
        //    //legalRelics = itemCol.retrieveLegalRelics(true, true, true, "m");
        //    //legalStarters = itemCol.retrieveLegalStarters(true, true, true, "m");


        //}

        #region God Input
        //private void TextInput_KeyPress(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Return)
        //    {
        //        BuildButton(null, null);
        //        e.SuppressKeyPress = true;
        //    }
        //    else
        //    {
        //        this.DropDownMenu.SelectedIndex = 0;
        //    }
        //}

        //private void TextInput_Click(object sender, EventArgs e)
        //{
        //    if (first)
        //    {
        //        this.TextInput.Text = "";
        //        this.TextInput.ForeColor = System.Drawing.SystemColors.ControlText;
        //        first = false;
        //    }
        //    this.DropDownMenu.SelectedIndex = 0;
        //}

        //private void DropDownMenu_KeyPress(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Return)
        //    {
        //        BuildButton(null, null);
        //        e.SuppressKeyPress = true;
        //    }
        //}

        //public void DropDownMenu_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (FirstDropDown)
        //    {
        //        FirstDropDown = false;
        //    }
        //    else if (this.DropDownMenu.SelectedIndex == 0)
        //    {
        //        this.TextInput.Text = "";
        //    }
        //    else
        //    {
        //        this.TextInput.ForeColor = System.Drawing.SystemColors.ControlText;
        //        this.TextInput.Text = AllActualGods[this.DropDownMenu.SelectedIndex];
        //    }
        //}

        private void GodNameInterpreter()
        {
            string tempText = InputField.Text;
            switch (tempText)
            {
                case "amc":
                    tempText = "ah muzen cab";
                    break;
                case "ama":
                    tempText = "amaterasu";
                    break;
                case "dog":
                case "doggo":
                    tempText = "anubis";
                    break;
                case "cat":
                case "cate":
                    tempText = "bastet";
                    break;
                case "cama":
                case "camasucks":
                    tempText = "camazotz";
                    break;
                case "cern":
                    tempText = "cernunnos";
                    break;
                case "change":
                    tempText = "chang'e";
                    break;
                case "choo choo":
                case "chu chu":
                case "chuchu":
                    tempText = "cu chulainn";
                    break;
                case "iza":
                    tempText = "izanami";
                    break;
                case "kuku":
                case "kkk":
                    tempText = "kukulkan";
                    break;
                case "kumba":
                case "kumbha":
                case "khumba":
                    tempText = "kumbhakarna";
                    break;
                case "rat":
                    tempText = "ratatoskr";
                    break;
                case "monkey":
                case "wukong":
                    tempText = "sun wukong";
                    break;
                case "thana":
                    tempText = "thanatos";
                    break;
                case "morrigan":
                    tempText = "the morrigan";
                    break;
                case "mcshitterfuck":
                case "mc shitterfuck":
                    //this.BackgroundImage = global::DankSmite.Properties.Resources.thor;
                    //this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
                    tempText = "thor";
                    break;
                case "xaba":
                case "xballer": //Nazzyc is a retard - Splatt will not erase this line//
                case "xba":
                    tempText = "xbalanque";
                    break;
                case "xing":
                    tempText = "xing tian";
                    break;
                case "zhong":
                    tempText = "zhong kui";
                    break;
            }
            InputField.Text = tempText;
        }
#endregion

        #region Build button
        public void BuildButton_Click(object sender, EventArgs e)
        {
            //Setup for next roll

            this.GeneralTextBox.Visible = false;
            this.CurrentItemNameLabel.Text = "";
            RerollNumber.Text = 0.ToString();
            CredsFlag = false;
            WelcomeFlag = false;
            DetailsFlag = false;

            //Making input easier
            GodNameInterpreter();

            //Some dankness





            #region Dank
            if (InputField.Text == "op")
            {

                _god = new God("Ymir", "g");
                for (int i = 0; i < 6; i++)
                {
                    Build[i] = new Item("Deathbringer", "dmg", false, true, false);
                }
                Build[6] = new Item("Blink_Rune", "dmg", true, true, false);
                Build[7] = new Item("Blink_Rune", "dmg", true, true, false);
                Build[8] = new Item("Deathbringer", "dmg", false, true, false);

                legalBoots = itemCol.retrieveLegalBoots(true, true, true, God.type);
                legalItems = itemCol.retrieveLegalItems(true, true, true, God.type);
                legalRelics = itemCol.retrieveLegalRelics(true, true, true, God.type);
                legalStarters = itemCol.retrieveLegalStarters(true, true, true, God.type);
            }
            else if (InputField.Text.ToLower() == "trickermand")
            {
                _god = new God("Ymir", "g");

                Build[0] = new Item("Shoes_of_the_Magi", "dmg", true, false, false);
                Build[1] = new Item("Dynasty_Plate_Helm", "hyb", true, false, false);
                Build[2] = new Item("BreastPlate_of_Valor", "def", true, true, false);
                Build[3] = new Item("Hide_of_the_Urchin", "def", true, true, false);
                Build[5] = new Item("Shogun's_Kusari", "dmg", true, false, false);
                Build[4] = new Item("Obsidian_Shard", "dmg", true, false, false);

                Build[6] = new Item("Blink_Rune", "dmg", true, true, false);
                Build[7] = new Item("Magic_Shell", "dmg", true, true, false);
                Build[8] = new Item("Mark_of_the_Vanguard", "dmg", false, true, false);

                legalBoots = itemCol.retrieveLegalBoots(true, true, true, God.type);
                legalItems = itemCol.retrieveLegalItems(true, true, true, God.type);
                legalRelics = itemCol.retrieveLegalRelics(true, true, true, God.type);
                legalStarters = itemCol.retrieveLegalStarters(true, true, true, God.type);
            }
            else if (InputField.Text.ToLower() == "nazzyc")
            {
                _god = new God("Medusa", "h");
                for (int i = 0; i < 6; i++)
                {
                    Build[i] = new Item("Odysseus'_Bow", "dmg", false, true, false);
                }
                Build[6] = new Item("Bracer_of_Undoing", "def", true, true, false);
                Build[7] = new Item("Bracer_of_Undoing", "def", true, true, false);
                Build[8] = new Item("Odysseus'_Bow", "dmg", false, true, false);

                legalBoots = itemCol.retrieveLegalBoots(true, true, true, God.type);
                legalItems = itemCol.retrieveLegalItems(true, true, true, God.type);
                legalRelics = itemCol.retrieveLegalRelics(true, true, true, God.type);
                legalStarters = itemCol.retrieveLegalStarters(true, true, true, God.type);
            }
            else if (InputField.Text.ToLower() == "kloppermand")
            {
                _god = new God("Ares", "g");

                Build[0] = new Item("Shoes_of_the_Magi", "dmg", true, false, false);
                Build[1] = new Item("Void_Stone", "hyb", true, false, false);
                Build[2] = new Item("Mystical_Mail", "def", true, true, false);
                Build[3] = new Item("Hide_of_the_Urchin", "def", true, true, false);
                Build[4] = new Item("Obsidian_Shard", "dmg", true, false, false);
                Build[5] = new Item("Rod_of_Tahuti", "dmg", true, false, false);

                Build[6] = new Item("Blink_Rune", "hyb", true, true, false);
                Build[7] = new Item("Shield_of_Thorns", "def", true, true, false);
                Build[8] = new Item("Mark_of_the_Vanguard", "def", true, true, false);

                legalBoots = itemCol.retrieveLegalBoots(true, true, true, God.type);
                legalItems = itemCol.retrieveLegalItems(true, true, true, God.type);
                legalRelics = itemCol.retrieveLegalRelics(true, true, true, God.type);
                legalStarters = itemCol.retrieveLegalStarters(true, true, true, God.type);
            }
            #endregion

            //Validation of proper input
            else if (!((AssassinCheckbox.Checked == false
                && this.GuardianCheckbox.Checked == false
                && this.HunterCheckbox.Checked == false
                && this.MageCheckbox.Checked == false
                && this.WarriorCheckbox.Checked == false)
                || (this.DamageCheckbox.Checked == false
                && this.DefenseCheckbox.Checked == false
                && this.HybridCheckbox.Checked == false)))
            {


                if (string.IsNullOrEmpty(InputField.Text))
                {
                    fullRebuild(
                    this.GuardianCheckbox.Checked,
                    this.MageCheckbox.Checked,
                    this.HunterCheckbox.Checked,
                    this.AssassinCheckbox.Checked,
                    this.WarriorCheckbox.Checked,
                    this.DamageCheckbox.Checked,
                    this.HybridCheckbox.Checked,
                    this.DefenseCheckbox.Checked
                    );
                }
                else
                {
                    fullRebuild(
                    InputField.Text,
                    this.DamageCheckbox.Checked,
                    this.HybridCheckbox.Checked,
                    this.DefenseCheckbox.Checked
                    );
                }

            }
            else
            {
                _god = new God("Ymir", "g");
                for (int i = 0; i < 6; i++)
                {
                    Build[i] = new Item("Deathbringer", "dmg", false, true, false);
                }
                Build[6] = new Item("Blink_Rune", "dmg", true, true, false);
                Build[7] = new Item("Blink_Rune", "dmg", true, true, false);
                Build[8] = new Item("Deathbringer", "dmg", false, true, false);

                legalBoots = itemCol.retrieveLegalBoots(true, true, true, God.type);
                legalItems = itemCol.retrieveLegalItems(true, true, true, God.type);
                legalRelics = itemCol.retrieveLegalRelics(true, true, true, God.type);
                legalStarters = itemCol.retrieveLegalStarters(true, true, true, God.type);
            }

            //Sets labels
            this.StarterItemLabel.Visible = true;
            this.RelicLabel1.Visible = true;
            this.RelicLabel2.Visible = true;
            this.ItemLabel1.Visible = true;
            this.ItemLabel2.Visible = true;
            this.ItemLabel3.Visible = true;
            this.ItemLabel4.Visible = true;
            this.ItemLabel5.Visible = true;
            this.ItemLabel6.Visible = true;
            //clickedRebuild = true;

            Draw();

        }
        #endregion

        #region HelpAndCredits
        public void CreditsButon_Click(object sender, EventArgs e)
        {
            if (CredsFlag == false)
            {
                GeneralTextBox.Text = "Created by: Trickermand, Nazzyc, Kloppermand.\n\nSmite is property of Hi-Rez studio" +
                                    ". All pictures are created and owned by Hi-Rez Studio<br\\>\nBorders created by to J. W. Bjerk.";
                CredsFlag = true;
                WelcomeFlag = false;
                DetailsFlag = false;
                this.GeneralTextBox.Visible = true;
            }
            else
            {
                CredsFlag = false;
                WelcomeFlag = false;
                DetailsFlag = false;
                this.GeneralTextBox.Visible = false;
            }
        }


        public void WelcomeButton_Click(object sender, EventArgs e)
        {
            if (WelcomeFlag == false)
            {
                if (DateTime.Now.Date.ToString("MM-dd") == "12-09")
                {
                    GeneralTextBox.Text = "\n\n\n\n\nHappy birthday Kloppermand";
                }
                else
                {
                    GeneralTextBox.Text = "Welcome to DankSmite!\nClick the Build button to get a god and a build! Click the pictures to reroll them, should you want to do so!\n\n\nWorks for smite version: " + SmiteVersion + "\nDanksmite version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString(2);

                }

                CredsFlag = false;
                WelcomeFlag = true;
                DetailsFlag = false;
                this.GeneralTextBox.Visible = true;
            }
            else
            {
                CredsFlag = false;
                WelcomeFlag = false;
                DetailsFlag = false;
                this.GeneralTextBox.Visible = false;
            }
        }

        public void DetailsButton_Click(object sender, EventArgs e)
        {
            if (DetailsFlag == false)
            {
                GeneralTextBox.Text = "Version of DankSmite is " + Assembly.GetExecutingAssembly().GetName().Version.ToString(4);
                CredsFlag = false;
                WelcomeFlag = false;
                DetailsFlag = true;
                this.GeneralTextBox.Visible = true;
            }
            else
            {
                CredsFlag = false;
                WelcomeFlag = false;
                DetailsFlag = false;
                this.GeneralTextBox.Visible = false;
            }
        }


        #endregion

        #region Rerolls

        public void GodPicture_Click(object sender, EventArgs e)
        {
            //if (clickedRebuild)
            //{
                int RerollAmount = Int32.Parse(RerollNumber.Text);
                rerollGod();
                DrawGodPictureBox(GodPicture);
                AssignGodBorder(GodFrame);
                RerollAmount++;
                if (RerollAmount >= 1000)
                {
                    RerollNumber.Text = double.PositiveInfinity.ToString();
                }
                else
                {
                    RerollNumber.Text = RerollAmount.ToString();
                }
            //}
        }

        public void StarterItemPicture_Click(object sender, EventArgs e)
        {
            rerollItemWrapper(8, StarterItemPicture, StarterItemFrame);
        }



        public void ItemPicture1_Click(object sender, EventArgs e)
        {
            rerollItemWrapper(0, ItemPicture1, ItemFrame1);
        }

        public void ItemPicture2_Click(object sender, EventArgs e)
        {
            rerollItemWrapper(1, ItemPicture2, ItemFrame2);
        }

        public void ItemPicture3_Click(object sender, EventArgs e)
        {
            rerollItemWrapper(2, ItemPicture3, ItemFrame3);
        }

        public void ItemPicture4_Click(object sender, EventArgs e)
        {
            rerollItemWrapper(3, ItemPicture4, ItemFrame4);
        }

        public void ItemPicture5_Click(object sender, EventArgs e)
        {
            rerollItemWrapper(4, ItemPicture5, ItemFrame5);
        }

        public void ItemPicture6_Click(object sender, EventArgs e)
        {
            rerollItemWrapper(5, ItemPicture6, ItemFrame6);
        }

        public void RelicPicture1_Click(object sender, EventArgs e)
        {
            rerollItemWrapper(6, RelicPicture1, RelicFrame1);
        }

        public void RelicPicture2_Click(object sender, EventArgs e)
        {
            rerollItemWrapper(7, RelicPicture2, RelicFrame2);
        }

        public void rerollItemWrapper(int i, System.Web.UI.WebControls.Image item, System.Web.UI.WebControls.ImageButton frame)
        {
            //if (clickedRebuild)
            //{
                int RerollAmount = Int32.Parse(RerollNumber.Text);
                rerollItem(i);
                AssignBorder(i, frame);
                item.ImageUrl = NamingFormatter(Build[i].name);
                    

                //CurrentItemNameLabel.Text = Build[i].name.Replace('_', ' ');
                RerollAmount++;
                if (RerollAmount >= 1000)
                {
                    RerollNumber.Text = double.PositiveInfinity.ToString();
                }
                else
                {
                    RerollNumber.Text = RerollAmount.ToString();
                }
            //}


        }

        private void AssignBorder(int i, System.Web.UI.WebControls.Image pictureBox)
        {
            if (i < 6 && i != 0)
            {
                if (Build[i].itemColor.Equals("dmg"))
                {
                    pictureBox.ImageUrl = "~/Resources/ItemFrameDamage.png";
                }
                else if (Build[i].itemColor.Equals("hyb"))
                {
                    pictureBox.ImageUrl = "~/Resources/ItemFrameHybrid.png";
                }
                else if (Build[i].itemColor.Equals("def"))
                {
                    pictureBox.ImageUrl = "~/Resources/ItemFrameDefense.png";
                }
            }
            else
            {
                pictureBox.ImageUrl = "~/Resources/ItemFrameNeutral.png";
            }
        }

        private void AssignGodBorder(System.Web.UI.WebControls.ImageButton pictureBox)
        {
            if (_god.type.Equals("g") || _god.type.Equals("m"))
            {
                pictureBox.ImageUrl = "~/Resources/DankFrameBlue.png";
            }
            else
            {
                pictureBox.ImageUrl = "~/Resources/DankFrameRed.png";
            }
        }

        #endregion

        //==================================DRAW=====================================//
        #region DrawingSection
        private void Draw()
        {
            DrawGodPictureBox(GodPicture);
            AssignGodBorder(GodFrame);

            this.ItemPicture1.Enabled = true;
            this.ItemPicture1.Visible = true;
            this.ItemPicture2.Enabled = true;
            this.ItemPicture2.Visible = true;
            this.ItemPicture3.Enabled = true;
            this.ItemPicture3.Visible = true;
            this.ItemPicture4.Enabled = true;
            this.ItemPicture4.Visible = true;
            this.ItemPicture5.Enabled = true;
            this.ItemPicture5.Visible = true;
            this.ItemPicture6.Enabled = true;
            this.ItemPicture6.Visible = true;
            this.CurrentItemNameLabel.Enabled = true;
            this.CurrentItemNameLabel.Visible = true;
            this.StarterItemPicture.Enabled = true;
            this.StarterItemPicture.Visible = true;
            this.RelicPicture1.Enabled = true;
            this.RelicPicture1.Visible = true;
            this.RelicPicture2.Enabled = true;
            this.RelicPicture2.Visible = true;
            this.GodPicture.Enabled = true;
            this.GodPicture.Visible = true;
            this.GodLabel.Visible = true;
            this.RerollLabel.Visible = true;
            this.RerollNumber.Visible = true;


            AssignBorder(0, ItemFrame1);
            AssignBorder(1, ItemFrame2);
            AssignBorder(2, ItemFrame3);
            AssignBorder(3, ItemFrame4);
            AssignBorder(4, ItemFrame5);
            AssignBorder(5, ItemFrame6);
            AssignBorder(6, RelicFrame1);
            AssignBorder(7, RelicFrame2);
            AssignBorder(8, StarterItemFrame);
            
            
            ItemPicture1.ImageUrl = NamingFormatter(Build[0].name);
            ItemPicture2.ImageUrl = NamingFormatter(Build[1].name);
            ItemPicture3.ImageUrl = NamingFormatter(Build[2].name);
            ItemPicture4.ImageUrl = NamingFormatter(Build[3].name);
            ItemPicture5.ImageUrl = NamingFormatter(Build[4].name);
            ItemPicture6.ImageUrl = NamingFormatter(Build[5].name);

            RelicPicture1.ImageUrl = NamingFormatter(Build[6].name);
            RelicPicture2.ImageUrl = NamingFormatter(Build[7].name);

            StarterItemPicture.ImageUrl = NamingFormatter(Build[8].name);
        }

        public string NamingFormatter(string txt)
        {
            txt = txt.Replace("_", "-");
            txt = txt.Replace("\'", "").ToLower();
            txt = "Resources/" + txt + ".png";
            return txt;
        }
        

        public void DrawGodPictureBox(System.Web.UI.WebControls.Image picture)
        {
            picture.ImageUrl = NamingFormatter(_god.name);


            this.GodLabel.Text = _god.name.Replace("_", " ");
        }

        public void pictureBox1_Hover(object sender, EventArgs e)
        {
            this.CurrentItemNameLabel.Text = Build[0].name.Replace('_', ' ');
        }

        public void pictureBox1_Hover()
        {
            this.CurrentItemNameLabel.Text = Build[0].name.Replace('_', ' ');
        }

        //private void pictureBox2_Hover(object sender, EventArgs e)
        //{
        //    this.CurrentItemNameLabel.Text = Build[1].name.Replace('_', ' ');
        //}

        //private void pictureBox3_Hover(object sender, EventArgs e)
        //{
        //    this.CurrentItemNameLabel.Text = Build[2].name.Replace('_', ' ');
        //}

        //private void pictureBox4_Hover(object sender, EventArgs e)
        //{
        //    this.CurrentItemNameLabel.Text = Build[3].name.Replace('_', ' ');
        //}

        //private void pictureBox5_Hover(object sender, EventArgs e)
        //{
        //    this.CurrentItemNameLabel.Text = Build[4].name.Replace('_', ' ');
        //}

        //private void pictureBox6_Hover(object sender, EventArgs e)
        //{
        //    this.CurrentItemNameLabel.Text = Build[5].name.Replace('_', ' ');
        //}

        //private void Relic1_Hover(object sender, EventArgs e)
        //{
        //    this.CurrentItemNameLabel.Text = Build[6].name.Replace('_', ' ');
        //}

        //private void Relic2_Hover(object sender, EventArgs e)
        //{
        //    this.CurrentItemNameLabel.Text = Build[7].name.Replace('_', ' ');
        //}

        //private void StarterItemPicture_Hover(object sender, EventArgs e)
        //{
        //    this.CurrentItemNameLabel.Text = Build[8].name.Replace('_', ' ');
        //}

        //private void ClearLabels(object sender, EventArgs e)
        //{
        //    this.CurrentItemNameLabel.Text = "";
        //}



        #endregion


        //#region MajorLabels
        //private void ItemIntensityLabel_Click(object sender, EventArgs e)
        //{
        //    if (!this.DamageCheckBox.Checked || !this.HybridCheckBox.Checked || !this.DefenseCheckBox.Checked)
        //    {
        //        this.DamageCheckBox.Checked = true;
        //        this.HybridCheckBox.Checked = true;
        //        this.DefenseCheckBox.Checked = true;
        //    }
        //    else
        //    {
        //        this.DamageCheckBox.Checked = false;
        //        this.HybridCheckBox.Checked = false;
        //        this.DefenseCheckBox.Checked = false;
        //    }
        //}

        //private void PhysicalLabel_Click(object sender, EventArgs e)
        //{
        //    if (!this.WarriorCheckBox.Checked || !this.HunterCheckBox.Checked || !this.AssassinCheckBox.Checked)
        //    {
        //        this.WarriorCheckBox.Checked = true;
        //        this.HunterCheckBox.Checked = true;
        //        this.AssassinCheckBox.Checked = true;
        //    }
        //    else
        //    {
        //        this.HunterCheckBox.Checked = false;
        //        this.WarriorCheckBox.Checked = false;
        //        this.AssassinCheckBox.Checked = false;
        //    }
        //}

        //private void MagicalLabel_Click(object sender, EventArgs e)
        //{
        //    if (!this.GuardianCheckBox.Checked || !this.MageCheckBox.Checked)
        //    {
        //        this.GuardianCheckBox.Checked = true;
        //        this.MageCheckBox.Checked = true;
        //    }
        //    else
        //    {
        //        this.GuardianCheckBox.Checked = false;
        //        this.MageCheckBox.Checked = false;
        //    }
        //}
        //#endregion



        #region BodySection
        //Checkboxes with gods and itemcolours, sets _build to a full build, and _god to a god
        public void fullRebuild(bool g, bool m, bool h, bool a, bool w, bool dmg, bool hyb, bool def)
        {
            //Choose god
            int choice;
            legalGods = godCol.retrieveLegalList(g, m, h, a, w);

            choice = rnd.Next(legalGods.Count);
            God = legalGods[choice];

            legalBoots = itemCol.retrieveLegalBoots(dmg, hyb, def, God.type);
            legalItems = itemCol.retrieveLegalItems(dmg, hyb, def, God.type);
            legalRelics = itemCol.retrieveLegalRelics(dmg, hyb, def, God.type);
            legalStarters = itemCol.retrieveLegalStarters(dmg, hyb, def, God.type);

            for (int i = 0; i < 9; i++)
            {
                rerollItem(i);
            }

        }

        public void fullRebuild(string potGod, bool dmg, bool hyb, bool def)
        {
            bool foundGod = false;
            List<string> ls = new List<string>();
            foreach (God gd in godCol.retrieveLegalList(true, true, true, true, true))
            {
                if (gd.name.ToLower().Equals(InputField.Text.ToLower().Replace(" ", "_")))
                {
                    foundGod = true;
                    _god = gd;
                    if (_god.type.Equals("g"))
                    {
                        legalGods = godCol.retrieveLegalList(true, false, false, false, false);
                    }
                    else if (_god.type.Equals("m"))
                    {
                        legalGods = godCol.retrieveLegalList(false, true, false, false, false);
                    }
                    else if (_god.type.Equals("h"))
                    {
                        legalGods = godCol.retrieveLegalList(false, false, true, false, false);
                    }
                    else if (_god.type.Equals("a"))
                    {
                        legalGods = godCol.retrieveLegalList(false, false, false, true, false);
                    }
                    else if (_god.type.Equals("w"))
                    {
                        legalGods = godCol.retrieveLegalList(false, false, false, false, true);
                    }

                    legalBoots = itemCol.retrieveLegalBoots(dmg, hyb, def, God.type);
                    legalItems = itemCol.retrieveLegalItems(dmg, hyb, def, God.type);
                    legalRelics = itemCol.retrieveLegalRelics(dmg, hyb, def, God.type);
                    legalStarters = itemCol.retrieveLegalStarters(dmg, hyb, def, God.type);

                    for (int i = 0; i < 9; i++)
                    {
                        rerollItem(i);
                    }
                }

                if (!foundGod)
                {
                    fullRebuild(
                        this.GuardianCheckbox.Checked,
                        this.MageCheckbox.Checked,
                        this.HunterCheckbox.Checked,
                        this.AssassinCheckbox.Checked,
                        this.WarriorCheckbox.Checked,
                        this.DamageCheckbox.Checked,
                        this.HybridCheckbox.Checked,
                        this.DefenseCheckbox.Checked
                    );
                }
            }
        }


        ////Takes an int itemNumber:
        ////0: Boots
        ////1-5: Items
        ////6-7: Relics
        ////8: Starter
        public void rerollItem(int itemNumber)
        {
            int choice;
            Item itemCandidate;

            //Boots
            if (itemNumber == 0)
            {
                do
                {
                    choice = rnd.Next(legalBoots.Count);
                    itemCandidate = legalBoots[choice];
                } while (itemInBuild(itemCandidate));
            }

            //Normal items
            else if (1 <= itemNumber && itemNumber < 6)
            {
                do
                {
                    choice = rnd.Next(legalItems.Count);
                    itemCandidate = legalItems[choice];
                } while (itemInBuild(itemCandidate) || (itemCandidate.isKatana && God.type.Equals("h")));
            }

            //Relics
            else if (6 <= itemNumber && itemNumber < 8)
            {
                do
                {
                    choice = rnd.Next(legalRelics.Count);
                    itemCandidate = legalRelics[choice];
                } while (itemInBuild(itemCandidate));
            }

            //Fallback on starter item
            else
            {
                do
                {
                    choice = rnd.Next(legalStarters.Count);
                    itemCandidate = legalStarters[choice];
                } while (itemInBuild(itemCandidate));
            }

            Build[itemNumber] = itemCandidate;
        }

        //Rerolls the god, taking into account whether or not Katanas are in the tree.
        public void rerollGod()
        {
            bool isMag = false;
            if (God.type.Equals("g") || God.type.Equals("m"))
            {
                isMag = true;
            }

            bool hasKatana = buildContainsKatana();
            int choice;
            God godCandidate;

            if (isMag)
            {
                do
                {
                    choice = rnd.Next(legalGods.Count);
                    godCandidate = legalGods[choice];
                } while (
                            !godCandidate.type.Equals("m")
                            && !godCandidate.type.Equals("g")
                            || godCandidate.name.Equals(God.name));
            }
            else
            {
                if (hasKatana)
                {
                    do
                    {
                        choice = rnd.Next(legalGods.Count);
                        godCandidate = legalGods[choice];
                    } while (
                               !godCandidate.type.Equals("a")
                                && !godCandidate.type.Equals("w")
                            || godCandidate.name.Equals(God.name)
                                );
                }
                else
                {
                    do
                    {
                        choice = rnd.Next(legalGods.Count);
                        godCandidate = legalGods[choice];
                    } while (
                               (!godCandidate.type.Equals("h")
                                && !godCandidate.type.Equals("a")
                                && !godCandidate.type.Equals("w"))
                            || godCandidate.name.Equals(God.name)
                                );
                }
            }
            God = godCandidate;
        }


        public bool itemInBuild(Item item)
        {

            foreach (Item builditem in Build)
            {
                if (builditem != null && builditem.name.Equals(item.name))
                {
                    return true;
                }
            }

            return false;

        }

        public bool buildContainsKatana()
        {
            foreach (Item item in Build)
            {
                if (item.isKatana)
                {
                    return true;
                }
            }
            return false;
        }


        #endregion

        //private void Settings_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    switch (this.Settings.SelectedIndex)
        //    {
        //        case 0:
        //            this.BackgroundImage = (Image)Resources.ResourceManager.GetObject("NewDankSmiteBrackground");
        //            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        //            break;
        //        case 1:
        //            this.BackgroundImage = (Image)Resources.ResourceManager.GetObject("SplattGreaterThanKlopper");
        //            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        //            break;
        //        case 2:
        //            this.BackgroundImage = (Image)Resources.ResourceManager.GetObject("KlopperIsShit");
        //            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        //            break;
        //        case 3:
        //            this.BackgroundImage = (Image)Resources.ResourceManager.GetObject("AresSucks");
        //            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        //            break;
        //        case 4:
        //            this.BackgroundImage = (Image)Resources.ResourceManager.GetObject("BellonaIsBae");
        //            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        //            break;
        //        case 5:
        //            this.BackgroundImage = (Image)Resources.ResourceManager.GetObject("YmirIsTheBest");
        //            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        //            break;
        //    }
        //}
    }
}
