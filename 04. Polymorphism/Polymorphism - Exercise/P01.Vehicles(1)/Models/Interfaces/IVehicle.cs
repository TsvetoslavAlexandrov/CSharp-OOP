﻿namespace P01.Vehicles_1_.Models.Interfaces
{
    public interface IVehicle
    {

        double FuelQuantity { get; }
        double FuelConsumption { get; }

        string Drive(double distance);

        void Refuel(double liters);

    }
}
