namespace Physical_Equations
{
    partial class PropertiesForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.HideLablesButton = new System.Windows.Forms.Button();
            this.MakeTheCubesGoThroughEachOtherCheckBox = new System.Windows.Forms.CheckBox();
            this.MakeBlueCubeNonVisibleCheckBox = new System.Windows.Forms.CheckBox();
            this.SmallFontButton = new System.Windows.Forms.Button();
            this.BigFontButtom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NormalFontButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GoThroughEachOther = new System.Windows.Forms.Timer(this.components);
            this.HiddenTheInheritanceSideCheckBox = new System.Windows.Forms.CheckBox();
            this.AbilityToMoveBlueCubeManualyByUser = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // HideLablesButton
            // 
            this.HideLablesButton.BackColor = System.Drawing.Color.Crimson;
            this.HideLablesButton.Font = new System.Drawing.Font("Simplified Arabic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HideLablesButton.Location = new System.Drawing.Point(12, 12);
            this.HideLablesButton.Name = "HideLablesButton";
            this.HideLablesButton.Size = new System.Drawing.Size(75, 56);
            this.HideLablesButton.TabIndex = 0;
            this.HideLablesButton.Text = "Hide Lables";
            this.HideLablesButton.UseVisualStyleBackColor = false;
            this.HideLablesButton.Click += new System.EventHandler(this.HideLablesButton_Click);
            // 
            // MakeTheCubesGoThroughEachOtherCheckBox
            // 
            this.MakeTheCubesGoThroughEachOtherCheckBox.AutoSize = true;
            this.MakeTheCubesGoThroughEachOtherCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MakeTheCubesGoThroughEachOtherCheckBox.Location = new System.Drawing.Point(12, 113);
            this.MakeTheCubesGoThroughEachOtherCheckBox.Name = "MakeTheCubesGoThroughEachOtherCheckBox";
            this.MakeTheCubesGoThroughEachOtherCheckBox.Size = new System.Drawing.Size(231, 19);
            this.MakeTheCubesGoThroughEachOtherCheckBox.TabIndex = 1;
            this.MakeTheCubesGoThroughEachOtherCheckBox.Text = "Make the cubes go through each other";
            this.MakeTheCubesGoThroughEachOtherCheckBox.UseVisualStyleBackColor = true;
            this.MakeTheCubesGoThroughEachOtherCheckBox.CheckedChanged += new System.EventHandler(this.MakeTheCubesGoThroughEachOtherCheckBox_CheckedChanged);
            // 
            // MakeBlueCubeNonVisibleCheckBox
            // 
            this.MakeBlueCubeNonVisibleCheckBox.AutoSize = true;
            this.MakeBlueCubeNonVisibleCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MakeBlueCubeNonVisibleCheckBox.Location = new System.Drawing.Point(12, 88);
            this.MakeBlueCubeNonVisibleCheckBox.Name = "MakeBlueCubeNonVisibleCheckBox";
            this.MakeBlueCubeNonVisibleCheckBox.Size = new System.Drawing.Size(170, 19);
            this.MakeBlueCubeNonVisibleCheckBox.TabIndex = 3;
            this.MakeBlueCubeNonVisibleCheckBox.Text = "Make blue cube non visible";
            this.MakeBlueCubeNonVisibleCheckBox.UseVisualStyleBackColor = true;
            this.MakeBlueCubeNonVisibleCheckBox.CheckedChanged += new System.EventHandler(this.MakeBlueCubeNonVisibleCheckBox_CheckedChanged);
            // 
            // SmallFontButton
            // 
            this.SmallFontButton.BackColor = System.Drawing.Color.Crimson;
            this.SmallFontButton.Font = new System.Drawing.Font("Simplified Arabic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SmallFontButton.Location = new System.Drawing.Point(327, 86);
            this.SmallFontButton.Name = "SmallFontButton";
            this.SmallFontButton.Size = new System.Drawing.Size(75, 36);
            this.SmallFontButton.TabIndex = 4;
            this.SmallFontButton.Text = "small ";
            this.SmallFontButton.UseVisualStyleBackColor = false;
            this.SmallFontButton.Click += new System.EventHandler(this.SmallFontButton_Click);
            // 
            // BigFontButtom
            // 
            this.BigFontButtom.BackColor = System.Drawing.Color.Crimson;
            this.BigFontButtom.Font = new System.Drawing.Font("Simplified Arabic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BigFontButtom.Location = new System.Drawing.Point(327, 46);
            this.BigFontButtom.Name = "BigFontButtom";
            this.BigFontButtom.Size = new System.Drawing.Size(75, 34);
            this.BigFontButtom.TabIndex = 5;
            this.BigFontButtom.Text = "big ";
            this.BigFontButtom.UseVisualStyleBackColor = false;
            this.BigFontButtom.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 6;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NormalFontButton
            // 
            this.NormalFontButton.BackColor = System.Drawing.Color.Crimson;
            this.NormalFontButton.Font = new System.Drawing.Font("Simplified Arabic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NormalFontButton.Location = new System.Drawing.Point(327, 128);
            this.NormalFontButton.Name = "NormalFontButton";
            this.NormalFontButton.Size = new System.Drawing.Size(75, 36);
            this.NormalFontButton.TabIndex = 7;
            this.NormalFontButton.Text = "normal";
            this.NormalFontButton.UseVisualStyleBackColor = false;
            this.NormalFontButton.Click += new System.EventHandler(this.NormalFontButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(345, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "font";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Simplified Arabic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(107, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 56);
            this.button1.TabIndex = 9;
            this.button1.Text = "Apply Changes on CheckBoxes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GoThroughEachOther
            // 
            this.GoThroughEachOther.Tick += new System.EventHandler(this.GoThroughEachOther_Tick);
            // 
            // HiddenTheInheritanceSideCheckBox
            // 
            this.HiddenTheInheritanceSideCheckBox.AutoSize = true;
            this.HiddenTheInheritanceSideCheckBox.Checked = true;
            this.HiddenTheInheritanceSideCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HiddenTheInheritanceSideCheckBox.Location = new System.Drawing.Point(12, 138);
            this.HiddenTheInheritanceSideCheckBox.Name = "HiddenTheInheritanceSideCheckBox";
            this.HiddenTheInheritanceSideCheckBox.Size = new System.Drawing.Size(174, 19);
            this.HiddenTheInheritanceSideCheckBox.TabIndex = 10;
            this.HiddenTheInheritanceSideCheckBox.Text = "Hidden The Inheritance Side";
            this.HiddenTheInheritanceSideCheckBox.UseVisualStyleBackColor = true;
            this.HiddenTheInheritanceSideCheckBox.CheckedChanged += new System.EventHandler(this.HiddenTheInheritanceSideCheckBox_CheckedChanged);
            // 
            // AbilityToMoveBlueCubeManualyByUser
            // 
            this.AbilityToMoveBlueCubeManualyByUser.AutoSize = true;
            this.AbilityToMoveBlueCubeManualyByUser.Location = new System.Drawing.Point(12, 165);
            this.AbilityToMoveBlueCubeManualyByUser.Name = "AbilityToMoveBlueCubeManualyByUser";
            this.AbilityToMoveBlueCubeManualyByUser.Size = new System.Drawing.Size(211, 19);
            this.AbilityToMoveBlueCubeManualyByUser.TabIndex = 11;
            this.AbilityToMoveBlueCubeManualyByUser.Text = "Ability to move blue cube manualy";
            this.AbilityToMoveBlueCubeManualyByUser.UseVisualStyleBackColor = true;
            this.AbilityToMoveBlueCubeManualyByUser.CheckedChanged += new System.EventHandler(this.AbilityToMoveBlueCubeManualyByUser_CheckedChanged);
            // 
            // PropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(414, 196);
            this.Controls.Add(this.AbilityToMoveBlueCubeManualyByUser);
            this.Controls.Add(this.HiddenTheInheritanceSideCheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NormalFontButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BigFontButtom);
            this.Controls.Add(this.SmallFontButton);
            this.Controls.Add(this.MakeBlueCubeNonVisibleCheckBox);
            this.Controls.Add(this.MakeTheCubesGoThroughEachOtherCheckBox);
            this.Controls.Add(this.HideLablesButton);
            this.Name = "PropertiesForm";
            this.Text = "Properties Window";
            this.Load += new System.EventHandler(this.PropertiesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private SaveFileDialog saveFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button HideLablesButton;
        private CheckBox MakeTheCubesGoThroughEachOtherCheckBox;
        private CheckBox MakeBlueCubeNonVisibleCheckBox;
        private Button SmallFontButton;
        private Button BigFontButtom;
        private Label label1;
        private Button NormalFontButton;
        private Label label2;
        private Button button1;
        private System.Windows.Forms.Timer GoThroughEachOther;
        private CheckBox HiddenTheInheritanceSideCheckBox;
        public CheckBox AbilityToMoveBlueCubeManualyByUser;
    }
}