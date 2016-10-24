package com.company.Decorator.Beverages;

import com.company.Decorator.Beverage;

/**
 * Created by lurtze1 on 13-Sep-16.
 */
public class Espresso extends Beverage {
    public Espresso(){
        description = "Espresso";
    }

    @Override
    public double cost() {
        int cost;
        return 1.99;
    }
}
