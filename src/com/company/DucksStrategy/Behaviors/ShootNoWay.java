package com.company.DucksStrategy.Behaviors;

import com.company.DucksStrategy.Duck;
import com.company.DucksStrategy.Interfaces.ShootBehavior;

/**
 * Created by lurtze1 on 13-Sep-16.
 */
public class ShootNoWay implements ShootBehavior {
    public void shoot() {
        System.out.println("This Duck cannot shoot.");
    }
}
