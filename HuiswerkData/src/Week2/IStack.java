package Week2;

/**
 * Created by lurtze1 on 15-Sep-16.
 */
public interface IStack<T> {
    void Push(T data);
    T Pop();
    T Top();
}
