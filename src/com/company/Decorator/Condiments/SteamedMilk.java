package com.company.Decorator.Condiments;

import com.company.Decorator.Beverage;
import com.company.Decorator.CondimentDecorator;

/**
 * Created by lurtze1 on 13-Sep-16.
 */
public class SteamedMilk extends CondimentDecorator {
    Beverage beverage;

    public SteamedMilk(Beverage beverage) {
        this.beverage = beverage;
    }

    public String getDescription() {
        return beverage.getDescription() + ", Steamed Milk";
    }

    public double cost() {
        return beverage.cost() + .10;
    }
}
