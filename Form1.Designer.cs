namespace CabineMusical
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
            components = new System.ComponentModel.Container();
            btnConectar = new Button();
            cbCOM = new ComboBox();
            txtCOMResultArduino = new TextBox();
            timerCOM = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(51, 62);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 23);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConnect_Click;
            // 
            // cbCOM
            // 
            cbCOM.FormattingEnabled = true;
            cbCOM.Location = new Point(158, 62);
            cbCOM.Name = "cbCOM";
            cbCOM.Size = new Size(121, 23);
            cbCOM.TabIndex = 1;
            // 
            // txtCOMResultArduino
            // 
            txtCOMResultArduino.Font = new Font("Segoe UI", 60F, FontStyle.Bold);
            txtCOMResultArduino.Location = new Point(51, 115);
            txtCOMResultArduino.Multiline = true;
            txtCOMResultArduino.Name = "txtCOMResultArduino";
            txtCOMResultArduino.Size = new Size(696, 296);
            txtCOMResultArduino.TabIndex = 2;
            // 
            // timerCOM
            // 
            timerCOM.Interval = 1000;
            timerCOM.Tick += timerCOM_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCOMResultArduino);
            Controls.Add(cbCOM);
            Controls.Add(btnConectar);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private ComboBox cbCOM;
        private TextBox txtCOMResultArduino;
        private System.Windows.Forms.Timer timerCOM;
    }
}
