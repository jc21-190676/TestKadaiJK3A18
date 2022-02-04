using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTestKadai
{
    public class DirectedE
    {
        public static int[] SEARCH(int[] edgeFirst, int[] edgeNext, int x)
        {
            const int N = 6;    //グラフの点の個数
            const int M = 8;    //グラフの辺の個数
            int[] start = new int[] { 1, 2, 3, 4, 2, 5, 4, 6 }; //辺mの始点の番号が格納されている
            int[] end = new int[] { 2, 3, 4, 1, 5, 4, 6, 2 }; //辺mの終点の番号が格納されている
            int[] current = new int[N];
            int[] serched = new int[M];
            int[] path = new int[M];

            for (int i = 0; i < N; i++)
            { //各点での未探索の辺の番号を初期化
                current[i] = edgeFirst[i];
            }

            int top = 1;  //探索済みの経路の辺の格納位置
            int last = M; //確定済みの経路の辺の格納位置
            while (last >= 1)
            {
                int temp;
                if (current[x - 1] != 0)
                {
                    temp = current[x - 1];
                    serched[top - 1] = temp;
                    current[x - 1] = edgeNext[temp - 1];
                    x = end[temp - 1];
                    top++;
                }
                else
                {
                    top--;
                    temp = serched[top - 1];
                    path[last - 1] = temp;
                    x = start[temp - 1];
                    last--;
                }
            }
            return path;
        }
    }
}
