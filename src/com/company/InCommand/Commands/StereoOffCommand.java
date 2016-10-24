package com.company.InCommand.Commands;

import com.company.InCommand.ConcreteObject.Stereo;
import com.company.InCommand.Interfaces.Command;

/**
 * Created by lurtze1 on 20-Sep-16.
 */
public class StereoOffCommand implements Command {
    Stereo stereo;


    public StereoOffCommand(Stereo stereo) {
        this.stereo = stereo;
    }

    @Override
    public void execute() {
        stereo.off();
    }

    @Override
    public void undo() {

    }
}
