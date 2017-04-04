namespace HellishGUI
{
    partial class FormQ7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQ7));
            this.labelQ7 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBoxQ7 = new System.Windows.Forms.GroupBox();
            this.radioButtonMaybe = new System.Windows.Forms.RadioButton();
            this.radioButtonUnknown = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.groupBoxQ7.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelQ7
            // 
            this.labelQ7.AutoSize = true;
            this.labelQ7.BackColor = System.Drawing.Color.Transparent;
            this.labelQ7.Location = new System.Drawing.Point(28, 42);
            this.labelQ7.Name = "labelQ7";
            this.labelQ7.Size = new System.Drawing.Size(122, 25);
            this.labelQ7.TabIndex = 22;
            this.labelQ7.Text = "Question 7:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSubmit.BackgroundImage")));
            this.buttonSubmit.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.Yellow;
            this.buttonSubmit.Location = new System.Drawing.Point(63, 324);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(140, 50);
            this.buttonSubmit.TabIndex = 20;
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
            this.buttonBack.TabIndex = 19;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // groupBoxQ7
            // 
            this.groupBoxQ7.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxQ7.Controls.Add(this.radioButtonMaybe);
            this.groupBoxQ7.Controls.Add(this.radioButtonUnknown);
            this.groupBoxQ7.Controls.Add(this.radioButtonNo);
            this.groupBoxQ7.Controls.Add(this.radioButtonYes);
            this.groupBoxQ7.Location = new System.Drawing.Point(63, 100);
            this.groupBoxQ7.Name = "groupBoxQ7";
            this.groupBoxQ7.Size = new System.Drawing.Size(379, 190);
            this.groupBoxQ7.TabIndex = 21;
            this.groupBoxQ7.TabStop = false;
            this.groupBoxQ7.Text = "Can you smell it?";
            // 
            // radioButtonMaybe
            // 
            this.radioButtonMaybe.AutoSize = true;
            this.radioButtonMaybe.Location = new System.Drawing.Point(7, 139);
            this.radioButtonMaybe.Name = "radioButtonMaybe";
            this.radioButtonMaybe.Size = new System.Drawing.Size(108, 29);
            this.radioButtonMaybe.TabIndex = 3;
            this.radioButtonMaybe.TabStop = true;
            this.radioButtonMaybe.Text = "Maybe";
            this.radioButtonMaybe.UseVisualStyleBackColor = true;
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
            // FormQ7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(504, 419);
            this.Controls.Add(this.labelQ7);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBoxQ7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQ7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play 20 Questions!";
            this.groupBoxQ7.ResumeLayout(false);
            this.groupBoxQ7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQ7;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.GroupBox groupBoxQ7;
        private System.Windows.Forms.RadioButton radioButtonMaybe;
        private System.Windows.Forms.RadioButton radioButtonUnknown;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
    }
}