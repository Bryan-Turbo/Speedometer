using System;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Input;
using System.Windows.Media;

namespace SpeedoMeter {
    /**
    *CREATED BY BRYAN KROESBEEK
    *EDITS MAY BE MADE, BUT ONLY IF THE ORIGINAL CREATOR IS PROPERLY CREDITED
    */
    public partial class MainWindow : Window {
        private DispatcherTimer timer = new DispatcherTimer(DispatcherPriority.Background);
        private RotateTransform RT = new RotateTransform();
        private Random rand = new Random();

        private bool accelerating = false, braking = false;

        private int quarterSeconds = 0; 
        private double seconds = 0;

        private double speedInKM = 0;
        private const double MAXSPEED = 351;
        private const int MAXANGLE = 260;
        private int currentRelativeAngle;


        private double acceleration = 1.5;
        private const double DECELERATION = 1.5;
        private const double BRAKEFORCE = 17.5; // in m/s²

        private const double MPSTOKMH = 3.6; // meters per seconds to kilometers per hour

        public MainWindow() { 
            InitializeComponent();
            Initialize();
        }

        private void Initialize() {
            timer.Interval = new TimeSpan(0, 0, 0, 0, 16);
            timer.Tick += play;
            timer.Start();
        }

        private void accelerateButton_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            accelerating = true;
        }
        private void accelerateButton_PreviewMouseUp(object sender, MouseButtonEventArgs e) {
            accelerating = false;
        }
        private void brakeButton_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            braking = true;
        }
        private void brakeButton_PreviewMouseUp(object sender, MouseButtonEventArgs e) {
            braking = false;
        }

        private void play(Object O, EventArgs e) {

            textBox.Content = seconds.ToString("0.0");
            speedLabel.Content = speedInKM.ToString("000");

            accelerate();

            if (braking) {
                brake();
            }

            keepSpeedBelowMaxLevel();

            changeAngle();

            countSeconds();
        }

        private void keepSpeedBelowMaxLevel() {
            //reduce the current speed with a value of 1 or 0
            if (speedInKM > MAXSPEED) 
                speedInKM -= rand.Next(0, 2);
            else if (speedInKM < 0) 
                speedInKM = 0;
            
        }

        private void changeAngle() {
            //change the scale with the corresponding speed
            if (speedInKM <= 80)
                currentRelativeAngle = (int)Math.Ceiling(speedInKM / 0.72);
            else if (speedInKM > 80 && speedInKM <= 200)
                currentRelativeAngle = 48 + (int)Math.Ceiling(speedInKM / 1.26);
            else if (speedInKM > 200)
                currentRelativeAngle = 127 + (int)Math.Ceiling(speedInKM / 2.50);
           

            if (currentRelativeAngle > MAXANGLE)
                currentRelativeAngle = MAXANGLE;

            //make the needle wiggle a little bit
            if (speedInKM > 160 && !braking)
                currentRelativeAngle += rand.Next(-1, 1);

            transform.Angle = currentRelativeAngle;
        }

        private void accelerate() {
            //calculation made in geogebra
            acceleration = (2500 / (speedInKM + 116.84255) - 5.21666) * MPSTOKMH;
            //

            if (accelerating)
                speedInKM += acceleration / 31;
            else
                //when going faster the speed will decrease faster
                speedInKM -= (DECELERATION + (speedInKM / MAXSPEED * 7.5)) / 31;
        }

        private void brake() {
            speedInKM -= BRAKEFORCE * MPSTOKMH / 31;
            if (speedInKM < 0) {
                speedInKM = 0;
            }
        }

        private void countSeconds() {
            quarterSeconds++;
            if (quarterSeconds >= 4) {
                seconds += 0.1;
                quarterSeconds = 0;
            }
        }
    }
}
