package com.company.InCommand.Commands;

import com.company.InCommand.ConcreteObject.Light;

/**
 * Created by lurtze1 on 20-Sep-16.
 */
public class LightsOffCommand {
    Light light;

    public LightsOffCommand(Light light){
        this.light = light;
    }

    public void execute(){
        light.off();
    }

    public void undo(){
        light.on();
    }
}
