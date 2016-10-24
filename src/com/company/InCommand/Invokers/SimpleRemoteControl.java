package com.company.InCommand.Invokers;

import com.company.InCommand.Interfaces.Command;

/**
 * Created by lurtze1 on 20-Sep-16.
 */
public class SimpleRemoteControl {
    Command slot;
    public SimpleRemoteControl(){}

    public void setCommand(Command command){
        slot = command;
    }
    public void buttonWasPressed(){
        slot.execute();
    }
}
