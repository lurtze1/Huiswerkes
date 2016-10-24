package Week2;

/**
 * Created by lurtze1 on 15-Sep-16.
 */
public class MyStack<T> implements IStack<T> {
    MyLinkedList<T> list = new MyLinkedList<T>();

    public void Push(T data) {
        list.addFirst(data);
    }

    @Override
    public T Pop() {
        T first = list.getFirst();
        list.removeFirst();
        return first;
    }

    @Override
    public T Top() {
        return list.getFirst();
    }

    public int getLength() {
        return list.getLength();
    }
}
