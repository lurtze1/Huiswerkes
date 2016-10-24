package com.company.Decorator.Condiments;

import com.company.Decorator.Beverage;
import com.company.Decorator.CondimentDecorator;

/**
 * Created by lurtze1 on 13-Sep-16.
 */
public class Soy extends CondimentDecorator {
    Beverage beverage;

    public Soy(Beverage beverage) {
        this.beverage = beverage;
    }

    public String getDescription() {
        return beverage.getDescription() + ", Soy";
    }

    public double cost() {
        return beverage.cost() + .15;
    }
}