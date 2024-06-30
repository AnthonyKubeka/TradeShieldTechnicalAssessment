namespace TS.TechnicalTest;

public class DeepestPitAnswer
{
    public static int Solution(int[] points)
    {
        //a pit (P, Q, R) is basically where A[P] until A[Q] strictly goes down
        //and A[Q] until A[R] strictly goes up

        /* eg: (2, 3, 4) A[2] until A[3] goes down (A[2] = 3 -> A[3] = -2)
         * A[3] until A[4] goes up (A[3] = -2 -> A[4] = 0)
         */

        //observed assumptions
        /* P is the x coordinate of start of a pit
         * Q is the x coordinate of the vertical line that goes through the deepest point of the pit
         * R is the x coordinate of the end of a pit
         * pits can overlap (2, 3, 4) and (2, 3, 5)
         */

    }
}
