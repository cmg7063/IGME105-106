namespace HellishGUI
{
    partial class FormQ1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQ1));
            this.labelQ1 = new System.Windows.Forms.Label();
            this.groupBoxQ1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAnimal = new System.Windows.Forms.RadioButton();
            this.radioButtonVegetable = new System.Windows.Forms.RadioButton();
            this.radioButtonMineral = new System.Windows.Forms.RadioButton();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.groupBoxQ1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelQ1
            // 
            this.labelQ1.AutoSize = true;
            this.labelQ1.BackColor = System.Drawing.Color.Transparent;
            this.labelQ1.Location = new System.Drawing.Point(28, 42);
            this.labelQ1.Name = "labelQ1";
            this.labelQ1.Size = new System.Drawing.Size(122, 25);
            this.labelQ1.TabIndex = 0;
            this.labelQ1.Text = "Question 1:";
            // 
            // groupBoxQ1
            // 
            this.groupBoxQ1.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxQ1.Controls.Add(this.radioButtonMineral);
            this.groupBoxQ1.Controls.Add(this.radioButtonVegetable);
            this.groupBoxQ1.Controls.Add(this.radioButtonAnimal);
            this.groupBoxQ1.Location = new System.Drawing.Point(63, 100);
            this.groupBoxQ1.Name = "groupBoxQ1";
            this.groupBoxQ1.Size = new System.Drawing.Size(379, 190);
            this.groupBoxQ1.TabIndex = 1;
            this.groupBoxQ1.TabStop = false;
            this.groupBoxQ1.Text = "Is it classified as Animal, Vegetable or Mineral?";
            // 
            // radioButtonAnimal
            // 
            this.radioButtonAnimal.AutoSize = true;
            this.radioButtonAnimal.Location = new System.Drawing.Point(7, 66);
            this.radioButtonAnimal.Name = "radioButtonAnimal";
            this.radioButtonAnimal.Size = new System.Drawing.Size(108, 29);
            this.radioButtonAnimal.TabIndex = 0;
            this.radioButtonAnimal.TabStop = true;
            this.radioButtonAnimal.Text = "Animal";
            this.radioButtonAnimal.UseVisualStyleBackColor = true;
            // 
            // radioButtonVegetable
            // 
            this.radioButtonVegetable.AutoSize = true;
            this.radioButtonVegetable.Location = new System.Drawing.Point(7, 100);
            this.radioButtonVegetable.Name = "radioButtonVegetable";
            this.radioButtonVegetable.Size = new System.Drawing.Size(140, 29);
            this.radioButtonVegetable.TabIndex = 1;
            this.radioButtonVegetable.TabStop = true;
            this.radioButtonVegetable.Text = "Vegetable";
            this.radioButtonVegetable.UseVisualStyleBackColor = true;
            // 
            // radioButtonMineral
            // 
            this.radioButtonMineral.AutoSize = true;
            this.radioButtonMineral.Location = new System.Drawing.Point(7, 134);
            this.radioButtonMineral.Name = "radioButtonMineral";
            this.radioButtonMineral.Size = new System.Drawing.Size(114, 29);
            this.radioButtonMineral.TabIndex = 2;
            this.radioButtonMineral.TabStop = true;
            this.radioButtonMineral.Text = "Mineral";
            this.radioButtonMineral.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSubmit.BackgroundImage")));
            this.buttonSubmit.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.Yellow;
            this.buttonSubmit.Location = new System.Drawing.Point(63, 324);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(140, 50);
            this.buttonSubmit.TabIndex = 3;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMenu.BackgroundImage")));
            this.buttonMenu.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.Color.Yellow;
            this.buttonMenu.Location = new System.Drawing.Point(302, 324);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(140, 50);
            this.buttonMenu.TabIndex = 4;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // FormQ1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(504, 419);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.groupBoxQ1);
            this.Controls.Add(this.labelQ1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQ1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play 20 Questions!";
            this.groupBoxQ1.ResumeLayout(false);
            this.groupBoxQ1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQ1;
        private System.Windows.Forms.GroupBox groupBoxQ1;
        private System.Windows.Forms.RadioButton radioButtonMineral;
        private System.Windows.Forms.RadioButton radioButtonVegetable;
        private System.Windows.Forms.RadioButton radioButtonAnimal;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonMenu;
    }
}