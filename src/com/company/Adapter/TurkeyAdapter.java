package com.company.Adapter;

import com.company.Adapter.Interfaces.Turkey;

/**
 * Created by lurtze1 on 21-Sep-16.
 */
public class TurkeyAdapter implements com.company.Adapter.Interfaces.Duck {
    Turkey turkey;

    public TurkeyAdapter(Turkey turkey) {
        this.turkey = turkey;
    }

    @Override
    public void quack() {
        turkey.gobble();
    }

    @Override
    public void fly() {
        for (int i = 0; i < 5; i++) {
            turkey.fly();
        }
    }
}
