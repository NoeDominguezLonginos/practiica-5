namespace practiica_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Radio, Altura;
            double Basearea, Lateralarea, Totalarea;
            double Volume;

            Radio = double.Parse(textBox1.Text);
            Altura = double.Parse(textBox2.Text);

            Basearea = Radio * Radio * Math.PI;
            Lateralarea = 2 * Math.PI * Radio * Altura;
            Totalarea = 2 * Math.PI * Radio * (Altura + Radio);
            Volume = Math.PI * Radio * Radio * Altura;

            textBox3.Text = Basearea.ToString("0.##");
            textBox4.Text = Lateralarea.ToString("0.##");
            textBox5.Text = Totalarea.ToString("0.##");
            textBox6.Text = Volume.ToString("0.##");
        }
    }
}