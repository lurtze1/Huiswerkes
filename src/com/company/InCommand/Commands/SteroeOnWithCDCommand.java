package com.company.InCommand.Commands;

import com.company.InCommand.ConcreteObject.Stereo;
import com.company.InCommand.Interfaces.Command;

/**
 * Created by lurtze1 on 20-Sep-16.
 */
public class SteroeOnWithCDCommand implements Command {
    Stereo stereo;

    public SteroeOnWithCDCommand(Stereo stereo) {
        this.stereo = stereo;
    }

    public void execute() {
        stereo.on();
        stereo.setCD();
        stereo.setVolume(11);

    }

    @Override
    public void undo() {

    }
}
