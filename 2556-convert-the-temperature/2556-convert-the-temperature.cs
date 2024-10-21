public class Solution {
    public double[] ConvertTemperature(double celsius) {

        double Kelvin = celsius + 273.15;
        double Fahrenheit = celsius * 1.80 + 32;

        return [Kelvin, Fahrenheit];
    }
}