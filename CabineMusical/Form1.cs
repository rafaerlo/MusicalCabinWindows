using System.IO.Ports;

namespace CabineMusical
{
    public partial class Form1 : Form
    {
        SerialPort serialPort1 = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);

        public Form1()
        {
            InitializeComponent();
            timerCOM.Enabled = true;
            updateCOMsList();
        }

        void MyDataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            int count = serialPort1.BytesToRead;
            byte[] ByteArray = new byte[count];
            serialPort1.Read(ByteArray, 0, count);
        }

        private void updateCOMsList()
        {
            int i;
            bool hasNewCOMPortEntering;    //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            hasNewCOMPortEntering = false;

            //se a quantidade de portas mudou
            if (cbCOM.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (cbCOM.Items[i++].Equals(s) == false)
                    {
                        hasNewCOMPortEntering = true;
                    }
                }
            }
            else
            {
                hasNewCOMPortEntering = true;
            }

            if (hasNewCOMPortEntering == false)
            {
                return;
            }
            cbCOM.Items.Clear();

            foreach (string s in SerialPort.GetPortNames())
            {
                cbCOM.Items.Add(s);
            }

            cbCOM.SelectedIndex = 0;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    string portName = cbCOM.Items[cbCOM.SelectedIndex].ToString();
                    serialPort1 = new SerialPort(portName, 9600, Parity.None, 8, StopBits.One);
                    serialPort1.Open();
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(MyDataReceivedHandler);
                    UpdateCOMPresentedValue();
                }
                catch
                {
                    return;
                }
                if (serialPort1.IsOpen)
                {
                    btnConectar.Text = "Desconectar";
                    cbCOM.Enabled = false;
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    cbCOM.Enabled = true;
                    btnConectar.Text = "Conectar";
                }
                catch
                {
                    return;
                }
            }
        }

        private void UpdateCOMPresentedValue()
        {
            if (serialPort1.IsOpen == true)
            {
                string portContent = serialPort1.ReadByte().ToString();
                txtCOMResultArduino.Text = serialPort1.ReadByte().ToString();
                if (Int32.Parse(portContent) > 100)
                {
                    txtCOMResultArduino.ForeColor = Color.Red;
                }
                else
                {
                    txtCOMResultArduino.ForeColor = Color.Black;
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
            }
        }

        private void timerCOM_Tick(object sender, EventArgs e)
        {
            updateCOMsList();
            UpdateCOMPresentedValue();
        }
    }
}
