namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Label label1;
        private ProgressBar progressBar1;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 455);
            label1.Name = "label1";
            label1.Size = new Size(182, 37);
            label1.TabIndex = 0;
            label1.Text = "carregamento";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(-1, 509);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1253, 24);
            progressBar1.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            BackgroundImage = Properties.Resources.bcad8eae58f5ecff3ef037795bf90c262ae7e230v2_hq;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1253, 545);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.IContainer components;

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 10;
            }
            else
            {
                timer1.Start();
            }
        }
    }
}
