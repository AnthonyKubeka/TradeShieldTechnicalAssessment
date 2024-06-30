namespace TS.TechnicalTest;

public class DeepestPitAnswer
{
    private class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    private class Triplet
    {
        public int? P { get; set; }
        public int? Q { get; set; }
        public int? R { get; set; }
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

        var coordinates = new List<Coordinate>();
        var xPosition = 0;
        foreach (var point in points)
        {
            coordinates.Add(new Coordinate(xPosition, point));
            xPosition++;
        }

        // a pit starts when we go down.
        //if we are declining starting at ai.Y, then we continue to decline until ai.Y <= a(i+1).Y
        

        var pitCoordinates = new List<Coordinate>();
        var turningPoints = new List<Coordinate>();
        for (int i = 0; i < coordinates.Count - 1; i++)
        {
            var isDeclining = coordinates[i].Y > coordinates[i + 1].Y;
            if (isDeclining)
            {
                pitCoordinates.Add(coordinates[i]);
                pitCoordinates.Add(coordinates[i + 1]);
            }

        }

        for (int i = 0; i < points.Length - 1; i++)
        {
            var triplet = new Triplet();
            triplet.P = points[i];
            if (points[triplet.P.Value+1] < points[triplet.P.Value])
            {
               //A[Q] = A[i+1]
               triplet.Q = points[triplet.P.Value + 1];
            }
            if (triplet.Q.HasValue)
            {
                if (triplet.Q.Value < points[triplet.Q.Value])
                {

                }
            }


        }

        //startX = P
        //turningPointX = Q


    }
}
