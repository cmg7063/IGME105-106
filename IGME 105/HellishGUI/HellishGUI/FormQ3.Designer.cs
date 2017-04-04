namespace HellishGUI
{
    partial class FormQ3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQ3));
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.groupBoxQ3 = new System.Windows.Forms.GroupBox();
            this.radioButtonSometimes = new System.Windows.Forms.RadioButton();
            this.radioButtonUnknown = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.labelQ3 = new System.Windows.Forms.Label();
            this.groupBoxQ3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.Yellow;
            this.buttonBack.Location = new System.Drawing.Point(307, 324);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(140, 50);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSubmit.BackgroundImage")));
            this.buttonSubmit.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.Yellow;
            this.buttonSubmit.Location = new System.Drawing.Point(63, 324);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(140, 50);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // groupBoxQ3
            // 
            this.groupBoxQ3.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxQ3.Controls.Add(this.radioButtonSometimes);
            this.groupBoxQ3.Controls.Add(this.radioButtonUnknown);
            this.groupBoxQ3.Controls.Add(this.radioButtonNo);
            this.groupBoxQ3.Controls.Add(this.radioButtonYes);
            this.groupBoxQ3.Location = new System.Drawing.Point(63, 100);
            this.groupBoxQ3.Name = "groupBoxQ3";
            this.groupBoxQ3.Size = new System.Drawing.Size(379, 190);
            this.groupBoxQ3.TabIndex = 7;
            this.groupBoxQ3.TabStop = false;
            this.groupBoxQ3.Text = "Is it outside? ";
            // 
            // radioButtonSometimes
            // 
            this.radioButtonSometimes.AutoSize = true;
            this.radioButtonSometimes.Location = new System.Drawing.Point(7, 135);
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
            this.radioButtonUnknown.Location = new System.Drawing.Point(7, 101);
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
            this.radioButtonNo.Location = new System.Drawing.Point(7, 67);
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
            this.radioButtonYes.Location = new System.Drawing.Point(7, 33);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(81, 29);
            this.radioButtonYes.TabIndex = 0;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // labelQ3
            // 
            this.labelQ3.AutoSize = true;
            this.labelQ3.BackColor = System.Drawing.Color.Transparent;
            this.labelQ3.Location = new System.Drawing.Point(28, 42);
            this.labelQ3.Name = "labelQ3";
            this.labelQ3.Size = new System.Drawing.Size(122, 25);
            this.labelQ3.TabIndex = 8;
            this.labelQ3.Text = "Question 3:";
            // 
            // FormQ3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(504, 419);
            this.Controls.Add(this.labelQ3);
            this.Controls.Add(this.groupBoxQ3);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQ3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play 20 Questions!";
            this.groupBoxQ3.ResumeLayout(false);
            this.groupBoxQ3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.GroupBox groupBoxQ3;
        private System.Windows.Forms.RadioButton radioButtonSometimes;
        private System.Windows.Forms.RadioButton radioButtonUnknown;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.Label labelQ3;
    }
}