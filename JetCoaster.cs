using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTestKadai
{
    public class JetCoaster
    {
        /*  int k : 定員
         *  int[] g ：グループごとの人数
         *  int r 　：動かす回数
         */
        public static int ride(int k, int[] g, int r)
        {
            Queue<int> qu = new Queue<int>();
            for (int i = 0; i < g.Length; i++)
            {  //キューにグループごとの人数を追加
                qu.Enqueue(g[i]);
            }

            int totalCnt = 0;  //合計乗車人数
            int tmpQu = 0;  //仮のキューデータ
            for (int i = 0; i < r; i++)
            {
                for (int n = 0; n < g.Length; n++)
                {
                    tmpQu += qu.Peek();  //行列の先頭を取得(取出さない)
                    if (tmpQu <= k)
                    {  //取出したグループの人数が、定員未満の時
                        int tmp = qu.Dequeue(); //値を取得(削除する)
                        totalCnt += tmp;
                        qu.Enqueue(tmp);  //値を代入
                    }
                    else
                    {
                        break;
                    }
                }
                tmpQu = 0;
            }
            return totalCnt;
        }
    }
}
