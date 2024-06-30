namespace TS.TechnicalTest;

public class DeepestPitAnswer
{

    private class Triplet
    {
        public int? P { get; set; }
        public int? Q { get; set; }
        public int? R { get; set; }

        public int GetDepth(int[] points)
        {
            return Math.Min(points[P.Value] - points[Q.Value], points[R.Value] - points[Q.Value]); 
        }
    }

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

        var pitTriplets = new List<Triplet>(); 

        for (int i = 0; i < points.Length - 1; i++)
        {
            var pitTriplet = new Triplet();
            pitTriplet.P = i;

            if (points[pitTriplet.P.Value+1] < points[pitTriplet.P.Value])
            {
                //A[Q] = A[P+1]
                pitTriplet.Q = pitTriplet.P.Value + 1;
            }

            if (pitTriplet.Q.HasValue)
            {
                if (points[pitTriplet.Q.Value] < points[pitTriplet.Q.Value+1])
                {
                    //A[R] = A[Q+1]
                    pitTriplet.R = pitTriplet.Q.Value + 1;
                }
            }

            if (pitTriplet.P.HasValue && pitTriplet.Q.HasValue && pitTriplet.R.HasValue)
            {
                pitTriplets.Add(pitTriplet);
            }
        }
        
        if (!pitTriplets.Any())
        {
            return -1; 
        }

        var maxDepth = 0; 

        foreach (var triplet in pitTriplets)
        {
            if (maxDepth < triplet.GetDepth(points))
            {
                maxDepth = triplet.GetDepth(points);
            }
        }

        return maxDepth; 
    }
}
