package com.company.DucksStrategy;

import com.company.DucksStrategy.Behaviors.FlyNoWay;
import com.company.DucksStrategy.Behaviors.Quack;

/**
 * Created by lurtze1 on 07-Sep-16.
 */
public class ModelDuck extends Duck {
    public ModelDuck() {
        flyBehavior = new FlyNoWay();
        quackBehavior = new Quack();
    }

    @Override
    public void display() {
        System.out.println("I'm a model duck");
    }
}
