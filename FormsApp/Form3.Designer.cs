namespace FormsApp
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            txtStart = new TextBox();
            txtEnd = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 72);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 0;
            label1.Text = "Starting Hour (0-23)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 166);
            label2.Name = "label2";
            label2.Size = new Size(164, 25);
            label2.TabIndex = 1;
            label2.Text = "Ending Hour (1-24)";
            label2.Click += label2_Click;
            // 
            // txtStart
            // 
            txtStart.Location = new Point(300, 72);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(150, 31);
            txtStart.TabIndex = 2;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(300, 160);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(150, 31);
            txtEnd.TabIndex = 3;
            txtEnd.TextChanged += textBox2_TextChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(272, 258);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 34);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(300, 339);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(62, 25);
            lblResult.TabIndex = 5;
            lblResult.Text = "          ";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(641, 404);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 6;
            btnBack.Text = "Exit";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnBack);
            Controls.Add(btnCalculate);
            Controls.Add(txtEnd);
            Controls.Add(txtStart);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Bicycle Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtStart;
        private TextBox txtEnd;
        private Button btnCalculate;
        private Label lblResult;
        private Button btnBack;
    }
}