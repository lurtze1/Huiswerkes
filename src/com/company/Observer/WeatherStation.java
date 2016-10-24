package com.company.Observer;

/**
 * Created by lurtze1 on 07-Sep-16.
 */
public class WeatherStation {

    public static void main(String[] args) {
        WeatherData weatherData = new WeatherData();

        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
        weatherData.setMeasurements(10, 10, 30.4f);
        weatherData.setMeasurements(50, 20, 11.55f);
    }
}
