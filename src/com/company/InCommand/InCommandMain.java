package com.company.InCommand;

import com.company.InCommand.Commands.GarageDoorOpenCommand;
import com.company.InCommand.Commands.LightsOnCommand;
import com.company.InCommand.ConcreteObject.GarageDoor;
import com.company.InCommand.ConcreteObject.Light;
import com.company.InCommand.Invokers.SimpleRemoteControl;

/**
 * Created by lurtze1 on 20-Sep-16.
 */
public class InCommandMain {
    public static void main(String[] args) {
        SimpleRemoteControl remote = new SimpleRemoteControl();
        Light light = new Light();
        LightsOnCommand lightsOn = new LightsOnCommand(light);
        GarageDoor door = new GarageDoor();
        GarageDoorOpenCommand garageOpen = new GarageDoorOpenCommand(door);

        remote.setCommand(lightsOn);
        remote.buttonWasPressed();
        remote.setCommand(garageOpen);
        remote.buttonWasPressed();
    }
}
