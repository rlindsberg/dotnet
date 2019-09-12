namespace GradeBook
{
    public class Statistics
    {
        private double _averageGrade;
        private double _highGrade;
        private double _lowGrade;

        public Statistics()
        {
            _averageGrade = 0;
            _highGrade = 0;
            _lowGrade = 0;
        }

        public void SetGrade(double averageGrade, double highGrade, double lowGrade)
        {
            this._averageGrade = averageGrade;
            this._highGrade = highGrade;
            this._lowGrade = lowGrade;
        }

        public double GetAverage()
        {
            return this._averageGrade;
        }
    }
}