package com.company.Decorator.Beverages;

import com.company.Decorator.Beverage;

/**
 * Created by lurtze1 on 13-Sep-16.
 */
public class HouseBlend extends Beverage {
    public HouseBlend(){
        description = "House Blend Coffee";
    }

    public double cost(){
        return .89;
    }
}
