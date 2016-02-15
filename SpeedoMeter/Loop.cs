using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Threading;

namespace SpeedoMeter {
    class Loop {
        private DispatcherTimer timer = new DispatcherTimer(DispatcherPriority.Background);
        private RotateTransform RT = new RotateTransform();
        private Random rand = new Random();
        private Stopwatch watch = new Stopwatch();

        private bool accelerating = false, braking = false;

        private int count = 0; //currentPassedSeconds
        private double count2 = 0; //ccurentPassedMilliSeconds

        private double speedInKM = 0;
        private const double MAXSPEED = 351;
        private int maxAngle = 260;
        private int currentRelativeAngle;


        private double acceleration, deceleration = 1.5;
        private double brakeForce = 17.5;

        private void play(Object O, EventArgs e) {
            textBox.Content = count2.ToString("0.0");

            speedLabel.Content = speed.ToString("000");

            //acceleration = (0.025 + (maxSpeed - speed) * (maxAcceleration / maxSpeed)) * 3.6;

            acceleration = (2500 / (speed + 116.84255) - 5.21666) * 3.6;

            if (accelerating) {
                speed += acceleration / 31;
            } else {
                speed -= (deceleration + (speed / maxSpeed * 7.5)) / 31;
            }


            if (braking) {
                brake();
            }

            if (speed <= 80) {
                currentRelAngle = (int)Math.Ceiling(speed / 0.72);
            } else if (speed > 80 && speed <= 200) {
                currentRelAngle = 48 + (int)Math.Ceiling(speed / 1.26);
            } else if (speed > 200) {
                currentRelAngle = 127 + (int)Math.Ceiling(speed / 2.50);
            }

            if (speed > maxSpeed) {
                speed -= rand.Next(0, 2);
            } else if (speed < 0) {
                speed = 0;
            }

            if (currentRelAngle > maxAngle) {
                currentRelAngle = maxAngle;
            }

            if (speed > 160 && !braking) {
                currentRelAngle += rand.Next(-1, 1);
            }

            transform.Angle = currentRelAngle;
            counting();
        }

        public double Speed { get; set; }
    }
}
