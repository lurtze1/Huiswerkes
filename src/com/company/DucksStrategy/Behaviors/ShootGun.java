package com.company.DucksStrategy.Behaviors;

import com.company.DucksStrategy.Interfaces.ShootBehavior;

/**
 * Created by lurtze1 on 13-Sep-16.
 */
public class ShootGun implements ShootBehavior {
    @Override
    public void shoot() {
        System.out.println("Shoots his fucking gun.");
    }
}
