using System;
using System.Windows.Forms;

    public class SimpleInputDialog : Form {
		    private string strMessage;

			public string inputMessage {
				get { return strMessage; }
				set	{
					strMessage = value;
					textBox1.Text = value;
				}
			}

        public SimpleInputDialog(string headerText) {
            InitializeComponent();
            label1.Text = headerText;
        }

        private void okButton_Click(object sender, EventArgs e) {
            inputMessage = textBox1.Text;
            this.Close();
        }

        // The textBox1_KeyPress method uses the KeyChar property to check 
        // whether the ENTER key is pressed. 
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Return) {
                okButton_Click(sender, e);
            }
        }
		
		/// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = ".";
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.okButton.Location = new System.Drawing.Point(114, 86);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // SimpleInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(315, 126);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimpleInputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Dialog Box";
            this.Load += new System.EventHandler(this.SimpleInputDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox textBox1;

    private void SimpleInputDialog_Load(object sender, EventArgs e)
    {

    }
}

public class InputDialogBox { 

        /// <summary>
        /// Shows a question-message dialog requesting input from the user.
        /// </summary>
        /// <param name="text">The text display in the message box</param>
        /// <returns>Return String that user enter. If no such input given, string with zero length will return</returns>
        public static string Show(String text) {
            SimpleInputDialog simpleDialog = new SimpleInputDialog(text);
            simpleDialog.inputMessage = "";
            simpleDialog.ShowDialog();
            return simpleDialog.inputMessage;
        }

        /// <summary>
        /// Shows a question-message dialog requesting input from the user.
        /// </summary>
        /// <param name="text">The text display in the message box</param>
        /// <param name="inputText">the value used to initialize the input text field</param>
        /// <returns>Return String that user enter. If no such input given, string with zero length will return</returns>
        public static string Show(String text, String inputText) {
            SimpleInputDialog simpleDialog = new SimpleInputDialog(text);
            simpleDialog.inputMessage = inputText;
            simpleDialog.ShowDialog();
            return simpleDialog.inputMessage;
        }

        /// <summary>
        /// Shows a question-message dialog requesting input from the user.
        /// </summary>
        /// <param name="text">The text display in the message box</param>
        /// <param name="inputText">the value used to initialize the input text field</param>
        /// <param name="caption">The text to display in the title bar of the message box.</param>
        /// <returns>Return String that user enter. If no such input given, string with zero length will return</returns>
        public static string Show(String text, String inputText, String caption) {
            SimpleInputDialog simpleDialog = new SimpleInputDialog(text);
            simpleDialog.Text = caption;
            simpleDialog.inputMessage = inputText;
            simpleDialog.ShowDialog();
            return simpleDialog.inputMessage;
        }
    }

// Author  : Abdullah Al Mamun Oronno
// Homepage: www.the1.co.nr
