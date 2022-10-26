namespace QuadraticEquation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textInputA = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.textInputB = new System.Windows.Forms.TextBox();
            this.labelC = new System.Windows.Forms.Label();
            this.textInputC = new System.Windows.Forms.TextBox();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.labelDelta = new System.Windows.Forms.Label();
            this.textBoxDelta = new System.Windows.Forms.TextBox();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.labelX1 = new System.Windows.Forms.Label();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // textInputA
            // 
            this.textInputA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textInputA.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textInputA.Location = new System.Drawing.Point(141, 63);
            this.textInputA.MaxLength = 3;
            this.textInputA.Name = "textInputA";
            this.textInputA.Size = new System.Drawing.Size(50, 27);
            this.textInputA.TabIndex = 0;
            this.textInputA.Text = "a";
            this.textInputA.Enter += new System.EventHandler(this.txtInputA_Enter);
            this.textInputA.Leave += new System.EventHandler(this.txtInputA_Leave);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelA.Location = new System.Drawing.Point(76, 66);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(59, 19);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "Enter a:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelB.Location = new System.Drawing.Point(76, 107);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(59, 19);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "Enter b:";
            // 
            // textInputB
            // 
            this.textInputB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textInputB.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textInputB.Location = new System.Drawing.Point(141, 104);
            this.textInputB.Name = "textInputB";
            this.textInputB.Size = new System.Drawing.Size(50, 27);
            this.textInputB.TabIndex = 2;
            this.textInputB.Text = "b";
            this.textInputB.Enter += new System.EventHandler(this.textInputB_Enter);
            this.textInputB.Leave += new System.EventHandler(this.textInputB_Leave);
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelC.Location = new System.Drawing.Point(76, 146);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(58, 19);
            this.labelC.TabIndex = 5;
            this.labelC.Text = "Enter c:";
            // 
            // textInputC
            // 
            this.textInputC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textInputC.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textInputC.Location = new System.Drawing.Point(141, 143);
            this.textInputC.Name = "textInputC";
            this.textInputC.Size = new System.Drawing.Size(50, 27);
            this.textInputC.TabIndex = 4;
            this.textInputC.Text = "c";
            this.textInputC.Enter += new System.EventHandler(this.textInputC_Enter);
            this.textInputC.Leave += new System.EventHandler(this.textInputC_Leave);
            // 
            // buttonSolve
            // 
            this.buttonSolve.Location = new System.Drawing.Point(176, 198);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(160, 49);
            this.buttonSolve.TabIndex = 6;
            this.buttonSolve.Text = "Solve";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // labelDelta
            // 
            this.labelDelta.AutoSize = true;
            this.labelDelta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDelta.Location = new System.Drawing.Point(308, 66);
            this.labelDelta.Name = "labelDelta";
            this.labelDelta.Size = new System.Drawing.Size(56, 19);
            this.labelDelta.TabIndex = 7;
            this.labelDelta.Text = "Delta =";
            this.labelDelta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxDelta
            // 
            this.textBoxDelta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDelta.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDelta.Location = new System.Drawing.Point(370, 63);
            this.textBoxDelta.MaxLength = 3;
            this.textBoxDelta.Name = "textBoxDelta";
            this.textBoxDelta.ReadOnly = true;
            this.textBoxDelta.Size = new System.Drawing.Size(50, 27);
            this.textBoxDelta.TabIndex = 8;
            // 
            // textBoxX1
            // 
            this.textBoxX1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxX1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxX1.Location = new System.Drawing.Point(370, 104);
            this.textBoxX1.MaxLength = 3;
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.ReadOnly = true;
            this.textBoxX1.Size = new System.Drawing.Size(50, 27);
            this.textBoxX1.TabIndex = 10;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelX1.Location = new System.Drawing.Point(328, 107);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(36, 19);
            this.labelX1.TabIndex = 9;
            this.labelX1.Text = "x1 =";
            this.labelX1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxX2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxX2.Location = new System.Drawing.Point(370, 143);
            this.textBoxX2.MaxLength = 3;
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.ReadOnly = true;
            this.textBoxX2.Size = new System.Drawing.Size(50, 27);
            this.textBoxX2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(328, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "x2 =";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "Wrong value entered!";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(517, 286);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxDelta);
            this.Controls.Add(this.labelDelta);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.textInputC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.textInputB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textInputA);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quadratic Equation Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textInputA;
        private Label labelA;
        private Label labelB;
        private TextBox textInputB;
        private Label labelC;
        private TextBox textInputC;
        private Button buttonSolve;
        private Label labelDelta;
        private TextBox textBoxDelta;
        private TextBox textBoxX1;
        private Label labelX1;
        private TextBox textBoxX2;
        private Label label2;
        private NotifyIcon notifyIcon1;
    }
}