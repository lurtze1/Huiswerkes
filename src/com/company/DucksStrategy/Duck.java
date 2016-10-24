package com.company.DucksStrategy;

import com.company.DucksStrategy.Interfaces.FlyBehavior;
import com.company.DucksStrategy.Interfaces.QuackBehavior;
import com.company.DucksStrategy.Interfaces.ShootBehavior;

/**
 * Created by lurtze1 on 07-Sep-16.
 * Deze klasse kopelt tussen de behaviors en de concrete klassen.
 *
 */
public abstract class Duck {



    FlyBehavior flyBehavior;
    QuackBehavior quackBehavior;
    ShootBehavior shootBehavior;

    public Duck() {

    }

    public abstract void display();

    public void performFly() {
        flyBehavior.fly();
    }

    public void performQuack() {
        quackBehavior.quack();
    }

    public void performShoot() {
        shootBehavior.shoot();
    }

    public void swim() {
        System.out.println("All ducks swim, even decoys!");
    }

    public void setFlyBehavior(FlyBehavior fb) {
        flyBehavior = fb;
    }

    public void setQuackBehavior(QuackBehavior qb) {
        quackBehavior = qb;
    }

    public void setShootBehavior(ShootBehavior sb) {
        shootBehavior = sb;
    }
}
