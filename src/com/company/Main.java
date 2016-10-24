package com.company;

import com.company.DucksStrategy.Behaviors.FlyRocketPowered;
import com.company.DucksStrategy.Behaviors.MuteQuack;
import com.company.DucksStrategy.Duck;
import com.company.DucksStrategy.GanstaDuck;
import com.company.DucksStrategy.MallardDuck;
import com.company.DucksStrategy.ModelDuck;

public class Main {

    public static void main(String[] args) {
        Duck mallard = new MallardDuck();
        mallard.performFly();
        mallard.performQuack();

        Duck model = new ModelDuck();

        model.display();

        model.performFly();

        model.setFlyBehavior(new FlyRocketPowered());

        model.performFly();

        model.setQuackBehavior(new MuteQuack());

        model.performQuack();

        Duck model2 = new GanstaDuck();

        model2.performQuack();
        model2.performFly();
        model2.performShoot();
    }
}
