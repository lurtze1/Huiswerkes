namespace AD
{
    public class TreeNode<T>
    {
        public T Data;
        public TreeNode<T> FirstChildNode;
        public TreeNode<T> NextSiblingNode;

        public TreeNode(T data)
        {
            Data = data;
        }

        public TreeNode(T data, TreeNode<T> firstChildNode, TreeNode<T> nextSiblingNode)
        {
            Data = data;
            FirstChildNode = firstChildNode;
            NextSiblingNode = nextSiblingNode;
        }

        public void SetChild(TreeNode<T> child)
        {
            FirstChildNode = child;
        }

        public void SetSibling(TreeNode<T> child)
        {
            NextSiblingNode = child;
        }

        public int GetSize()
        {
            if ((FirstChildNode == null) && (NextSiblingNode == null))
                return 1;
            int tmp = 0;
            if (FirstChildNode != null)
                tmp += FirstChildNode.GetSize();
            if (NextSiblingNode != null)
                tmp += NextSiblingNode.GetSize();
            return 1 + tmp;
        }
    }
}