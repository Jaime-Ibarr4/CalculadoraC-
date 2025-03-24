namespace MiCalculadora
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button sqrtButton;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button openParenButton;
        private System.Windows.Forms.Button closeParenButton;
        private System.Windows.Forms.Button sinButton;
        private System.Windows.Forms.Button voiceButton;
        private System.Windows.Forms.Button cameraButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.openParenButton = new System.Windows.Forms.Button();
            this.closeParenButton = new System.Windows.Forms.Button();
            this.sinButton = new System.Windows.Forms.Button();
            this.voiceButton = new System.Windows.Forms.Button();
            this.cameraButton = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // inputBox
            this.inputBox.Location = new System.Drawing.Point(12, 12);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(275, 20);
            this.inputBox.BackColor = System.Drawing.Color.FromArgb(222, 239, 231);
            this.inputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputBox.Font = new System.Drawing.Font("Arial", 12F);

            // resultBox
            this.resultBox.Location = new System.Drawing.Point(12, 38);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(275, 20);
            this.resultBox.BackColor = System.Drawing.Color.FromArgb(222, 239, 231);
            this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);

            // addButton
            this.addButton.Location = new System.Drawing.Point(180, 90);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(50, 23);
            this.addButton.Text = "+";
            this.addButton.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Arial", 12F);
            this.addButton.Click += new System.EventHandler(this.addButton_Click);

            // subtractButton
            this.subtractButton.Location = new System.Drawing.Point(236, 90);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(50, 23);
            this.subtractButton.Text = "-";
            this.subtractButton.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.subtractButton.ForeColor = System.Drawing.Color.White;
            this.subtractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtractButton.Font = new System.Drawing.Font("Arial", 12F);
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);

            // multiplyButton
            this.multiplyButton.Location = new System.Drawing.Point(180, 119);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(50, 23);
            this.multiplyButton.Text = "*";
            this.multiplyButton.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.multiplyButton.ForeColor = System.Drawing.Color.White;
            this.multiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplyButton.Font = new System.Drawing.Font("Arial", 12F);
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);

            // divideButton
            this.divideButton.Location = new System.Drawing.Point(236, 119);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(50, 23);
            this.divideButton.Text = "/";
            this.divideButton.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.divideButton.ForeColor = System.Drawing.Color.White;
            this.divideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divideButton.Font = new System.Drawing.Font("Arial", 12F);
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);

            // sqrtButton
            this.sqrtButton.Location = new System.Drawing.Point(180, 148);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(50, 23);
            this.sqrtButton.Text = "√";
            this.sqrtButton.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.sqrtButton.ForeColor = System.Drawing.Color.White;
            this.sqrtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrtButton.Font = new System.Drawing.Font("Arial", 12F);
            this.sqrtButton.Click += new System.EventHandler(this.sqrtButton_Click);

            // sinButton
            this.sinButton.Location = new System.Drawing.Point(236, 148);
            this.sinButton.Name = "sinButton";
            this.sinButton.Size = new System.Drawing.Size(50, 23);
            this.sinButton.Text = "sin";
            this.sinButton.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.sinButton.ForeColor = System.Drawing.Color.White;
            this.sinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sinButton.Font = new System.Drawing.Font("Arial", 12F);
            this.sinButton.Click += new System.EventHandler(this.sinButton_Click);

            // equalsButton
            this.equalsButton.Location = new System.Drawing.Point(180, 177);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(50, 23);
            this.equalsButton.Text = "=";
            this.equalsButton.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.equalsButton.ForeColor = System.Drawing.Color.White;
            this.equalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equalsButton.Font = new System.Drawing.Font("Arial", 12F);
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);

            // clearButton
            this.clearButton.Location = new System.Drawing.Point(236, 177);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(50, 23);
            this.clearButton.Text = "Clear";
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Arial", 12F);
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);

            // button0
            this.button0.Location = new System.Drawing.Point(68, 177);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(50, 23);
            this.button0.Text = "0";
            this.button0.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.button0.ForeColor = System.Drawing.Color.White;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Arial", 12F);
            this.button0.Click += new System.EventHandler(this.numberButton_Click);

            // button1
            this.button1.Location = new System.Drawing.Point(12, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.Text = "1";
            this.button1.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F);
            this.button1.Click += new System.EventHandler(this.numberButton_Click);

            // button2
            this.button2.Location = new System.Drawing.Point(68, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.Text = "2";
            this.button2.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 12F);
            this.button2.Click += new System.EventHandler(this.numberButton_Click);

            // button3
            this.button3.Location = new System.Drawing.Point(124, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 23);
            this.button3.Text = "3";
            this.button3.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 12F);
            this.button3.Click += new System.EventHandler(this.numberButton_Click);

            // button4
            this.button4.Location = new System.Drawing.Point(12, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 23);
            this.button4.Text = "4";
            this.button4.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 12F);
            this.button4.Click += new System.EventHandler(this.numberButton_Click);

            // button5
            this.button5.Location = new System.Drawing.Point(68, 119);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 23);
            this.button5.Text = "5";
            this.button5.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 12F);
            this.button5.Click += new System.EventHandler(this.numberButton_Click);

            // button6
            this.button6.Location = new System.Drawing.Point(124, 119);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 23);
            this.button6.Text = "6";
            this.button6.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 12F);
            this.button6.Click += new System.EventHandler(this.numberButton_Click);

            // button7
            this.button7.Location = new System.Drawing.Point(12, 148);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 23);
            this.button7.Text = "7";
            this.button7.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial", 12F);
            this.button7.Click += new System.EventHandler(this.numberButton_Click);

            // button8
            this.button8.Location = new System.Drawing.Point(68, 148);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 23);
            this.button8.Text = "8";
            this.button8.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial", 12F);
            this.button8.Click += new System.EventHandler(this.numberButton_Click);

            // button9
            this.button9.Location = new System.Drawing.Point(124, 148);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 23);
            this.button9.Text = "9";
            this.button9.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Arial", 12F);
            this.button9.Click += new System.EventHandler(this.numberButton_Click);

            // openParenButton
            this.openParenButton.Location = new System.Drawing.Point(180, 206);
            this.openParenButton.Name = "openParenButton";
            this.openParenButton.Size = new System.Drawing.Size(50, 23);
            this.openParenButton.Text = "(";
            this.openParenButton.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.openParenButton.ForeColor = System.Drawing.Color.White;
            this.openParenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openParenButton.Font = new System.Drawing.Font("Arial", 12F);
            this.openParenButton.Click += new System.EventHandler(this.openParenButton_Click);

            // closeParenButton
            this.closeParenButton.Location = new System.Drawing.Point(236, 206);
            this.closeParenButton.Name = "closeParenButton";
            this.closeParenButton.Size = new System.Drawing.Size(50, 23);
            this.closeParenButton.Text = ")";
            this.closeParenButton.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.closeParenButton.ForeColor = System.Drawing.Color.White;
            this.closeParenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeParenButton.Font = new System.Drawing.Font("Arial", 12F);
            this.closeParenButton.Click += new System.EventHandler(this.closeParenButton_Click);

            // voiceButton
            this.voiceButton.Location = new System.Drawing.Point(12, 206);
            this.voiceButton.Name = "voiceButton";
            this.voiceButton.Size = new System.Drawing.Size(50, 23);
            this.voiceButton.Text = "Voice";
            this.voiceButton.BackColor = System.Drawing.Color.Gray; // Color inicial gris
            this.voiceButton.ForeColor = System.Drawing.Color.White;
            this.voiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voiceButton.Font = new System.Drawing.Font("Arial", 12F);
            this.voiceButton.Click += new System.EventHandler(this.voiceButton_Click);

            // cameraButton
            this.cameraButton.Location = new System.Drawing.Point(12, 240);
            this.cameraButton.Name = "cameraButton";
            this.cameraButton.Size = new System.Drawing.Size(100, 30);
            this.cameraButton.Text = "Abrir Cámara";
            this.cameraButton.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.cameraButton.ForeColor = System.Drawing.Color.White;
            this.cameraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cameraButton.Font = new System.Drawing.Font("Arial", 10F);
            this.cameraButton.Click += new System.EventHandler(this.cameraButton_Click);
            this.Controls.Add(this.cameraButton);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 230);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(0, 35, 51);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.sqrtButton);
            this.Controls.Add(this.sinButton);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.openParenButton);
            this.Controls.Add(this.closeParenButton);
            this.Controls.Add(this.voiceButton);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}