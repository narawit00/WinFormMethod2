namespace WinFormMethod2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            //double r = 0;
            //if (double.TryParse(btnCircleArea.Text, out r))
            //{
            //    MessageBox.Show("��ͤ������١��ͧ", "�Դ��ͼԴ��Ҵ");
            //    return;
            //}

            //lb
            CircleArea(txtRadius, lblResult);

        }
        void CircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            lblResult.Text = area.ToString();
        }

        void CircleArea(TextBox txt)

        {
            double r = 0;
            if (!double.TryParse(txt.Text, out r))
            {
                MessageBox.Show("���������١��ͧ", "�Դ��ͼԴ��Ҵ");
                return;
            }
            double area = Math.PI * r * r;
            lblResult.Text = area.ToString();
        }

        void CircleArea(TextBox txt, Label lbl)

        {
            double r = 0;
            if (!double.TryParse(txt.Text, out r))
            {
                MessageBox.Show("���������١��ͧ", "�Դ��ͼԴ��Ҵ");
                return;
            }
            double area = Math.PI * r * r;
            lblResult.Text = area.ToString();
        }
        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnCircumference_Click(object sender, EventArgs e)
        {
            double r = 0;
            if (double.TryParse(txtRadius.Text, out r))
            {
                MessageBox.Show("���������١��ͧ", "�Դ��ͼԴ��Ҵ");
            }
            lblResult.Text = Cirucumference(r).ToString(); ///���¡�� fn 㹻���¤


        }
        double Cirucumference(double radius) ///�觤����һ����ż����ҧ����
        {
            return 2 * Math.PI * radius;

        }
        string triangle(string letter = "*", int size = 5)
        {
            string result = "";
            for (int i = 1; i < size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    result += letter;
                }
                result += Environment.NewLine;



            }
            return result;

        }

        private void btnTriangle01_Click(object sender, EventArgs e)
        {
            //txtOutput.Text = triangle();
            //txtOutput.Text =triangle(txtLetter.Text);
            txtOutput.Text = triangle(txtLetter.Text, 9);
        }

        void ImproveName(ref string name)
        {

            name = name.Trim();

            if (name.Length < 2)
            {
                MessageBox.Show("�ô��͡�������١��ͧ", "������żԴ��Ҵ");
                return;


            }



        }

        private void btnRefParameter_Click(object sender, EventArgs e)
        {
            string FName = txtinput.Text;
            //  ImproveName(ref FName);
            txtinput.Text = ImproveName2(FName);

        }


        string ImproveName2(string name)
        {
            name = name.Trim();

            if (name.Length < 2)
            {
                MessageBox.Show("�ô��͡�������١��ͧ", "�����żԴ��Ҵ");
            }
            return name;



        }
        Boolean improveName3(string name, out string x)
        {
            x = name.Trim();
            if (x.Length < 2)
            {
                x = "";
                return false;
            }
            return true;
        }

        private void btnOutputParameter_Click(object sender, EventArgs e)
        {
            string Fname = "";
            if (improveName3(txtinput.Text, out Fname))
            {
                txtinput.Text = Fname;
            }
            else
            {
                MessageBox.Show("�����żԴ��Ҵ", "�ô��͡���������١��ͧ");
            }
        }

        private void btnArrayParameter_Click(object sender, EventArgs e)
        {
            double[] data = new double[] { 1.5, 2.0, 3.25, 0.15 };
            double summary = sum(data);
            string result = string.Join("/", data);
            result += Environment.NewLine;
            result += summary.ToString();
            MessageBox.Show(result, "������ͧ���� Array");
        }

        double sum(double[] dataArray)
        {
            double sum = 0;
            foreach (double d in dataArray)
            {
                sum += d;
            }
            return sum;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

