namespace calculadora
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            label1 = new Label();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 367);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 462);
            label2.Name = "label2";
            label2.Size = new Size(279, 37);
            label2.TabIndex = 1;
            label2.Text = "Tela de carregamento ";
            // 
            // progressBar1
            
            // 
            // Calculadora
            
        }

        #endregion

        private Label label1;
        private Label label2;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}
