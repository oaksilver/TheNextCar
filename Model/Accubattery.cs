﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NextCar.Model
{
    class Accubattery
    {
        private int voltage;
        private Boolean stateOn = false;
        public Accubattery(int voltage)
        {
            this.voltage = voltage;
        }
        public void turnOn()
        {
            this.stateOn = true;
        }
        public void turnOff()
        {
            this.stateOn = false;
        }
        public Boolean isOn()
        {
            return this.stateOn;
        }
    }
}

