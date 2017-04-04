namespace HellishGUI
{
    partial class FormReady
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReady));
            this.groupBoxQ1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.labelCalculating = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.groupBoxQ1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxQ1
            // 
            this.groupBoxQ1.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxQ1.Controls.Add(this.radioButtonNo);
            this.groupBoxQ1.Controls.Add(this.radioButtonYes);
            this.groupBoxQ1.Location = new System.Drawing.Point(63, 100);
            this.groupBoxQ1.Name = "groupBoxQ1";
            this.groupBoxQ1.Size = new System.Drawing.Size(379, 190);
            this.groupBoxQ1.TabIndex = 0;
            this.groupBoxQ1.TabStop = false;
            this.groupBoxQ1.Text = "Are you ready?";
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(7, 69);
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
            this.radioButtonYes.Location = new System.Drawing.Point(7, 35);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(81, 29);
            this.radioButtonYes.TabIndex = 0;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // labelCalculating
            // 
            this.labelCalculating.AutoSize = true;
            this.labelCalculating.BackColor = System.Drawing.Color.Transparent;
            this.labelCalculating.Location = new System.Drawing.Point(28, 42);
            this.labelCalculating.Name = "labelCalculating";
            this.labelCalculating.Size = new System.Drawing.Size(163, 25);
            this.labelCalculating.TabIndex = 1;
            this.labelCalculating.Text = "I am guessing...";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSubmit.BackgroundImage")));
            this.buttonSubmit.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.Yellow;
            this.buttonSubmit.Location = new System.Drawing.Point(175, 324);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(140, 50);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // FormReady
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(504, 419);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelCalculating);
            this.Controls.Add(this.groupBoxQ1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReady";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play 20 Questions!";
            this.groupBoxQ1.ResumeLayout(false);
            this.groupBoxQ1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxQ1;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.Label labelCalculating;
        private System.Windows.Forms.Button buttonSubmit;
    }
}