package com.company.DucksStrategy.Behaviors;

import com.company.DucksStrategy.Interfaces.FlyBehavior;

/**
 * Created by lurtze1 on 07-Sep-16.
 */
public class FlyNoWay implements FlyBehavior {
    @Override
    public void fly() {
        System.out.println("I can't fly :(");
    }
}
