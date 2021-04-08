namespace CargoProject
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
            this.truckBar = new System.Windows.Forms.TrackBar();
            this.trainCarBar = new System.Windows.Forms.TrackBar();
            this.carBar = new System.Windows.Forms.TrackBar();
            this.photo = new System.Windows.Forms.PictureBox();
            this.motorCycleBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newBoatButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.noOfMotorCycle = new System.Windows.Forms.Label();
            this.noOfCar = new System.Windows.Forms.Label();
            this.noOfTruck = new System.Windows.Forms.Label();
            this.noOfTrainCar = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.loaded = new System.Windows.Forms.Label();
            this.reactionColor = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.truckBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainCarBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorCycleBar)).BeginInit();
            this.SuspendLayout();
            // 
            // truckBar
            // 
            this.truckBar.Location = new System.Drawing.Point(329, 275);
            this.truckBar.Maximum = 20;
            this.truckBar.Name = "truckBar";
            this.truckBar.Size = new System.Drawing.Size(201, 45);
            this.truckBar.TabIndex = 2;
            this.truckBar.Scroll += new System.EventHandler(this.truckBar_Scroll);
            // 
            // trainCarBar
            // 
            this.trainCarBar.Location = new System.Drawing.Point(329, 378);
            this.trainCarBar.Maximum = 20;
            this.trainCarBar.Name = "trainCarBar";
            this.trainCarBar.Size = new System.Drawing.Size(201, 45);
            this.trainCarBar.TabIndex = 3;
            this.trainCarBar.Scroll += new System.EventHandler(this.trainCarBar_Scroll);
            // 
            // carBar
            // 
            this.carBar.Location = new System.Drawing.Point(71, 378);
            this.carBar.Name = "carBar";
            this.carBar.Size = new System.Drawing.Size(196, 45);
            this.carBar.TabIndex = 4;
            this.carBar.Scroll += new System.EventHandler(this.carBar_Scroll);
            // 
            // photo
            // 
            this.photo.Image = ((System.Drawing.Image)(resources.GetObject("photo.Image")));
            this.photo.Location = new System.Drawing.Point(71, 43);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(452, 185);
            this.photo.TabIndex = 5;
            this.photo.TabStop = false;
            // 
            // motorCycleBar
            // 
            this.motorCycleBar.Location = new System.Drawing.Point(71, 275);
            this.motorCycleBar.Name = "motorCycleBar";
            this.motorCycleBar.Size = new System.Drawing.Size(196, 45);
            this.motorCycleBar.TabIndex = 6;
            this.motorCycleBar.Scroll += new System.EventHandler(this.motorCycleBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "No of Motorcycle :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "No of Car :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "No of Trucks :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "No of Train Car :";
            // 
            // newBoatButton
            // 
            this.newBoatButton.Location = new System.Drawing.Point(81, 462);
            this.newBoatButton.Name = "newBoatButton";
            this.newBoatButton.Size = new System.Drawing.Size(177, 29);
            this.newBoatButton.TabIndex = 15;
            this.newBoatButton.Text = "New Boat";
            this.newBoatButton.UseVisualStyleBackColor = true;
            this.newBoatButton.Click += new System.EventHandler(this.newBoatButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Truck (11 Units)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Car (5 Units)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Train Car (17 Units)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Motor Cycle (3 Units)";
            // 
            // noOfMotorCycle
            // 
            this.noOfMotorCycle.AutoSize = true;
            this.noOfMotorCycle.Location = new System.Drawing.Point(173, 252);
            this.noOfMotorCycle.Name = "noOfMotorCycle";
            this.noOfMotorCycle.Size = new System.Drawing.Size(13, 13);
            this.noOfMotorCycle.TabIndex = 21;
            this.noOfMotorCycle.Text = "0";
            // 
            // noOfCar
            // 
            this.noOfCar.AutoSize = true;
            this.noOfCar.Location = new System.Drawing.Point(142, 359);
            this.noOfCar.Name = "noOfCar";
            this.noOfCar.Size = new System.Drawing.Size(13, 13);
            this.noOfCar.TabIndex = 22;
            this.noOfCar.Text = "0";
            // 
            // noOfTruck
            // 
            this.noOfTruck.AutoSize = true;
            this.noOfTruck.Location = new System.Drawing.Point(416, 256);
            this.noOfTruck.Name = "noOfTruck";
            this.noOfTruck.Size = new System.Drawing.Size(13, 13);
            this.noOfTruck.TabIndex = 23;
            this.noOfTruck.Text = "0";
            // 
            // noOfTrainCar
            // 
            this.noOfTrainCar.AutoSize = true;
            this.noOfTrainCar.Location = new System.Drawing.Point(426, 359);
            this.noOfTrainCar.Name = "noOfTrainCar";
            this.noOfTrainCar.Size = new System.Drawing.Size(13, 13);
            this.noOfTrainCar.TabIndex = 24;
            this.noOfTrainCar.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(131, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Capacity = 239, Current Loaded =";
            // 
            // loaded
            // 
            this.loaded.AutoSize = true;
            this.loaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loaded.Location = new System.Drawing.Point(381, 170);
            this.loaded.Name = "loaded";
            this.loaded.Size = new System.Drawing.Size(17, 17);
            this.loaded.TabIndex = 26;
            this.loaded.Text = "0";
            // 
            // reactionColor
            // 
            this.reactionColor.AutoSize = true;
            this.reactionColor.BackColor = System.Drawing.Color.LimeGreen;
            this.reactionColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reactionColor.Location = new System.Drawing.Point(109, 60);
            this.reactionColor.Name = "reactionColor";
            this.reactionColor.Size = new System.Drawing.Size(27, 15);
            this.reactionColor.TabIndex = 27;
            this.reactionColor.Text = "      ";
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.container.Location = new System.Drawing.Point(156, 76);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(125, 91);
            this.container.TabIndex = 28;
            this.container.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 507);
            this.Controls.Add(this.container);
            this.Controls.Add(this.reactionColor);
            this.Controls.Add(this.loaded);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.noOfTrainCar);
            this.Controls.Add(this.noOfTruck);
            this.Controls.Add(this.noOfCar);
            this.Controls.Add(this.noOfMotorCycle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.newBoatButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.motorCycleBar);
            this.Controls.Add(this.photo);
            this.Controls.Add(this.carBar);
            this.Controls.Add(this.trainCarBar);
            this.Controls.Add(this.truckBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Fill the Boat";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.truckBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainCarBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorCycleBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar truckBar;
        private System.Windows.Forms.TrackBar trainCarBar;
        private System.Windows.Forms.TrackBar carBar;
        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.TrackBar motorCycleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button newBoatButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label noOfMotorCycle;
        private System.Windows.Forms.Label noOfCar;
        private System.Windows.Forms.Label noOfTruck;
        private System.Windows.Forms.Label noOfTrainCar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label loaded;
        private System.Windows.Forms.Label reactionColor;
        private System.Windows.Forms.Button container;
    }
}

