package com.company.Decorator.Condiments;

import com.company.Decorator.Beverage;
import com.company.Decorator.CondimentDecorator;

/**
 * Created by lurtze1 on 13-Sep-16.
 */
public class Whip extends CondimentDecorator {
    Beverage beverage;

    public Whip(Beverage beverage) {
        this.beverage = beverage;
    }

    public String getDescription() {
        return beverage.getDescription() + ", Whip";
    }

    public double cost() {
        return beverage.cost() + .10;
    }
}

