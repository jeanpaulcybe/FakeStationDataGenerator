using System.Diagnostics;
using System.Text.Json;


Sensor<bool>[] switches = new Sensor<bool>[10];
for (int i = 0; i < switches.Length; i++) switches[i] = Sensor<int>.newSwitch ((new Random ()).Next (2) == 0);
Console.WriteLine ($"\t>> {string.Join ("\n\t>> ", switches.Select (s => s.ToJson ()))}");
switches[0].value = !switches[0].value;
Console.WriteLine ($"\t>> {string.Join ("\n\t>> ", switches.Select (s => s.ToJson ()))}");

var power1 = Sensor<int>.newPower ();
Console.WriteLine ("\t>> " + power1.ToJson ());
power1.value = 22.48;
Console.WriteLine ("\t>> " + power1.ToJson ());

var laser1 = Sensor<int>.newType ("Laser", "cm", 0);
Console.WriteLine ("\t>> " + laser1.ToJson ());
laser1.value = 15;
Console.WriteLine ("\t>> " + laser1.ToJson ());

// string fileName = "Sensors.json";
// string jsonString = JsonSerializer.Serialize (temp1);
// File.WriteAllText (fileName, jsonString);

// Console.WriteLine (File.ReadAllText (fileName));