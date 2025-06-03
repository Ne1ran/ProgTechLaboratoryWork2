namespace ProgrammingTechnologiesLaboratoryWork2
{
    public partial class MainForm : Form
    {
        private double _maxX, _minX, _maxY, _minY, _stepX;
        private int _cycleSize, _i1;
        private double[] _arrayOfArgumentsX = null!, _arrayOfValuesY = null!;
        private DateTime _startTime, _finishTime;
        private TimeSpan _durationOfProcess;

        public MainForm()
        {
            InitializeComponent();
            _startTime = DateTime.Now;
            _finishTime = DateTime.Now;
        }

        private double Function13(double x)
        {
            double numerator = Math.Exp(x) * (Math.Sin(x) - Math.Pow(Math.Cos(x), 2));
            double denominator = Math.Pow(Math.Sin(x), 2) + Math.Cos(x);
            return numerator / denominator;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try {
                _minX = double.Parse(textBoxMinX.Text);
                _maxX = double.Parse(textBoxMaxX.Text);
                _stepX = double.Parse(textBoxStepX.Text);

                _cycleSize = (int) ((_maxX - _minX) / _stepX) + 1;

                _arrayOfArgumentsX = new double[_cycleSize];
                _arrayOfValuesY = new double[_cycleSize];

                progressBar.Value = 0;
                progressBar.Maximum = _cycleSize;

                _startTime = DateTime.Now;

                for (_i1 = 0; _i1 < _cycleSize; _i1++) {
                    _arrayOfArgumentsX[_i1] = _minX + _i1 * _stepX;
                    _arrayOfValuesY[_i1] = Function13(_arrayOfArgumentsX[_i1]);

                    if (_i1 == 0 || _arrayOfValuesY[_i1] < _minY) {
                        _minY = _arrayOfValuesY[_i1];
                    }
                    if (_i1 == 0 || _arrayOfValuesY[_i1] > _maxY) {
                        _maxY = _arrayOfValuesY[_i1];
                    }

                    progressBar.Value = _i1 + 1;
                    Application.DoEvents();
                }

                _finishTime = DateTime.Now;
                _durationOfProcess = _finishTime - _startTime;

                textBoxMinY.Text = _minY.ToString("F2");
                textBoxMaxY.Text = _maxY.ToString("F2");
                labelDuration.Text = $"Duration: {_durationOfProcess.TotalSeconds:F3} seconds";
            } catch (Exception ex) {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}