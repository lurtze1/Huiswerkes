package com.company.InCommand.Commands;

import com.company.InCommand.ConcreteObject.GarageDoor;
import com.company.InCommand.Interfaces.Command;

/**
 * Created by lurtze1 on 20-Sep-16.
 */
public class GarageDoorOpenCommand implements Command {
    GarageDoor door;

    public GarageDoorOpenCommand(GarageDoor door) {
        this.door = door;
    }

    @Override
    public void execute() {
        door.up();
    }

    @Override
    public void undo() {
        
    }
}
