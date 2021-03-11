namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    //tinfo200:[2021-03-02-javier3-dykstra1] ties together students and courses into specific enrollments and ties to grades
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public Student Student { get; set; }
    }
}