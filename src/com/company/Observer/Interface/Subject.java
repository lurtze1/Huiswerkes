package com.company.Observer.Interface;

/**
 * Created by lurtze1 on 07-Sep-16.
 */
public interface Subject {
    public void registerObserver(Observer o);
    public void removeObserver(Observer o);
    public void notifyObservers();
}
