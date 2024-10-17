using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Physical_Equations
{
    public partial class PropertiesForm : Form
    {
        private  Form1 fform1;
        public PropertiesForm(Form1 form1 )
        {
           fform1 = form1;
            InitializeComponent();
        }
      //  private Form1 mainForm = null;
        private void button3_Click(object sender, EventArgs e)
        {
          /*  MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("If you want font bigger you can't show the experement as it should be. do you want to continue?", "", buttons, MessageBoxIcon.Question);
            //IncreaseTimeButton
            if (result == DialogResult.Yes)
            {  */
                fform1.button1.Font = new Font("Simplified Arabic", 12, FontStyle.Bold);
                fform1.button2.Font = new Font("Simplified Arabic", 12, FontStyle.Bold);
                fform1.GetVelocityButton.Font = new Font("Simplified Arabic", 12, FontStyle.Bold);
                fform1.AboutThisProgramButton.Font = new Font("Simplified Arabic", 12, FontStyle.Bold);
                fform1.GetHelpButton.Font = new Font("Simplified Arabic", 12, FontStyle.Bold);
                fform1.GetDefaultValuesButton.Font = new Font("Simplified Arabic", 12, FontStyle.Bold);
                fform1.ShowPhysicalEquationsExplanationButton.Font = new Font("Simplified Arabic", 12, FontStyle.Bold);
                fform1.GetDistanceButton.Font = new Font("Simplified Arabic", 12, FontStyle.Bold);
                fform1.GetMassButton.Font = new Font("Simplified Arabic", 12, FontStyle.Bold);
                fform1.GetForceButton.Font = new Font("Simplified Arabic", 12, FontStyle.Bold);
                fform1.ClearAllButton.Font = new Font("Simplified Arabic", 12, FontStyle.Bold);
                fform1.ReturnToStartPointButton.Font = new Font("Simplified Arabic", 12, FontStyle.Bold);
                fform1.ClickToEnableIncreaseAndDecreaseButtonsButton.Font = new Font("Simplified Arabic", 12, FontStyle.Bold);

                fform1.ShowTheObjectMovmentStepByStepButton.Font = new Font("Simplified Arabic", 12, FontStyle.Bold);
               
              //  fform1.label12.Font = new Font("Simplified Arabic", 12, FontStyle.Bold);
                fform1.label26.Font = new Font("Simplified Arabic", 12, FontStyle.Bold);

                fform1.IncreaseAcceleratingButton.Font = new Font("Simplified Arabic", 12, FontStyle.Bold);
                fform1.DecreaseAcceleratingButton.Font = new Font("Simplified Arabic", 12, FontStyle.Bold);
                fform1.IncreaseForceButton.Font = new Font("Simplified Arabic", 12, FontStyle.Bold);
                fform1.DecreaseForceButton.Font = new Font("Simplified Arabic", 12, FontStyle.Bold);
                fform1.IncreaseTimeButton.Font = new Font("Simplified Arabic", 12, FontStyle.Bold);
                fform1.DecreaseTimeButton.Font = new Font("Simplified Arabic", 12, FontStyle.Bold);
                fform1.IncreaseVelocityButton.Font = new Font("Simplified Arabic", 12, FontStyle.Bold);
                fform1.DecreaseVelocityButton.Font = new Font("Simplified Arabic", 12, FontStyle.Bold);

                //  DistanceTxt1
              
               
          //  }
           // else { }
        }

      /*  public PropertiesForm(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }
      */
        private void PropertiesForm_Load(object sender, EventArgs e)
        {

        }

        private void SmallFontButton_Click(object sender, EventArgs e)
        {
            fform1.button1.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.button2.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.GetVelocityButton.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.AboutThisProgramButton.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.GetHelpButton.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.GetDefaultValuesButton.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.ShowPhysicalEquationsExplanationButton.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.GetDistanceButton.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.GetMassButton.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.GetForceButton.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.ClearAllButton.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.ReturnToStartPointButton.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.ClickToEnableIncreaseAndDecreaseButtonsButton.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.button1.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.ShowTheObjectMovmentStepByStepButton.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.label1.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.label1.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.label2.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.label3.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.label4.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.label5.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.label6.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.label9.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.label8.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.label9.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.label10.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
          //  fform1.label12.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.label26.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);

            fform1.IncreaseAcceleratingButton.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.DecreaseAcceleratingButton.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.IncreaseForceButton.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.DecreaseForceButton.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.IncreaseTimeButton.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.DecreaseTimeButton.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.IncreaseVelocityButton.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.DecreaseVelocityButton.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);

            fform1.DistanceTxt1.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.VelocityTxt1.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.VelocityTxt2.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.ForceTxt1.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.ForceTxt2.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.AcceleratingTxt1.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.AcceleratingTxt2.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.TimeTxt1.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.TimeTxt2.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.MassTxt1.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.label25.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
        }

        private void NormalFontButton_Click(object sender, EventArgs e)
        {
            fform1.button1.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.button2.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.GetVelocityButton.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.AboutThisProgramButton.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.GetHelpButton.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.GetDefaultValuesButton.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.ShowPhysicalEquationsExplanationButton.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.GetDistanceButton.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.GetMassButton.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.GetForceButton.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.ClearAllButton.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.ReturnToStartPointButton.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.ClickToEnableIncreaseAndDecreaseButtonsButton.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.button1.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.ShowTheObjectMovmentStepByStepButton.Font = new Font("Simplified Arabic", 9, FontStyle.Bold);
            fform1.label1.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.label1.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.label2.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.label3.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.label4.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.label5.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.label6.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.label9.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.label8.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.label9.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.label10.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
          //  fform1.label12.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.label26.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);

            fform1.IncreaseAcceleratingButton.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.DecreaseAcceleratingButton.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.IncreaseForceButton.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.DecreaseForceButton.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.IncreaseTimeButton.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.DecreaseTimeButton.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.IncreaseVelocityButton.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.DecreaseVelocityButton.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);

            fform1.DistanceTxt1.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.VelocityTxt1.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.VelocityTxt2.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.ForceTxt1.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.ForceTxt2.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.AcceleratingTxt1.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.AcceleratingTxt2.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.TimeTxt1.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.TimeTxt2.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.MassTxt1.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
            fform1.label25.Font = new Font("Simplified Arabic", 11, FontStyle.Bold);
        }

        private void HideLablesButton_Click(object sender, EventArgs e)
        {
          
            fform1.label25.Visible = false;
            fform1.label26.Visible = false;
          

            Console.Beep();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MakeBlueCubeNonVisibleCheckBox.Checked ==true)
            {
                fform1.BlueCube.Visible = false;

            }
            if (MakeBlueCubeNonVisibleCheckBox.Checked == false)
            {
                fform1.BlueCube.Visible = true;

            }
           
        
            if (MakeTheCubesGoThroughEachOtherCheckBox.Checked==true)
            {
              //  if(fform1.button2.BackColor== System.Drawing.Color.Navy)
               // {
                    GoThroughEachOther.Enabled = true;
                fform1.PinkCube.Visible = true;
              //  }
            }
            if (MakeTheCubesGoThroughEachOtherCheckBox.Checked == false)
            {
               
                GoThroughEachOther.Enabled = false;
                fform1.BlueCube.Top = 198;
                fform1.PinkCube.Top = 369;
            }
            if(HiddenTheInheritanceSideCheckBox.Checked==true)
            {
               
                fform1.GetVelocityButton.Visible = false;
                fform1.GetMassButton.Visible = false;
                fform1.GetForceButton.Visible = false;
                fform1.GetDistanceButton.Visible = false;
                fform1.label1.Visible = false;
                fform1.label2.Visible = false;
                fform1.label3.Visible = false;
                fform1.label4.Visible = false;
                fform1.label5.Visible = false;
                fform1.label6.Visible = false;
                fform1.TimeTxt1.Visible = false;
                fform1.VelocityTxt1.Visible = false;
                fform1.DistanceTxt1.Visible = false;
                fform1.AcceleratingTxt1.Visible = false;
                fform1.ForceTxt1.Visible = false;
                fform1.MassTxt1.Visible = false;
                fform1.GetDefaultValuesButton.Visible = true;

            }
            if (HiddenTheInheritanceSideCheckBox.Checked == false)
            {

                fform1.GetVelocityButton.Visible = true;
                fform1.GetMassButton.Visible = true;
                fform1.GetForceButton.Visible = true;
                fform1.GetDistanceButton.Visible = true;
                fform1.label1.Visible = true;
                fform1.label2.Visible = true;
                fform1.label3.Visible = true;
                fform1.label4.Visible = true;
                fform1.label5.Visible = true;
                fform1.label6.Visible = true;
                fform1.TimeTxt1.Visible = true;
                fform1.VelocityTxt1.Visible = true;
                fform1.DistanceTxt1.Visible = true;
                fform1.AcceleratingTxt1.Visible = true;
                fform1.ForceTxt1.Visible = true;
                fform1.MassTxt1.Visible = true;
                fform1.ExplanationLabel.Visible = false;
                fform1.GetDefaultValuesButton.Visible = true;
            }
            Console.Beep();
        }

        private void GoThroughEachOther_Tick(object sender, EventArgs e)
        {
            
            fform1.BlueCube.Top += 9;
            fform1.PinkCube.Top -= 9;
            if (fform1.PinkCube.Top < 198)
            {
                fform1.BlueCube.Top = 369;
                fform1.PinkCube.Top = 175;
            }
        }

        private void HiddenTheInheritanceSideCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AbilityToMoveBlueCubeManualyByUser_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MakeBlueCubeNonVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MakeTheCubesGoThroughEachOtherCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
