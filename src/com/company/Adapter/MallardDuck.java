package com.company.Adapter;

import com.company.Adapter.Interfaces.Duck;

/**
 * Created by lurtze1 on 21-Sep-16.
 */
public class MallardDuck implements Duck {
    public void quack(){
        System.out.println("Quack");
    }

    @Override
    public void fly() {
        System.out.println("I'm flying");
    }
}
