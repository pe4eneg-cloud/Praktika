using System;
class TemperatureSensor
{
    double temp;
    public event Action<double> TemperatureChanged; // событие

    public void SetTemperature(double newTemp)
    {
        temp = newTemp;
        Console.WriteLine($"Датчик: температура {newTemp}°C");
        TemperatureChanged?.Invoke(newTemp); // вызываем событие
    }
}
class Thermostat
{
    public void OnTempChanged(double t)
    {
        if (t < 20) Console.WriteLine("Термостат: холодно — включаем отопление!");
        else Console.WriteLine("Термостат: тепло — выключаем отопление!");
    }
}
class P
{
    static void Main()
    {
        try
        {
            TemperatureSensor sensor = new TemperatureSensor();
            Thermostat thermostat = new Thermostat();

            sensor.TemperatureChanged += thermostat.OnTempChanged; // подписка  
            sensor.SetTemperature(30);
            sensor.SetTemperature(22);
            sensor.SetTemperature(10);
        }
        catch
        {
            Console.WriteLine("Ошибка!");
        }
    }
}