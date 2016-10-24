package com.company.DucksStrategy;

import com.company.DucksStrategy.Behaviors.FlyRocketPowered;
import com.company.DucksStrategy.Behaviors.Quack;
import com.company.DucksStrategy.Behaviors.ShootGun;

/**
 * Created by lurtze1 on 13-Sep-16.
 */
public class GanstaDuck extends Duck {
    public GanstaDuck(){
        quackBehavior = new Quack();
        flyBehavior = new FlyRocketPowered();
        shootBehavior = new ShootGun();
    }

    @Override
    public void display() {

    }
}
