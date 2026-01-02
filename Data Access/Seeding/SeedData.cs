using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Seeding
{
public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
           
            modelBuilder.SeedCourses();
            modelBuilder.SeedExams();
            modelBuilder.SeedQuestions();
            modelBuilder.SeedChoices();
            modelBuilder.SeedExamQuestions();
            modelBuilder.SeedStudentExams();
            modelBuilder.SeedStudentAnswers();
        }

       

        private static void SeedCourses(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course { ID = 1, Name = "C# Basics", InstructorId = "1" },
                new Course { ID = 2, Name = "Web Development", InstructorId = "2" }
            );
        }

        

        private static void SeedExams(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exam>().HasData(
                new Exam { ID = 1, Name = "C# Quiz 1", Type = Entities.Enum.ExamType.Quiz, NumberOfQuestions = 3,  CourseId = 1 },
                new Exam { ID = 2, Name = "Final Web Exam", Type =Entities.Enum.ExamType.Final, NumberOfQuestions = 4,CourseId = 2 }
            );
        }

        private static void SeedQuestions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().HasData(
                new Question { ID = 1, Text = "What is C#?", Level = Entities.Enum.QuestionLevel.Simple, CreatedByInstructorId = "1" },
                new Question { ID = 2, Text = "What is OOP?", Level = Entities.Enum.QuestionLevel.Simple, CreatedByInstructorId = "1" },
                new Question { ID = 3, Text = "What is polymorphism?", Level = Entities.Enum.QuestionLevel.Simple, CreatedByInstructorId = "1"   },
                new Question { ID = 4, Text = "What is HTML?", Level = Entities.Enum.QuestionLevel.Hard, CreatedByInstructorId ="2" },
                new Question { ID = 5, Text = "What is CSS used for?", Level = Entities.Enum.QuestionLevel.Medium, CreatedByInstructorId = "2" }
            );
        }

        private static void SeedChoices(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Choice>().HasData(
                new Choice { ID = 1, QuestionId = 1, Text = "Programming Language", IsCorrect = true },
                new Choice { ID = 2, QuestionId = 1, Text = "Database", IsCorrect = false },
                new Choice {    ID = 3, QuestionId = 2,Text = "Object-Oriented Programming", IsCorrect = true },
                new Choice { ID = 4, QuestionId = 2, Text = "Web Server", IsCorrect = false },
                new Choice { ID = 5, QuestionId = 3, Text = "Many forms of objects", IsCorrect = true },
                new Choice { ID = 6, QuestionId = 3, Text = "Styling", IsCorrect = false },
                new Choice { ID = 7, QuestionId = 4, Text = "Markup Language", IsCorrect = true },
                new Choice { ID = 8, QuestionId = 4, Text = "Programming Framework", IsCorrect = false },
                new Choice { ID  = 9, QuestionId = 5, Text = "Styling Web Pages", IsCorrect = true },
                new Choice { ID = 10, QuestionId = 5, Text = "Database Management", IsCorrect = false }
            );
        }

        private static void SeedExamQuestions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExamQuestion>().HasData(
                new ExamQuestion { ID = 1, ExamId = 1, QuestionId = 1 },
                new ExamQuestion { ID = 2,  ExamId = 1, QuestionId = 2 },
                new ExamQuestion { ID = 3, ExamId = 1, QuestionId = 3 },
                new ExamQuestion { ID = 4,  ExamId = 2, QuestionId = 4 },
                new ExamQuestion { ID = 5, ExamId = 2, QuestionId = 5 }
            );
        }

        private static void SeedStudentExams(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentExam>().HasData(
                new StudentExam { ID = 1,  StudentId = "3", ExamId = 1, Score = 2,  },
                new StudentExam { ID = 2, StudentId = "4", ExamId = 1, Score = 3,},
                new StudentExam { ID = 3, StudentId = "4", ExamId = 2, Score = 1 }
            );
        }

        private static void SeedStudentAnswers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentAnswer>().HasData(
                new StudentAnswer { ID = 1, StudentExamId = 1, QuestionId = 1, ChoiceId = 1 },
                new StudentAnswer { ID = 2, StudentExamId = 1, QuestionId = 2, ChoiceId = 3 },
                new StudentAnswer { ID = 3, StudentExamId = 1, QuestionId = 3, ChoiceId = 6 },
                new StudentAnswer { ID = 4, StudentExamId = 2, QuestionId = 1, ChoiceId = 1 },
                new StudentAnswer { ID = 5, StudentExamId = 2, QuestionId = 2, ChoiceId = 4 },
                new StudentAnswer { ID = 6, StudentExamId =2 , QuestionId = 3, ChoiceId = 6 },
                new StudentAnswer {ID = 7, StudentExamId=1, QuestionId = 4, ChoiceId = 7 },
                new StudentAnswer { ID = 8, StudentExamId=1, QuestionId = 5, ChoiceId = 8 }
            );
        }

    }
}
