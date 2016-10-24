package com.company.Observer;

import java.util.Observable;

/**
 * Created by lurtze1 on 07-Sep-16.
 */
public class WeatherData extends Observable {

    public float getTemperature() {
        return temperature;
    }

    public float getHumidity() {
        return humidity;
    }

    public float getPressure() {
        return pressure;
    }

    private float temperature;
    private float humidity;
    private float pressure;

    public WeatherData() {
    }

    public void measurementsChanged() {
        setChanged();
        System.out.println(countObservers());
        notifyObservers(this);
    }

    public void setMeasurements(float temperature, float humidity, float pressure) {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        measurementsChanged();
    }
}
