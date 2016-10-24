package com.company.InCommand.Commands;

import com.company.InCommand.Interfaces.Command;
import com.company.InCommand.ConcreteObject.Light;

/**
 * Created by lurtze1 on 20-Sep-16.
 */
public class LightsOnCommand implements Command {
    Light light;

    public LightsOnCommand(Light light){
        this.light = light;
    }

    public void execute(){
        light.on();
    }

    public void undo(){
        light.off();
    }

}
