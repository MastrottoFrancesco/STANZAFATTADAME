namespace CStanzaFattoDaMe
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
            panel1 = new Panel();
            labeltitolo = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            MESSAGGI = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labeltitolo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // labeltitolo
            // 
            labeltitolo.BackColor = SystemColors.ActiveCaption;
            labeltitolo.Dock = DockStyle.Fill;
            labeltitolo.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labeltitolo.Location = new Point(0, 0);
            labeltitolo.Name = "labeltitolo";
            labeltitolo.Size = new Size(800, 100);
            labeltitolo.TabIndex = 0;
            labeltitolo.Text = "CONTROLLO PERSONE STANZA";
            labeltitolo.TextAlign = ContentAlignment.MiddleCenter;
            labeltitolo.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(596, 146);
            button1.Name = "button1";
            button1.Size = new Size(98, 94);
            button1.TabIndex = 1;
            button1.Text = "CONTROLLA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(111, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(30, 34);
            label1.Name = "label1";
            label1.Size = new Size(276, 17);
            label1.TabIndex = 3;
            label1.Text = "Inserisci quante persone ci sono nella stanza:";
            // 
            // panel2
            // 
            panel2.Controls.Add(MESSAGGI);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 350);
            panel2.TabIndex = 4;
            // 
            // MESSAGGI
            // 
            MESSAGGI.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MESSAGGI.FormattingEnabled = true;
            MESSAGGI.ItemHeight = 21;
            MESSAGGI.Location = new Point(131, 124);
            MESSAGGI.Name = "MESSAGGI";
            MESSAGGI.Size = new Size(367, 172);
            MESSAGGI.TabIndex = 4;
            MESSAGGI.SelectedIndexChanged += MESSAGGI_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labeltitolo;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Panel panel2;
        private ListBox MESSAGGI;
    }
}