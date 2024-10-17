using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Physical_Equations
{
    public partial class Form1 : Form
    {
        bool moveUp, moveDown;
      //  private PropertiesForm fform2;
        public Form1()
        {
            MessageBox.Show("The Mute button must be turned on in order to see the experience as it is","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            {
             //   fform2 = form2;
            InitializeComponent();
        }

        int f = 0;
        int v = 0;
        int a = 0;
        int t = 0;
        bool moveup,movedown;
/*
        Stopped s1 = new Stopped(6);
        Moved m1 = new Moved(6, 2);


        Fixed f1 = new Fixed(7);
        Pushed p1 = new Pushed(7, 6);

        class Stopped
        {
            int distance;
            public Stopped() { distance = 1; }
            public Stopped(int distance1) { Distance = distance1; }
            public Stopped(TextBox t1) { Distance = int.Parse(t1.Text); }
            public Stopped(Stopped s) { distance = s.distance; }
            public int Distance
            {
                get { return distance; }
                set
                {
                    if (value > 0) distance = value;
                    else
                    {
                        //  MessageBox.Show("Error in time");
                        distance = 1;
                    }
                }
            }


            public void SetDistanceFromText(TextBox t)
            {
                Distance = int.Parse(t.Text);
                // Distance = "dfgjnlkd";
            }
            public void GetDistanceToText(TextBox t)
            {
                t.Text = distance.ToString() + " m";
            }

        }//class Move

        class Moved : Stopped
        {
            int time;
            public Moved() : base() { time = 3; }
            public Moved(int distance, int time) : base(distance) { Time = time; }
            public Moved(Stopped s, int time) : base(s) { Time = time; }
            public Moved(Moved m) : base(m.Distance) { time = m.time; }
            public int Time
            {
                get { return time; }
                set
                {
                    if (value > 0)
                        time = value;
                    else
                    { time = 1; }
                }
            }
            public void Set(int distance, int time) { base.Distance = distance; Time = time; }
            public void Set(Stopped s, int time) { base.Distance = s.Distance; Time = time; }
            public void Set(Moved m) { base.Distance = m.Distance; time = m.time; }
            public int GetX() { return time; }

            public void SetTimeFromText(TextBox t)
            {
                Time = int.Parse(t.Text);
            }
            public void GetTimeToText(TextBox t)
            {
                t.Text = time.ToString() + " sec";
            }


            public double GetVelocity()
            //يجب التحقق من Time
            { return Distance / time; }


        }//class fixed

        class Fixed
        {
            double mass;
            public Fixed() { mass = 3; }
            public Fixed(double m1) { Mass = m1; }
            public Fixed(TextBox t1, TextBox t2) { Mass = double.Parse(t1.Text); }
            public Fixed(Fixed f) { mass = f.mass; }
            public double Mass
            {
                get { return mass; }
                set
                {
                    if (value > 0) mass = value;
                    else
                    {
                        MessageBox.Show("Error in mass");
                        mass = 1;
                    }
                }
            }


            public void SetMassFromText(TextBox t)
            {
                Mass = double.Parse(t.Text);
            }
            public void GetMassToText(TextBox t)
            {
                t.Text = mass.ToString() + " Kg";
            }




        }//class Pushed

        class Pushed : Fixed
        {
            double accelerating;
            public Pushed() : base() { accelerating = 1; }
            public Pushed(double mass, double accelerating) : base(mass) { Accelerating = accelerating; }
            public Pushed(Fixed f, int r) : base(f) { Accelerating = accelerating; }
            public Pushed(Pushed p) : base(p.Mass) { accelerating = p.accelerating; }
            public double Accelerating
            {
                get { return accelerating; }
                set
                {
                    accelerating = value;

                }
            }
            public void Set(int mass) { base.Mass = mass; Accelerating = accelerating; }
            public void Set(Fixed f, double accelerating) { base.Mass = f.Mass; Accelerating = accelerating; }
            public void Set(Pushed p) { base.Mass = p.Mass; accelerating = p.accelerating; }
            public double GetAccelerating() { return accelerating; }


            public void SetAcceleratingFromText(TextBox t)
            {
                Accelerating = double.Parse(t.Text);
            }
            public void GetAcceleratingToText(TextBox t)
            {
                t.Text = accelerating.ToString() + " m/sec*sec";
            }


            public double GetForce()

            { return Mass * accelerating; }









            /*


            

          
//.................................................................................................


            private void TextTime_TextChanged(object sender, EventArgs e)
            {
                GetTimeFromVelocityInTextBox();
            }

            private void TextVelocity_TextChanged(object sender, EventArgs e)
            {
                GetVelocityFromTimeInTextBox();
            }

            private void TextAccelerating_TextChanged(object sender, EventArgs e)
            {
                GetForceFromAcceleratingInTextBox();
            }

            private void TextForce_TextChanged(object sender, EventArgs e)
            {
                GetAcceleratingFromForceInTextBox();
            }
        }

//.....................................................................................


      




            */




            /*

                private void label6_Click(object sender, EventArgs e)
            {

            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void label9_Click(object sender, EventArgs e)
            {

            }

            private void label8_Click(object sender, EventArgs e)
            {

            }

            private void label7_Click(object sender, EventArgs e)
            {

            }

            private void label10_Click(object sender, EventArgs e)
            {

            }

            private void textBox9_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox8_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox7_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox10_TextChanged(object sender, EventArgs e)
            {

            }








        }

            private void Form1_Load(object sender, EventArgs e)
            {

            }
        */
        }


        /*
        private void GetVelocityButton_Click(object sender, EventArgs e)
        {
            m1.GetDistanceToText(DistanceTxt1);
            m1.GetTimeToText(TimeTxt1);
            VelocityTxt1.Text = m1.GetVelocity().ToString() + " m/sec";

            PropertiesButton.Visible = false;
        }

        private void VelocityTxt1_TextChanged(object sender, EventArgs e)
        {
            m1.GetDistanceToText(DistanceTxt1);
            m1.GetTimeToText(TimeTxt1);
            VelocityTxt1.Text = m1.GetVelocity().ToString() + " m/sec";
        }
        */
        private void TimeTxt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {

            
            string message = "Do you want to clear all Text Boxes?";
            string title = "Clear";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon x = MessageBoxIcon.Information;
            DialogResult result = MessageBox.Show(message, title, buttons, x);
            if (result == DialogResult.Yes)
            {
                ForceTxt1.Text = "0 N";


                MassTxt1.Text = "0 kg";
                DistanceTxt1.Text = "0 m";
                AcceleratingTxt1.Text = "0 m/sec*sec";
                TimeTxt1.Text = "0 sec";
                ForceTxt2.Text = "0 N";
                TimeTxt2.Text = "0 sec";
                AcceleratingTxt2.Text = "0 m.s^-2";
                VelocityTxt2.Text = "0 m.s^-1";
                VelocityTxt1.Text = "0 m/sec";
            }
            else
            {
                // Do something  
            }
            Console.Beep();
        }

        private void DecreaseForceButton_Click(object sender, EventArgs e)
        {
         /*   f--;
            if (f < 0)
            {
                MessageBox.Show("force will take negative value and this mean that object will move in opposite direction", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // f--;
            }
            if (a < 0)
            {
                MessageBox.Show("force will take negative value and this mean accelerating will decrease", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            ForceTxt2.Text = f + " N";
            AcceleratingTxt2.Text = f / 5 + " m.s^-2";

            PropertiesButton.Visible = false;
            Console.Beep();
         */
        }

        private void DecreaseVelocityButton_Click(object sender, EventArgs e)
        {
        /*    v--;

            if (v < 0)
            {
                MessageBox.Show("Velocity will take negative value and this mean that object will move on opposite direction", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                v = -1;

            }
            VelocityTxt2.Text = v + " m/sec";
            if (v != 0)
                TimeTxt2.Text = 100 / v + " sec";
            else
                TimeTxt2.Text = 100 / 1 + " sec";

            PropertiesButton.Visible = false;
            Console.Beep();
        */
        }

        private void IncreaseAcceleratingButton_Click(object sender, EventArgs e)
        {
            //a=v2 - v1
         /*   a++;
            AcceleratingTxt2.Text = a + " m/sec^2";
            ForceTxt2.Text = 5 * a + " N";
            VelocityTxt2.Text = "20 m/sec^-1";
            //  VelocityTxt2.Text = "20 m/sec";
            //wrong   TimeTxt2.Text = "5 sec";
            PropertiesButton.Visible = false;
         */
            Console.Beep();
        }

        private void GetMassButton_Click(object sender, EventArgs e)
        {
        //    f1.GetMassToText(MassTxt1);
          //  PropertiesButton.Visible = false;
        }

        private void IncreaseVelocityButton_Click(object sender, EventArgs e)
        {
         /*   v++;
            if (t == 0)
            {
                MessageBox.Show("can't devide by zero program will decrease velocity value 1 m.s^-1", "Error in denominator value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                v--;
                t = 100 / (v);

            }
            VelocityTxt2.Text = v + " m.s^-1";
            TimeTxt2.Text = t + " sec";  */
            /*  try
             {
               if (t == 0)
             {
           MessageBox.Show("can't divide by zero program will deccrease velocity value");
           t = 100 / (v - 1);
             }
            */

           
            Console.Beep();
        }

        private void GetDefaultValuesButton_Click(object sender, EventArgs e)
        {
            ForceTxt1.Text = "63 N";
            AcceleratingTxt1.Text = "7 m.s^-2";
            MassTxt1.Text = "9 kg";
            VelocityTxt1.Text = "6 m.s^-1";
            DistanceTxt1.Text = "24 m";
            TimeTxt1.Text = "6 sec";

            PropertiesButton.Visible = false;
        }

        private void ClickAndNotifyChangingButton_Click(object sender, EventArgs e)
        {
            IncreaseAcceleratingButton.Enabled = true;
            IncreaseVelocityButton.Enabled = true;
            IncreaseForceButton.Enabled = true;
            IncreaseTimeButton.Enabled = true;
            DecreaseAcceleratingButton.Enabled = true;
            DecreaseForceButton.Enabled = true;
            DecreaseTimeButton.Enabled = true;
            DecreaseVelocityButton.Enabled = true;
           
            ClickToEnableIncreaseAndDecreaseButtonsButton.BackColor=System.Drawing.Color.Navy;

            PropertiesButton.Visible = false;
        }

        private void DecreaseTimeButton_Click(object sender, EventArgs e)
        {

         /*   t--;
            if (t == 0)
            {
                MessageBox.Show("can't devide by zero program will give default value for time", "Error in denominator value", MessageBoxButtons.OK, MessageBoxIcon.Error); t = 1;
            }
            if (t < 0)
            {
              string  message = "time always goes forward!! never goes back do you want to change it's value to continue?";
                string title = "Question";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons,MessageBoxIcon.Question);
              //  MessageBox.Show(messege, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
               
                
                if(result== DialogResult.Yes)
                {
                    this.BackColor = System.Drawing.Color.Gray;
                }
                else
                {
                    // this.BackColor = System.Drawing.Color.Red;

                  //  MessageBox.Show("Error in dominator value if you not change it. , Program will close after few seconds...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    for (int i = 0; i < 5; i++)
                    {
                        Console.Beep();
                        Thread.Sleep(100);
                        
                            

                        }
                    this.Close();
                }
            }
            /*
              
           
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            */
         /*
            TimeTxt2.Text = t + " sec";
            VelocityTxt2.Text = 100 / t + " m.s^-1";

            PropertiesButton.Visible = false;
            */
        }

        private void GetForceButton_Click(object sender, EventArgs e)
        {
         //   p1.GetMassToText(MassTxt1);
          //  p1.GetAcceleratingToText(AcceleratingTxt1);
          //  ForceTxt1.Text = p1.GetForce().ToString() + " N";

            PropertiesButton.Visible = false;
        }

        private void IncreaseTimeButton_Click(object sender, EventArgs e)
        {
/*
            t++;

            TimeTxt2.Text = t + " sec";
            VelocityTxt2.Text = 100 / t + " m.s^-1";

            PropertiesButton.Visible = false;
*/
            Console.Beep();
        }

        private void DecreaseAcceleratingButton_Click(object sender, EventArgs e)
        {
         /*   a--;
            if (f < 0)
            {
                MessageBox.Show("force will take negative value and this mean that object will move on opposite direction", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                f = a * 5;

            }
            AcceleratingTxt2.Text = a + " m/sec^2";
            ForceTxt2.Text = 5 * a + " N";
            VelocityTxt2.Text = "20 m/sec^-1";

            PropertiesButton.Visible = false;
            Console.Beep();
         */
        }

        private void IncreaseForceButton_Click(object sender, EventArgs e)
        {
        /*    f++;
            ForceTxt2.Text = f + " N";
            AcceleratingTxt2.Text = f / 5 + " m/sec^2";

            PropertiesButton.Visible = false;
            Console.Beep();
        */
        }

        private void GetDistanceButton_Click(object sender, EventArgs e)
        {
            //s1.GetDistanceToText(DistanceTxt1);

            PropertiesButton.Visible = false;
            Console.Beep();
        }

        private void GetHelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Instructions:  " +
                "1.The buttons at the top control a variable, noting that the value of other variables changes along with it" +
                "" +
                "2.The RETURN TO START POINT button is to return the blue and pink cube to its original position according to the experiment" +
                "" +
                "3.There is a button which hidden and appears only during the experiment (when pressing its button). Pressing it for the first time slows down the scene and again to return the scene to normal you can hide it again by clicking on the MAKE BUTTON NON VISIBLE button " ,
                 "Program Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AboutThisProgramButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program about Newton's low...In Experement (1) The Cube Will Fall Down..In Experement (2) Cubes will collide with each other.", "About This Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void moveTimerEvent(object sender, EventArgs e)
        {
           
            if (BlueCube.Top < 360)
            {
                TimeTxt2.Text = "4 sec";
                VelocityTxt2.Text = "25 m/sec^-1";
                BlueCube.Top += 8;
                if(MuteButton.BackColor==Color.Crimson)
                {
                    Console.Beep();
                    Thread.Sleep(160);
                }
               
            }
            if (BlueCube.Top > 360)
            {    //  TheTimeItTakesForTheBodyToMove = false;
                BlueCube.Top = 369;
                VelocityTxt2.Text = "0 m/sec";
            }
        }


        private void KeyIsDown(object sender, KeyEventArgs e)
        {//&& fform2.AbilityToMoveBlueCubeManualyByUser.Checked==true
            if (e.KeyCode == Keys.Up && BlueCube.Top>180 && BlueCube.Top<400  )
            {

                BlueCube.Top -= 2;
            }
            //&& fform2.AbilityToMoveBlueCubeManualyByUser.Checked == true
            if (e.KeyCode == Keys.Down && BlueCube.Top > 180 && BlueCube.Top < 400 )
            {
                BlueCube.Top += 2;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            label25.Visible = false;
           
            TheTimeItTakesForTheBodyToMove.Enabled = true;
            HorizontalPictureBox.Visible = false;
            PinkCube.Visible = false;
            button1.BackColor = System.Drawing.Color.Navy;
            button2.BackColor = System.Drawing.Color.Crimson;
            ClickToEnableIncreaseAndDecreaseButtonsButton.BackColor = System.Drawing.Color.Navy;

           
            IncreaseTimeButton.Enabled = false;
            DecreaseTimeButton.Enabled = false;
            IncreaseAcceleratingButton.Enabled = false;
            DecreaseAcceleratingButton.Enabled = false;
            IncreaseVelocityButton.Enabled = false;
            DecreaseVelocityButton.Enabled = false;
            IncreaseForceButton.Enabled = false;
            DecreaseForceButton.Enabled = false;
            Console.Beep();

        }

        private void ReturnToStartPointButton_Click(object sender, EventArgs e)
        {
            string message = "Do you want to return the object to its original position? this will stop the experement. Are you sure you want to continue?";
            string title = "Return to the Starting Point";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {


                button1.Enabled = true;
                button2.Enabled = true;
                HorizontalPictureBox.Visible = true;
                TheTimeItTakesForTheBodyToMove.Enabled = false;
                Timer1ForCollesionExperement.Enabled = false;
                Timer2ForCollesionExperement.Enabled = false;
                Timer3ForCollesionExperement.Enabled = false;
                TheTimeItTakesForTheBodyToMoveWithAccelerating.Enabled = false;

                BlueCube.Top = 178;
                PinkCube.Top = 369;

                IncreaseTimeButton.Enabled = true;
                DecreaseTimeButton.Enabled = true;
                IncreaseAcceleratingButton.Enabled = true;
                DecreaseAcceleratingButton.Enabled = true;
                IncreaseVelocityButton.Enabled = true;
                DecreaseVelocityButton.Enabled = true;
                IncreaseForceButton.Enabled = true;
                DecreaseForceButton.Enabled = true;
                Console.Beep();

                //   ReturnToStartPointButton.Enabled = false;
            }
            else
            {
                //
            }
        }

        private void StopBlueCubeMovingButton_Click(object sender, EventArgs e)
        {
            //  BlueCube.Top 
        }


        private void button2_Click(object sender, EventArgs e)
        {
            BlueCube.Top = 137;
            PinkCube.Top = 315;
            ShowPhysicalEquationsExplanationButton.Visible = true;
            label25.Visible = false;
           
            TheTimeItTakesForTheBodyToMoveWithAccelerating.Enabled = true;
            HorizontalPictureBox.Visible = false;
            PinkCube.Visible = true;
            button2.BackColor = System.Drawing.Color.Navy;
            button1.BackColor = System.Drawing.Color.Crimson;
            ClickToEnableIncreaseAndDecreaseButtonsButton.BackColor = System.Drawing.Color.Crimson;

          

            IncreaseTimeButton.Enabled = false;
            DecreaseTimeButton.Enabled = false;
            IncreaseAcceleratingButton.Enabled = false;
            DecreaseAcceleratingButton.Enabled = false;
            IncreaseVelocityButton.Enabled = false;
            DecreaseVelocityButton.Enabled = false;
            IncreaseForceButton.Enabled = false;
            DecreaseForceButton.Enabled = false;
            Console.Beep();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ShowParagraphButton_Click(object sender, EventArgs e)
        {
           PropertiesForm Form2= new PropertiesForm(this);
            Form2.Show();



        }

     private int clickCounter = 0;
        private void ShowTheObjectMovmentStepByStepButton_Click(object sender, EventArgs e)
        {
            if (clickCounter >= 1)
            {
                Timer1ForCollesionExperement.Interval = 150;
                Timer2ForCollesionExperement.Interval = 150;
                Timer3ForCollesionExperement.Interval = 150;
                TheTimeItTakesForTheBodyToMove.Interval = 150;
                TheTimeItTakesForTheBodyToMoveWithAccelerating.Interval = 150;
                clickCounter = 0;
                ClickToEnableIncreaseAndDecreaseButtonsButton.BackColor = System.Drawing.Color.Navy;
            }
            else
            {
                Timer1ForCollesionExperement.Interval = 100;
                Timer2ForCollesionExperement.Interval = 100;
                Timer3ForCollesionExperement.Interval = 100;
                TheTimeItTakesForTheBodyToMove.Interval = 100;
                TheTimeItTakesForTheBodyToMoveWithAccelerating.Interval = 100;
               // ClickAndNotifyChangingButton.BackColor = System.Drawing.Color.DarkBlue;


                clickCounter += 1;
            }

            Console.Beep();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            GetVelocityButton.Visible = false;
           GetMassButton.Visible = false;
           GetForceButton.Visible = false;
            GetDistanceButton.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            TimeTxt1.Visible = false;
            VelocityTxt1.Visible = false;
            DistanceTxt1.Visible = false;
       AcceleratingTxt1.Visible = false;
           ForceTxt1.Visible = false;
            MassTxt1.Visible = false;
            label26.Visible = false;
            ExplanationLabel.Visible = true;

        }

        private void Timer1ForCollesionExperement_Tick(object sender, EventArgs e)
        {
            //Pink
            PinkCube.Top += 12;
            if(PinkCube.Top>302)
            {
                PinkCube.Top = 315;
            }
        }

        private void Timer2ForCollesionExperement_Tick(object sender, EventArgs e)
        {
            BlueCube.Top -= 12;
            
        }

        private void Timer3ForCollesionExperement_Tick(object sender, EventArgs e)
        {
            BlueCube.Top += 8;
        }

        private int clickCounterForMute = 0;
        private void MuteButton_Click(object sender, EventArgs e)
        {
            if (clickCounterForMute >= 1)
            {
                MuteButton.BackColor = System.Drawing.Color.Crimson;
                clickCounterForMute = 0;
            }
            else
            {
                MuteButton.BackColor = System.Drawing.Color.Navy;
                clickCounterForMute += 1;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void TheTimeItTakesForTheBodyToMoveWithAccelerating_Tick(object sender, EventArgs e)
        {
            //f1=m1.a1 m1=m2 f1>f2 <== a1>a2
            //a for blue cube is greater than a for pink cube
            //الخطة كالتالي اولا سيرتفع المكعبان ليصتدمان ببعضهما ومن البداية ستكون قوتاهما الابتدائية اي قوة الدفع متكافئة
            //لكن بسبب ان الزهري يقاوم الجاذبية فسيكون الصدم اقرب الى الارض منه الى السقف
            //ثم نتيجة الصدم سيرتفع المكعب الازرق قليلا للاعلى والزهري سيهبط قبله للارض
            //وسيقع بعدها الازرق فوقه
            if (BlueCube.Top < 178 && PinkCube.Top > 300)
            {

                BlueCube.Top += 9;
                PinkCube.Top -= 6;

            }
            if (PinkCube.Top < 270)
            {
                Timer1ForCollesionExperement.Enabled = true;
                Timer2ForCollesionExperement.Enabled = true;
                if (BlueCube.Top < 245)
                {
                    Timer2ForCollesionExperement.Enabled = false;
                    //   Timer3ForCollesionExperement.Enabled = true;
                    if (BlueCube.Top > 250)
                    {
                        Timer3ForCollesionExperement.Enabled = false;

                        BlueCube.Top = 270;
                    }


                }

            }


        }
        }
    }

    


