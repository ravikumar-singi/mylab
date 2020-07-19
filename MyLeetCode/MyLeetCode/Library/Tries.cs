namespace Leetcode
{
    static class Constants
    {
        // we are only dealing with keys with chars 'a' to 'z'
        public static int ALPHABET_SIZE = 26;
        public static int NON_VALUE = -1;
    }
    public class TrieNode
    {
        public bool isLeafNode;
        public int value;

        public TrieNode[] Children;

        public TrieNode(bool isLeafNode, int value)
        {
            this.value = value;
            this.isLeafNode = isLeafNode;
            Children = new TrieNode[Constants.ALPHABET_SIZE];
        }

        public void markAsLeaf(int value)
        {
            this.isLeafNode = true;
            this.value = value;
        }
    }
    public class Trie
    {
        TrieNode root;
        Trie()
        {
            this.root = new TrieNode(false, Constants.NON_VALUE);
        }

        private int getIndex(char ch)
        {
            return ch - 'a';
        }

        public int search(string key)
        {
            // null keys are not allowed
            if (key == null)
            {
                return Constants.NON_VALUE;
            }

            TrieNode currentNode = this.root;
            int charIndex = 0;

            while ((currentNode != null) && (charIndex < key.Length))
            {
                int childIndex = getIndex(key[charIndex]);

                if (childIndex < 0 || childIndex >= Constants.ALPHABET_SIZE)
                {
                    return Constants.NON_VALUE;
                }
                currentNode = currentNode.Children[childIndex];

                charIndex += 1;

            }

            if (currentNode != null)
            {
                return currentNode.value;
            }

            return Constants.NON_VALUE;
        }

        public void insert(string key, int value)
        {
            // null keys are not allowed
            if (key == null) return;

            key = key.ToLower();

            TrieNode currentNode = this.root;
            int charIndex = 0;

            while (charIndex < key.Length)
            {
                int childIndex = getIndex(key[charIndex]);

                if (childIndex < 0 || childIndex >= Constants.ALPHABET_SIZE)
                {
                    System.Console.WriteLine("Invalid Key");
                    return;
                }

                if (currentNode.Children[childIndex] == null)
                {
                    currentNode.Children[childIndex] = new TrieNode(false, Constants.NON_VALUE);
                }

                currentNode = currentNode.Children[childIndex];
                charIndex += 1;
            }
            currentNode.markAsLeaf(value);
        }
    }
}