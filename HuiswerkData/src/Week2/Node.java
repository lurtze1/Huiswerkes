package Week2;

/**
 * Created by lurtze1 on 15-Sep-16.
 */
public class Node<T> {
    Node nextNode;
    T Data;

    public Node(Node<T> nextNode) {
        this.nextNode = nextNode;
    }

    public Node(Node<T> nextNode, T Data) {
        this.nextNode = nextNode;
        this.Data = Data;
    }

    public Node(T Data){
        this.Data = Data;
    }

    public Node(){

    }

    public Node getNextNode() {
        return nextNode;
    }

    public void setNextNode(Node nextNode) {
        this.nextNode = nextNode;
    }

    public T getData() {
        return Data;
    }

    public void setData(T data) {
        this.Data = data;
    }
}
