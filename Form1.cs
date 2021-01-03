﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Samochod;

namespace windowCar 
{
    public partial class Form1 : Form
    {
        private Car car;
        public Form1() {
            InitializeComponent();
            car = new Car("BMW E43");
            setLabels();
            timer1.Start();
        }

        public void setLabels() { 
            nameLbl.Text = String.Format(Utils.CAR_NAME_VALUE, car.name.ToString());
            velocityLbl.Text = String.Format(Utils.CAR_VELOCITY_VALUE, car.velocity.ToString("n1"));
            petrolLbl.Text = String.Format(Utils.CAR_PETROL_VALUE, car.petrolLevel.ToString("n2"));
            carStatusLbl.Text = String.Format(Utils.CAR_STATUS_VALUE, car.carStatus.ToString());
            engineDMGLbl.Text = String.Format(Utils.CAR_DMG_VALUE, car.engineDMG.ToString());
            drivingDistanceLbl.Text = String.Format(Utils.CAR_DRIVING_DISTANCE_VALUE, car.drivingDistance.ToString());
        }

        private void engineOnBtn_Click(object sender, EventArgs e)
        {
            changeCarStatus(Utils.CarStatus.engineOn);
        }

        private void Form1_Load(object sender, EventArgs e){}

        private void engineOffBtn_Click(object sender, EventArgs e)
        {
            changeCarStatus(Utils.CarStatus.engineOff);
        }

        private void carStopBtn_Click(object sender, EventArgs e)
        {

            changeCarStatus(Utils.CarStatus.carStop);
        }

        private void accelerationBtn_Click(object sender, EventArgs e)
        {
            changeCarStatus(Utils.CarStatus.acceleration);
        }

        private void releasingBtn_Click(object sender, EventArgs e)
        {
            changeCarStatus(Utils.CarStatus.releasing);
        }

        private void checkEngineIsOn() {
            if (car.carStatus.Equals(Utils.CarStatus.engineOff)) {
                engineOnBtn.Enabled = true;
                accelerationBtn.Enabled = false;
                constSpeedBtn.Enabled = false;
                releasingBtn.Enabled = false;
                carStopBtn.Enabled = false;
                engineOffBtn.Enabled = false;
            } else {
                engineOnBtn.Enabled = false;
                accelerationBtn.Enabled = true;
                constSpeedBtn.Enabled = true;
                releasingBtn.Enabled = true;
                carStopBtn.Enabled = true;
                engineOffBtn.Enabled = true;
            }
        }

        private void changeCarStatus(Enum status)
        {
            car.carStatus = status;
        }

        private void constSpeedBtn_Click(object sender, EventArgs e)
        {
            changeCarStatus(Utils.CarStatus.constSpeed);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            checkEngineIsOn();
            changeConditions();
            setLabels();
        }

        private void changeConditions() {
            switch (car.getStatus()) {
                case Utils.CarStatus.engineOff:
                    break;
                case Utils.CarStatus.engineOn:
                    car.fuelConsumption(1);
                    break;
                case Utils.CarStatus.carStop:
                    car.fuelConsumption(1);
                    break;
                case Utils.CarStatus.acceleration:
                    car.fuelConsumption(40);
                    break;
                case Utils.CarStatus.releasing:
                    car.fuelConsumption(1);
                    break;
                case Utils.CarStatus.constSpeed:
                    car.fuelConsumption(1);
                    break;
            }
        }
    }
}
