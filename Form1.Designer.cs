namespace pizza_project
{
    partial class mainForm
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
            this.gpSize = new System.Windows.Forms.GroupBox();
            this.rdLarg = new System.Windows.Forms.RadioButton();
            this.rdMedium = new System.Windows.Forms.RadioButton();
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.gpCrust = new System.Windows.Forms.GroupBox();
            this.rdThick = new System.Windows.Forms.RadioButton();
            this.rdThin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gpToppings = new System.Windows.Forms.GroupBox();
            this.ckGreen = new System.Windows.Forms.CheckBox();
            this.ckOnion = new System.Windows.Forms.CheckBox();
            this.ckOlives = new System.Windows.Forms.CheckBox();
            this.ckTomatoes = new System.Windows.Forms.CheckBox();
            this.ckMushrooms = new System.Windows.Forms.CheckBox();
            this.ckExtra = new System.Windows.Forms.CheckBox();
            this.gpWhere = new System.Windows.Forms.GroupBox();
            this.rbTake = new System.Windows.Forms.RadioButton();
            this.rdIn = new System.Windows.Forms.RadioButton();
            this.gpOrder = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbw = new System.Windows.Forms.Label();
            this.lbc = new System.Windows.Forms.Label();
            this.lbt = new System.Windows.Forms.Label();
            this.lbs = new System.Windows.Forms.Label();
            this.lbSummaryWhere = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbSummaryCrust = new System.Windows.Forms.Label();
            this.lbSummaryToppings = new System.Windows.Forms.Label();
            this.lbSummarySize = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gpSize.SuspendLayout();
            this.gpCrust.SuspendLayout();
            this.gpToppings.SuspendLayout();
            this.gpWhere.SuspendLayout();
            this.gpOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpSize
            // 
            this.gpSize.Controls.Add(this.rdLarg);
            this.gpSize.Controls.Add(this.rdMedium);
            this.gpSize.Controls.Add(this.rdSmall);
            this.gpSize.Location = new System.Drawing.Point(40, 87);
            this.gpSize.Name = "gpSize";
            this.gpSize.Size = new System.Drawing.Size(216, 99);
            this.gpSize.TabIndex = 0;
            this.gpSize.TabStop = false;
            this.gpSize.Text = "Size";
            this.gpSize.Enter += new System.EventHandler(this.gpSize_Enter);
            // 
            // rdLarg
            // 
            this.rdLarg.AutoSize = true;
            this.rdLarg.Location = new System.Drawing.Point(6, 65);
            this.rdLarg.Name = "rdLarg";
            this.rdLarg.Size = new System.Drawing.Size(46, 17);
            this.rdLarg.TabIndex = 2;
            this.rdLarg.TabStop = true;
            this.rdLarg.Tag = "20";
            this.rdLarg.Text = "Larg";
            this.rdLarg.UseVisualStyleBackColor = true;
            this.rdLarg.CheckedChanged += new System.EventHandler(this.rdLarg_CheckedChanged);
            // 
            // rdMedium
            // 
            this.rdMedium.AutoSize = true;
            this.rdMedium.Location = new System.Drawing.Point(6, 42);
            this.rdMedium.Name = "rdMedium";
            this.rdMedium.Size = new System.Drawing.Size(62, 17);
            this.rdMedium.TabIndex = 1;
            this.rdMedium.TabStop = true;
            this.rdMedium.Tag = "10";
            this.rdMedium.Text = "Medium";
            this.rdMedium.UseVisualStyleBackColor = true;
            this.rdMedium.CheckedChanged += new System.EventHandler(this.rdMedium_CheckedChanged);
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.Location = new System.Drawing.Point(6, 19);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(50, 17);
            this.rdSmall.TabIndex = 0;
            this.rdSmall.TabStop = true;
            this.rdSmall.Tag = "5";
            this.rdSmall.Text = "Small";
            this.rdSmall.UseVisualStyleBackColor = true;
            this.rdSmall.CheckedChanged += new System.EventHandler(this.rdSmall_CheckedChanged);
            // 
            // gpCrust
            // 
            this.gpCrust.Controls.Add(this.rdThick);
            this.gpCrust.Controls.Add(this.rdThin);
            this.gpCrust.Location = new System.Drawing.Point(40, 269);
            this.gpCrust.Name = "gpCrust";
            this.gpCrust.Size = new System.Drawing.Size(216, 99);
            this.gpCrust.TabIndex = 1;
            this.gpCrust.TabStop = false;
            this.gpCrust.Text = "Crust Type";
            this.gpCrust.Enter += new System.EventHandler(this.gpCrust_Enter);
            // 
            // rdThick
            // 
            this.rdThick.AutoSize = true;
            this.rdThick.Location = new System.Drawing.Point(6, 42);
            this.rdThick.Name = "rdThick";
            this.rdThick.Size = new System.Drawing.Size(79, 17);
            this.rdThick.TabIndex = 1;
            this.rdThick.TabStop = true;
            this.rdThick.Tag = "5";
            this.rdThick.Text = "Thick Crust";
            this.rdThick.UseVisualStyleBackColor = true;
            this.rdThick.CheckedChanged += new System.EventHandler(this.rdThick_CheckedChanged);
            // 
            // rdThin
            // 
            this.rdThin.AutoSize = true;
            this.rdThin.Location = new System.Drawing.Point(6, 19);
            this.rdThin.Name = "rdThin";
            this.rdThin.Size = new System.Drawing.Size(73, 17);
            this.rdThin.TabIndex = 0;
            this.rdThin.TabStop = true;
            this.rdThin.Tag = "0";
            this.rdThin.Text = "Thin Crust";
            this.rdThin.UseVisualStyleBackColor = true;
            this.rdThin.CheckedChanged += new System.EventHandler(this.rdThin_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(225, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Make Your Pizza";
            // 
            // gpToppings
            // 
            this.gpToppings.Controls.Add(this.ckGreen);
            this.gpToppings.Controls.Add(this.ckOnion);
            this.gpToppings.Controls.Add(this.ckOlives);
            this.gpToppings.Controls.Add(this.ckTomatoes);
            this.gpToppings.Controls.Add(this.ckMushrooms);
            this.gpToppings.Controls.Add(this.ckExtra);
            this.gpToppings.Location = new System.Drawing.Point(337, 96);
            this.gpToppings.Name = "gpToppings";
            this.gpToppings.Size = new System.Drawing.Size(269, 90);
            this.gpToppings.TabIndex = 3;
            this.gpToppings.TabStop = false;
            this.gpToppings.Text = "Toppings";
            // 
            // ckGreen
            // 
            this.ckGreen.AutoSize = true;
            this.ckGreen.Location = new System.Drawing.Point(129, 65);
            this.ckGreen.Name = "ckGreen";
            this.ckGreen.Size = new System.Drawing.Size(97, 17);
            this.ckGreen.TabIndex = 5;
            this.ckGreen.Tag = "5";
            this.ckGreen.Text = "Green Peppers";
            this.ckGreen.UseVisualStyleBackColor = true;
            this.ckGreen.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // ckOnion
            // 
            this.ckOnion.AutoSize = true;
            this.ckOnion.Location = new System.Drawing.Point(129, 20);
            this.ckOnion.Name = "ckOnion";
            this.ckOnion.Size = new System.Drawing.Size(54, 17);
            this.ckOnion.TabIndex = 4;
            this.ckOnion.Tag = "5";
            this.ckOnion.Text = "Onion";
            this.ckOnion.UseVisualStyleBackColor = true;
            this.ckOnion.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // ckOlives
            // 
            this.ckOlives.AutoSize = true;
            this.ckOlives.Location = new System.Drawing.Point(129, 42);
            this.ckOlives.Name = "ckOlives";
            this.ckOlives.Size = new System.Drawing.Size(55, 17);
            this.ckOlives.TabIndex = 3;
            this.ckOlives.Tag = "5";
            this.ckOlives.Text = "Olives";
            this.ckOlives.UseVisualStyleBackColor = true;
            this.ckOlives.CheckedChanged += new System.EventHandler(this.ckOlives_CheckedChanged);
            // 
            // ckTomatoes
            // 
            this.ckTomatoes.AutoSize = true;
            this.ckTomatoes.Location = new System.Drawing.Point(7, 65);
            this.ckTomatoes.Name = "ckTomatoes";
            this.ckTomatoes.Size = new System.Drawing.Size(73, 17);
            this.ckTomatoes.TabIndex = 2;
            this.ckTomatoes.Tag = "5";
            this.ckTomatoes.Text = "Tomatoes";
            this.ckTomatoes.UseVisualStyleBackColor = true;
            this.ckTomatoes.CheckedChanged += new System.EventHandler(this.ckTomatoes_CheckedChanged);
            // 
            // ckMushrooms
            // 
            this.ckMushrooms.AutoSize = true;
            this.ckMushrooms.Location = new System.Drawing.Point(7, 42);
            this.ckMushrooms.Name = "ckMushrooms";
            this.ckMushrooms.Size = new System.Drawing.Size(80, 17);
            this.ckMushrooms.TabIndex = 1;
            this.ckMushrooms.Tag = "5";
            this.ckMushrooms.Text = "Mushrooms";
            this.ckMushrooms.UseVisualStyleBackColor = true;
            this.ckMushrooms.CheckedChanged += new System.EventHandler(this.ckMushrooms_CheckedChanged);
            // 
            // ckExtra
            // 
            this.ckExtra.AutoSize = true;
            this.ckExtra.Location = new System.Drawing.Point(7, 20);
            this.ckExtra.Name = "ckExtra";
            this.ckExtra.Size = new System.Drawing.Size(83, 17);
            this.ckExtra.TabIndex = 0;
            this.ckExtra.Tag = "5";
            this.ckExtra.Text = "Extra Chees";
            this.ckExtra.UseVisualStyleBackColor = true;
            this.ckExtra.CheckedChanged += new System.EventHandler(this.ckExtra_CheckedChanged);
            // 
            // gpWhere
            // 
            this.gpWhere.Controls.Add(this.rbTake);
            this.gpWhere.Controls.Add(this.rdIn);
            this.gpWhere.Location = new System.Drawing.Point(344, 259);
            this.gpWhere.Name = "gpWhere";
            this.gpWhere.Size = new System.Drawing.Size(216, 69);
            this.gpWhere.TabIndex = 4;
            this.gpWhere.TabStop = false;
            this.gpWhere.Text = "Where to eat";
            // 
            // rbTake
            // 
            this.rbTake.AutoSize = true;
            this.rbTake.Location = new System.Drawing.Point(129, 19);
            this.rbTake.Name = "rbTake";
            this.rbTake.Size = new System.Drawing.Size(67, 17);
            this.rbTake.TabIndex = 1;
            this.rbTake.TabStop = true;
            this.rbTake.Text = "TakeOut";
            this.rbTake.UseVisualStyleBackColor = true;
            this.rbTake.CheckedChanged += new System.EventHandler(this.rbTake_CheckedChanged);
            // 
            // rdIn
            // 
            this.rdIn.AutoSize = true;
            this.rdIn.Location = new System.Drawing.Point(6, 19);
            this.rdIn.Name = "rdIn";
            this.rdIn.Size = new System.Drawing.Size(52, 17);
            this.rdIn.TabIndex = 0;
            this.rdIn.TabStop = true;
            this.rdIn.Text = "Eat in";
            this.rdIn.UseVisualStyleBackColor = true;
            this.rdIn.CheckedChanged += new System.EventHandler(this.rdIn_CheckedChanged);
            // 
            // gpOrder
            // 
            this.gpOrder.BackColor = System.Drawing.Color.Silver;
            this.gpOrder.Controls.Add(this.label6);
            this.gpOrder.Controls.Add(this.lbw);
            this.gpOrder.Controls.Add(this.lbc);
            this.gpOrder.Controls.Add(this.lbt);
            this.gpOrder.Controls.Add(this.lbs);
            this.gpOrder.Controls.Add(this.lbSummaryWhere);
            this.gpOrder.Controls.Add(this.lbPrice);
            this.gpOrder.Controls.Add(this.lbSummaryCrust);
            this.gpOrder.Controls.Add(this.lbSummaryToppings);
            this.gpOrder.Controls.Add(this.lbSummarySize);
            this.gpOrder.Location = new System.Drawing.Point(645, 96);
            this.gpOrder.Name = "gpOrder";
            this.gpOrder.Size = new System.Drawing.Size(241, 320);
            this.gpOrder.TabIndex = 5;
            this.gpOrder.TabStop = false;
            this.gpOrder.Text = "Order Summary";
            this.gpOrder.Enter += new System.EventHandler(this.gpOrder_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(40, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 63);
            this.label6.TabIndex = 9;
            this.label6.Text = "0$";
            // 
            // lbw
            // 
            this.lbw.AutoSize = true;
            this.lbw.Location = new System.Drawing.Point(108, 175);
            this.lbw.Name = "lbw";
            this.lbw.Size = new System.Drawing.Size(0, 13);
            this.lbw.TabIndex = 8;
            this.lbw.Click += new System.EventHandler(this.lbw_Click);
            // 
            // lbc
            // 
            this.lbc.AutoSize = true;
            this.lbc.Location = new System.Drawing.Point(94, 121);
            this.lbc.Name = "lbc";
            this.lbc.Size = new System.Drawing.Size(0, 13);
            this.lbc.TabIndex = 7;
            this.lbc.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbt
            // 
            this.lbt.AutoSize = true;
            this.lbt.Location = new System.Drawing.Point(34, 94);
            this.lbt.Name = "lbt";
            this.lbt.Size = new System.Drawing.Size(0, 13);
            this.lbt.TabIndex = 6;
            // 
            // lbs
            // 
            this.lbs.AutoSize = true;
            this.lbs.Location = new System.Drawing.Point(59, 24);
            this.lbs.Name = "lbs";
            this.lbs.Size = new System.Drawing.Size(0, 13);
            this.lbs.TabIndex = 5;
            this.lbs.Click += new System.EventHandler(this.lbs_Click);
            // 
            // lbSummaryWhere
            // 
            this.lbSummaryWhere.AutoSize = true;
            this.lbSummaryWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSummaryWhere.Location = new System.Drawing.Point(6, 173);
            this.lbSummaryWhere.Name = "lbSummaryWhere";
            this.lbSummaryWhere.Size = new System.Drawing.Size(96, 15);
            this.lbSummaryWhere.TabIndex = 4;
            this.lbSummaryWhere.Text = "Where to eat :";
            this.lbSummaryWhere.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(6, 235);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(84, 15);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "Total Price :";
            this.lbPrice.Click += new System.EventHandler(this.lbPrice_Click);
            // 
            // lbSummaryCrust
            // 
            this.lbSummaryCrust.AutoSize = true;
            this.lbSummaryCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSummaryCrust.Location = new System.Drawing.Point(6, 119);
            this.lbSummaryCrust.Name = "lbSummaryCrust";
            this.lbSummaryCrust.Size = new System.Drawing.Size(82, 15);
            this.lbSummaryCrust.TabIndex = 2;
            this.lbSummaryCrust.Text = "Crust Type :";
            // 
            // lbSummaryToppings
            // 
            this.lbSummaryToppings.AutoSize = true;
            this.lbSummaryToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSummaryToppings.Location = new System.Drawing.Point(6, 67);
            this.lbSummaryToppings.Name = "lbSummaryToppings";
            this.lbSummaryToppings.Size = new System.Drawing.Size(74, 15);
            this.lbSummaryToppings.TabIndex = 1;
            this.lbSummaryToppings.Text = "Toppings :";
            // 
            // lbSummarySize
            // 
            this.lbSummarySize.AutoSize = true;
            this.lbSummarySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSummarySize.Location = new System.Drawing.Point(6, 22);
            this.lbSummarySize.Name = "lbSummarySize";
            this.lbSummarySize.Size = new System.Drawing.Size(43, 15);
            this.lbSummarySize.TabIndex = 0;
            this.lbSummarySize.Text = "Size :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(235, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Order pizza";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(420, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "Reset Form";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(911, 521);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gpOrder);
            this.Controls.Add(this.gpWhere);
            this.Controls.Add(this.gpToppings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpCrust);
            this.Controls.Add(this.gpSize);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "mainForm";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.gpSize.ResumeLayout(false);
            this.gpSize.PerformLayout();
            this.gpCrust.ResumeLayout(false);
            this.gpCrust.PerformLayout();
            this.gpToppings.ResumeLayout(false);
            this.gpToppings.PerformLayout();
            this.gpWhere.ResumeLayout(false);
            this.gpWhere.PerformLayout();
            this.gpOrder.ResumeLayout(false);
            this.gpOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpSize;
        private System.Windows.Forms.RadioButton rdLarg;
        private System.Windows.Forms.RadioButton rdMedium;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.GroupBox gpCrust;
        private System.Windows.Forms.RadioButton rdThick;
        private System.Windows.Forms.RadioButton rdThin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpToppings;
        private System.Windows.Forms.GroupBox gpWhere;
        private System.Windows.Forms.RadioButton rbTake;
        private System.Windows.Forms.RadioButton rdIn;
        private System.Windows.Forms.CheckBox ckGreen;
        private System.Windows.Forms.CheckBox ckOnion;
        private System.Windows.Forms.CheckBox ckOlives;
        private System.Windows.Forms.CheckBox ckTomatoes;
        private System.Windows.Forms.CheckBox ckMushrooms;
        private System.Windows.Forms.CheckBox ckExtra;
        private System.Windows.Forms.GroupBox gpOrder;
        private System.Windows.Forms.Label lbSummarySize;
        private System.Windows.Forms.Label lbSummaryWhere;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbSummaryCrust;
        private System.Windows.Forms.Label lbSummaryToppings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbw;
        private System.Windows.Forms.Label lbc;
        private System.Windows.Forms.Label lbt;
        private System.Windows.Forms.Label lbs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

