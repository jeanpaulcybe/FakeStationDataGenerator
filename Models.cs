using System;
using System.Text.Json;

public class Sensor<T> {
    // CAMPI
    static int _counter = 0;
    // PROPRIETA'
    public static string newId => (++_counter).ToString ().PadLeft (5, '0');
    public string? ObjectType { get; set; }
    public string? ObjectId { get; set; }
    public string? ValueType { get; set; }
    public T? value { get; set; }
    // COSTRUTTORI
    private Sensor (string tipo, string id, string tipoV, T valore) {
        this.ObjectType = tipo;
        ObjectId = id;
        ValueType = tipoV;
        value = valore;
    }
    // GENERATORI
    public static Sensor<DateTime> newClock (DateTime? value = null) => new Sensor<DateTime> ("Temp", $"{newId}", "Celsius", (value == null) ? DateTime.Now : value.GetValueOrDefault ());
    public static Sensor<double> newTemperature (double value = 18.0) => new Sensor<double> ("Temp", $"{newId}", "Celsius", value);
    public static Sensor<double> newPower (double value = 24.0) => new Sensor<double> ("Power", $"{newId}", "Volt", value);
    public static Sensor<double> newHumdity (double value = 10.0) => new Sensor<double> ("Humidity", $"{newId}", "Percent", value);
    public static Sensor<double> newPressure (double value = 1.0) => new Sensor<double> ("Pressure", $"{newId}", "bar", value);
    public static Sensor<double> newWaterLevel (double value = 50) => new Sensor<double> ("WaterLevel", $"{newId}", "cm", value);
    public static Sensor<bool> newSwitch (bool value = true) => new Sensor<bool> ("Turned", $"{newId}", "ON/OFF", value);
    public static Sensor<T> newType (string newType, string unity, T value) => new Sensor<T> (newType, $"{newId}", unity, value);
    // conversione
    public override string ToString () => $"{ObjectType} [{ObjectId}], {value} {ValueType}";
    public string ToJson () => JsonSerializer.Serialize (this);

}