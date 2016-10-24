package com.company.Decorator.Beverages;

import com.company.Decorator.Beverage;

/**
 * Created by lurtze1 on 13-Sep-16.
 */
public class Decaf extends Beverage {
    public Decaf(){
        description = "Decaf";
    }

    @Override
    public double cost() {
        return 1.05;
    }
}
