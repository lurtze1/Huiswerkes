package com.company.Adapter;

import com.company.Adapter.Interfaces.Turkey;

/**
 * Created by lurtze1 on 21-Sep-16.
 */
public class WildTurkey implements Turkey {
    @Override
    public void gobble() {
        System.out.println("Gobble gobble");
    }

    @Override
    public void fly() {
        System.out.println("I'm flying a short distance");
    }
}
