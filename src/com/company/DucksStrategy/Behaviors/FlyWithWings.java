package com.company.DucksStrategy.Behaviors;

import com.company.DucksStrategy.Interfaces.FlyBehavior;

/**
 * Created by lurtze1 on 07-Sep-16.
 */
public class FlyWithWings implements FlyBehavior {
    @Override
    public void fly() {
        System.out.println("I'm flying!!");
    }
}
