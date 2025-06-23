namespace CodeWars
{
    internal class Kata_200625
    {
        // 1(5) 
        public static int getLoopSize(LoopDetector.Node startNode)
        {
            int answ = 0;
            var point_1 = startNode;
            var point_2 = startNode;

            do
            {
                point_1 = point_1.next;
                point_2 = point_2.next.next;
            }
            while (point_1 != point_2);

            do
            {
                point_1 = point_1.next;
                answ++;
            }
            while (point_1 != point_2);

            return answ;
        }

        public class LoopDetector
        {
            public class Node
            {
                public Node next { get; set; }
                public Node() { }
            }
        }



        // 2(5)
        public static string Rot13(string message)
        {
            var answ = "";

            foreach (char m in message)
            {
                if (m >= 'A' && m <= 'Z')
                {
                    answ += (char)('A' * ((m + 13) / ('Z' + 1)) + (m + 13) % ('Z' + 1));
                }
                else if (m >= 'a' && m <= 'z')
                {
                    answ += (char)('a' * ((m + 13) / ('z' + 1)) + (m + 13) % ('z' + 1));
                }
                else
                {
                    answ += m;
                }
            }

            return answ;
        }
    }
}
