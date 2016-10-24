package Week2;

/**
 * Created by lurtze1 on 15-Sep-16.
 */
public class MyLinkedList<T> implements SimpleLinkedList<T> {
    Node Header;
    private T t;
    private int length;

    public MyLinkedList() {
        this.Header = new Node(null);
        this.length = 0;
    }

    @Override
    public void addFirst(T data) {
        Node<T> newNode = new Node<T>(Header.nextNode, data);
        Header.setNextNode(newNode);
        this.length++;
    }

    @Override
    public void clear() {
        this.Header = null;
    }

    @Override
    public void print() {
        Node currentNode = Header.nextNode;
        for (int i = 0; i <= length; i++) {
            System.out.println(currentNode.Data);
            currentNode = currentNode.nextNode;
        }
    }

    public void insert(int index, T data) {
        Node currentNode = Header;
        Node newNode = new Node(data);
        for (int i = 0; i < index; i++) {
            currentNode = currentNode.nextNode;
        }
        newNode.nextNode = currentNode.nextNode;
        currentNode.nextNode = newNode;
    }

    @Override
    public void removeFirst() {
        Node Todelete = Header.nextNode;
        Header.nextNode = Todelete.nextNode;
        Todelete.nextNode = null;
    }

    @Override
    public T getFirst() {
        return (T)Header.nextNode.Data;
    }

    public T getT() {
        return t;
    }

    public void setT(T t) {
        this.t = t;
    }

    public int getLength() {
        return length;
    }
}
