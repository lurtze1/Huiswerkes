package com.company.Decorator.Beverages;

import com.company.Decorator.Beverage;

/**
 * Created by lurtze1 on 13-Sep-16.
 */
public class DarkRoast extends Beverage {
    public DarkRoast() {
        description = "DarkRoast";
    }

    @Override
    public double cost() {
        double price;
        if (this.getSize().equals(Size.Venti)) {
            price = 1.10;
        } else if (this.getSize().equals(Size.Grande)) {
            price = 1.20;
        } else {
            price = .99;
        }
        return price;
    }
}
