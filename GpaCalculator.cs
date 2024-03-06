// Define the student's name
string studentName = "Sophia Johnson";

// Define the names of the courses the student is taking
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

// Define the number of credit hours each course is worth
int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

// Define the numerical values of the grades A and B
int gradeA = 4;
int gradeB = 3;

// Assign these grade values to each course
int course1grade = gradeA;
int course2grade = gradeB;
int course3grade = gradeB;
int course4grade = gradeB;
int course5grade = gradeA;

// Initialize the total number of credit hours
int totalCreditHours = 0;

// Calculate the total number of credit hours by adding up the credit hours of each course
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

// Initialize the total grade points earned by the student
int totalGradePoints = 0;

// Calculate the total grade points earned by the student. This is done by multiplying the grade value of each course by the number of credit hours it's worth, and then adding these values together.
totalGradePoints += course1Credit * course1grade;
totalGradePoints += course2Credit * course2grade;
totalGradePoints += course3Credit * course3grade;
totalGradePoints += course4Credit * course4grade;
totalGradePoints += course5Credit * course5grade;

// Calculate the Grade Point Average (GPA) by dividing the total grade points by the total credit hours
decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

// Extract the first two decimal places of the GPA for display
int leadingDigit = (int)gradePointAverage;
int firstDigit = (int)(gradePointAverage * 10) % 10;
int secondDigit = (int)(gradePointAverage * 100) % 10;

// Display the student's name, their courses with their respective grades and credit hours, and their final GPA
Console.WriteLine($"Student: {studentName}");
Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");
Console.WriteLine($"{course1Name}\t\t\t{course1grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t\t{course4grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t\t{course5grade}\t\t{course5Credit}");
Console.WriteLine($"Final GPA:\t\t\t{leadingDigit}.{firstDigit}{secondDigit}");
