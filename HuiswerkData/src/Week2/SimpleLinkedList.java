package Week2;

/**
 * Created by lurtze1 on 15-Sep-16.
 */
public interface SimpleLinkedList<T> {
    void addFirst(T data);

    void clear();

    void print();

    void insert(int index, T data);

    void removeFirst();

    T getFirst();
}
