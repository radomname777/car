namespace car
{
    public partial class Form1 : Form
    {
        const int num = 3;
        
        List<Car> cars = new List<Car>(num);
        void Start()
        {
            Properties.Resources a;
            cars.Add(new Car("X5", "Bmw", "2019", "5.5",Properties.Resources.Bmwx5));
            cars.Add(new Car("Camaro", "Chevrolet", "2022", "3.5", Properties.Resources.camaro));
            cars.Add(new Car("Mustang", "Ford", "2015", "5.5", Properties.Resources.ford));
            Carmethod(cars[0]);
            timer1.Tick += Timer_Tick1;
            timer1.Interval = 5000;
            timer1.Start();
        }
        int num2 = 0;
        private void Timer_Tick1(object? sender, EventArgs e)
        {

            if (num2 == num) num2 = 0;
            Carmethod(cars[num2]);
            num2++;
        }
        private void Carmethod(Car car)
        {
            foreach (var item in panel1.Controls)
                if (item is Guna.UI2.WinForms.Guna2CustomRadioButton btn && btn.Tag == num2.ToString())
                    btn.Checked = true;
            Model.Text = car.Model; Vendor.Text = car.Vendor;
            Year.Text = car.Year; Engine.Text = car.Engine;
            pictureBox1.Image = car.images;
        }
        public Form1()
        {
            InitializeComponent();
            var pos = this.PointToScreen(panel1.Location);
            pos = pictureBox1.PointToClient(pos);
            panel1.Parent = pictureBox1;
            panel1.Location = pos;
            panel1.BackColor = Color.Transparent;
           

            Start();
        }
        private void guna2CustomRadioButton1_Click(object sender, EventArgs e)
        {
            if (sender is Guna.UI2.WinForms.Guna2CustomRadioButton btn)
            {

                int index = Convert.ToInt32(btn.Tag.ToString());
                num2 = index;
                Carmethod(cars[index]);
                btn.Checked = true;
            }
        }
    }
}