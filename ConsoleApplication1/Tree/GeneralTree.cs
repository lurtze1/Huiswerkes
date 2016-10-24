namespace AD
{
    public class GeneralTree<T>
    {

        public T Data;
        public TreeNode<T> FirstChildNode;

        public GeneralTree(T data)
        {
            Data = data;
        }

        public GeneralTree(T data, TreeNode<T> firstChildNode)
        {
            Data = data;
            FirstChildNode = firstChildNode;
        }


        public void SetChild(TreeNode<T> child)
        {
            FirstChildNode = child;
        }

        public int GetSize()
        {
            return 1 + FirstChildNode.GetSize();
        }
    }
}