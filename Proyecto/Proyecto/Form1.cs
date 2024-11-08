namespace Proyecto
{
    public partial class Form1 : Form
    {
         private DateTime targetDate;
        public Form1()
        {
            InitializeComponent();
            TopMost = true;
            targetDate = new DateTime(DateTime.Now.Year, 12, 1);
            if (DateTime.Now > targetDate)
            {
                targetDate = targetDate.AddYears(1);
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeRemaining = targetDate - DateTime.Now;
            label1.Text = $"{timeRemaining.Days}";
            label9.Text = $"{timeRemaining.Hours}";
            label10.Text = $"{timeRemaining.Minutes}";
            label11.Text = $"{timeRemaining.Seconds}";
        }
    }
}
