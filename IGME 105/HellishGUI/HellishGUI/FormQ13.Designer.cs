namespace HellishGUI
{
    partial class FormQ13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQ13));
            this.labelQ13 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBoxQ13 = new System.Windows.Forms.GroupBox();
            this.radioButtonSometimes = new System.Windows.Forms.RadioButton();
            this.radioButtonUnknown = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.groupBoxQ13.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelQ13
            // 
            this.labelQ13.AutoSize = true;
            this.labelQ13.BackColor = System.Drawing.Color.Transparent;
            this.labelQ13.Location = new System.Drawing.Point(28, 42);
            this.labelQ13.Name = "labelQ13";
            this.labelQ13.Size = new System.Drawing.Size(134, 25);
            this.labelQ13.TabIndex = 46;
            this.labelQ13.Text = "Question 13:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSubmit.BackgroundImage")));
            this.buttonSubmit.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.Yellow;
            this.buttonSubmit.Location = new System.Drawing.Point(63, 324);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(140, 50);
            this.buttonSubmit.TabIndex = 44;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.Yellow;
            this.buttonBack.Location = new System.Drawing.Point(302, 324);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(140, 50);
            this.buttonBack.TabIndex = 43;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // groupBoxQ13
            // 
            this.groupBoxQ13.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxQ13.Controls.Add(this.radioButtonSometimes);
            this.groupBoxQ13.Controls.Add(this.radioButtonUnknown);
            this.groupBoxQ13.Controls.Add(this.radioButtonNo);
            this.groupBoxQ13.Controls.Add(this.radioButtonYes);
            this.groupBoxQ13.Location = new System.Drawing.Point(63, 100);
            this.groupBoxQ13.Name = "groupBoxQ13";
            this.groupBoxQ13.Size = new System.Drawing.Size(379, 190);
            this.groupBoxQ13.TabIndex = 45;
            this.groupBoxQ13.TabStop = false;
            this.groupBoxQ13.Text = "Does it bring joy to people? ";
            // 
            // radioButtonSometimes
            // 
            this.radioButtonSometimes.AutoSize = true;
            this.radioButtonSometimes.Location = new System.Drawing.Point(7, 139);
            this.radioButtonSometimes.Name = "radioButtonSometimes";
            this.radioButtonSometimes.Size = new System.Drawing.Size(149, 29);
            this.radioButtonSometimes.TabIndex = 3;
            this.radioButtonSometimes.TabStop = true;
            this.radioButtonSometimes.Text = "Sometimes";
            this.radioButtonSometimes.UseVisualStyleBackColor = true;
            // 
            // radioButtonUnknown
            // 
            this.radioButtonUnknown.AutoSize = true;
            this.radioButtonUnknown.Location = new System.Drawing.Point(7, 105);
            this.radioButtonUnknown.Name = "radioButtonUnknown";
            this.radioButtonUnknown.Size = new System.Drawing.Size(132, 29);
            this.radioButtonUnknown.TabIndex = 2;
            this.radioButtonUnknown.TabStop = true;
            this.radioButtonUnknown.Text = "Unknown";
            this.radioButtonUnknown.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(7, 71);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(70, 29);
            this.radioButtonNo.TabIndex = 1;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(7, 37);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(81, 29);
            this.radioButtonYes.TabIndex = 0;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // FormQ13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(504, 419);
            this.Controls.Add(this.labelQ13);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBoxQ13);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQ13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play 20 Questions!";
            this.groupBoxQ13.ResumeLayout(false);
            this.groupBoxQ13.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQ13;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.GroupBox groupBoxQ13;
        private System.Windows.Forms.RadioButton radioButtonSometimes;
        private System.Windows.Forms.RadioButton radioButtonUnknown;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
    }
}