namespace WinFormsApp6

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
            this.lblFatConsumed = new System.Windows.Forms.Label();
            this.txtFatConsumed = new System.Windows.Forms.TextBox();
            this.txtCrabsConsumed = new System.Windows.Forms.TextBox();
            this.lblCarbohydratesConsumed = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCalories = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblFatConsumed
            //
            this.lblFatConsumed.AutoSize = true;
            this.lblFatConsumed.Location = new System.Drawing.Point(35, 34);
            this.lblFatConsumed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFatConsumed.Name = "lblFatConsumed";
            this.lblFatConsumed.Size = new System.Drawing.Size(148, 17);
            this.lblFatConsumed.TabIndex = 0;
            this.lblFatConsumed.Text = "Fat grams consumed: ";
            //
            // txtFatConsumed
            //
            this.txtFatConsumed.Location = new System.Drawing.Point(264, 31);
            this.txtFatConsumed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFatConsumed.Name = "txtFatConsumed";
            this.txtFatConsumed.Size = new System.Drawing.Size(132, 23);
            this.txtFatConsumed.TabIndex = 1;
            //
            // txtCrabsConsumed
            //
            this.txtCrabsConsumed.Location = new System.Drawing.Point(264, 74);
            this.txtCrabsConsumed.Margin = new System.Windows.Forms.Padding(4);
            this.txtCrabsConsumed.Name = "txtCrabsConsumed";
            this.txtCrabsConsumed.Size = new System.Drawing.Size(132, 23);
            this.txtCrabsConsumed.TabIndex = 3;
            //
            // lblCarbohydratesConsumed
            //
            this.lblCarbohydratesConsumed.AutoSize = true;
            this.lblCarbohydratesConsumed.Location = new System.Drawing.Point(35, 77);
            this.lblCarbohydratesConsumed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarbohydratesConsumed.Name = "lblCarbohydratesConsumed";
            this.lblCarbohydratesConsumed.Size = new System.Drawing.Size(221, 17);
            this.lblCarbohydratesConsumed.TabIndex = 2;
            this.lblCarbohydratesConsumed.Text = "Carbohydrates grams consumed: ";
            //
            // btnCalculate
            //
            this.btnCalculate.Location = new System.Drawing.Point(65, 239);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate Calories";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            //
            // btnExit
            //
            this.btnExit.Location = new System.Drawing.Point(264, 239);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            //
            // lblCalories
            //
            this.lblCalories.Location = new System.Drawing.Point(35, 131);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(361, 81);
            this.lblCalories.TabIndex = 6;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 318);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtCrabsConsumed);
            this.Controls.Add(this.lblCarbohydratesConsumed);
            this.Controls.Add(this.txtFatConsumed);
            this.Controls.Add(this.lblFatConsumed);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Calculate Calories";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label lblFatConsumed;
        private System.Windows.Forms.TextBox txtFatConsumed;
        private System.Windows.Forms.TextBox txtCrabsConsumed;
        private System.Windows.Forms.Label lblCarbohydratesConsumed;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCalories;
    }
}
