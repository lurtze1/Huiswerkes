package com.company.DucksStrategy.NotDucks;

import com.company.DucksStrategy.Behaviors.Quack;
import com.company.DucksStrategy.Interfaces.QuackBehavior;

/**
 * Created by lurtze1 on 07-Sep-16.
 */
public class DuckCall {
    public DuckCall(){
        QuackBehavior quackBehavior = new Quack();
    }
}
