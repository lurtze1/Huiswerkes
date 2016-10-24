package com.company.DucksStrategy.Behaviors;

import com.company.DucksStrategy.Interfaces.QuackBehavior;

/**
 * Created by lurtze1 on 07-Sep-16.
 */
public class Quack implements QuackBehavior {
    @Override
    public void quack() {
        System.out.println("Quack");
    }
}
