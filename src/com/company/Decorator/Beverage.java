package com.company.Decorator;

/**
 * Created by lurtze1 on 13-Sep-16.
 */
public abstract class Beverage {
    protected String description = "Unknown Beverage";

    public String getDescription() {
        return description;
    }

    public abstract double cost();

    public enum Size {Tall, Grande, Venti}
    Size size = Size.Tall;

    public void setSize(Size size){
        this.size = size;
    }

    public Size getSize(){
        return this.size;
    }
}
