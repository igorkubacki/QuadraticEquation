namespace QuadraticEquation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void txtInputA_Enter(object sender, EventArgs e)
        {
            if (textInputA.Text == "a")
            {
                textInputA.Text = "";
                textInputA.ForeColor = Color.Black;
            }
        }

        private void textInputB_Enter(object sender, EventArgs e)
        {
            if (textInputB.Text == "b")
            {
                textInputB.Text = "";
                textInputB.ForeColor = Color.Black;
            }
        }

        private void textInputC_Enter(object sender, EventArgs e)
        {
            if (textInputC.Text == "c")
            {
                textInputC.Text = "";
                textInputC.ForeColor = Color.Black;
            }
        }

        private void txtInputA_Leave(object sender, EventArgs e)
        {
            if (textInputA.Text == "" || !float.TryParse(textInputA.Text, out _))
            {
                textInputA.Text = "a";
                textInputA.ForeColor = SystemColors.ButtonShadow;
                notifyIcon1.ShowBalloonTip(4, "Yes", "Wrong value entered!",ToolTipIcon.Info);
            }
        }

        private void textInputB_Leave(object sender, EventArgs e)
        {
            if (textInputB.Text == "" || !float.TryParse(textInputB.Text, out _))
            {
                textInputB.Text = "b";
                textInputB.ForeColor = SystemColors.ButtonShadow;
            }
        }

        private void textInputC_Leave(object sender, EventArgs e)
        {
            if (textInputC.Text == "" || !float.TryParse(textInputC.Text, out _))
            {
                textInputC.Text = "c";
                textInputC.ForeColor = SystemColors.ButtonShadow;
            }
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            if (textInputA.Text != "a" && textInputB.Text != "b" && textInputC.Text != "c") Solve();
        }

        private void Solve()
        {
            float a = float.Parse(textInputA.Text);
            float b = float.Parse(textInputB.Text);
            float c = float.Parse(textInputC.Text);
            textBoxDelta.Text = ((b * b) - (4 * a * c)).ToString();
            double delta = Math.Sqrt((b * b) - (4 * a * c));
            if (delta > 0)
            {
                textBoxX1.Text = ((-b - delta)/(2 * a)).ToString();
                textBoxX2.Text = ((-b + delta)/(2 * a)).ToString();
            }
            else if (delta == 0)
            {
                textBoxX1.Text = (-b / (2 * a)).ToString();
                textBoxX2.Text = (-b / (2 * a)).ToString();
            }
            else
            {
                textBoxX1.Text = "N/A";
                textBoxX2.Text = "N/A";
            }
        }
    }
}