package com.company.DucksStrategy;

import com.company.DucksStrategy.Behaviors.FlyWithWings;
import com.company.DucksStrategy.Behaviors.Quack;

/**
 * Created by lurtze1 on 07-Sep-16.
 */
public class MallardDuck extends Duck {
    public MallardDuck() {
        quackBehavior = new Quack();
        flyBehavior = new FlyWithWings();
    }

    public void display() {
        System.out.println("I'm a real Mallard Duck");
    }
}
